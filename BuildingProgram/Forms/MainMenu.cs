using BuildingProgram.Context;
using BuildingProgram.Models;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BuildingProgram.Forms
{
    public partial class MainMenu : BaseForm
    {
        private AppDbContext _context;
        private int _objNum = 0;
        public MainMenu()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();

            _context = new AppDbContext();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            var buildingObjects = _context.BuildingObjects.Include(x => x.Land).ToList();

            var data = buildingObjects.Select(x => new
            {
                x.ObjectNumber,
                x.Land.Address,
                isChecked = x.IsChecked ? "Да" : "Нет",
                isEnded = x.IsBuildingEnded ? "Да" : "Нет",
            }).ToList();

            dataGridView1.DataSource = data;
            
            dataGridView1.Columns[0].HeaderText = "Номер объекта";
            dataGridView1.Columns[1].HeaderText = "Адрес";
            dataGridView1.Columns[2].HeaderText = "Проверен ли объект";
            dataGridView1.Columns[3].HeaderText = "Закончена ли стройка";

            dataGridView1.Columns[1].Width= 275;
        }

        private void btn_AddObject_Click(object sender, EventArgs e)
        {
            AddNewObject addObjForm = new AddNewObject();
            addObjForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
        }

        private void земельныеУчасткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandForm landForm = new LandForm();
            landForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //objNum
            _objNum = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            if (_objNum > 0)
            {
                btn_ChangeBtn.Enabled = true;
                btn_AboutObject.Enabled = true;
            }
        }

        private void btn_ChangeBtn_Click(object sender, EventArgs e)
        {
            AddNewObject addLandForm = new AddNewObject(_objNum);
            addLandForm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Main Menu
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // справка
        }

        private void btn_AboutObject_Click(object sender, EventArgs e)
        {
            ObjectForm objForm = new ObjectForm(_objNum);
            objForm.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchText = tb_Search.Text;

            var data = _context.BuildingObjects.Include(x => x.Land)
                    .Select(x => new
                    {
                        x.ObjectNumber,
                        x.Land.Address,
                        isChecked = x.IsChecked ? "Да" : "Нет",
                        isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    });

            if (string.IsNullOrEmpty(searchText))

                dataGridView1.DataSource = data.ToList();

            var searchedObjects = SearchData(searchText)
                .Select(x => new
                {
                    x.ObjectNumber,
                    x.Land.Address,
                    isChecked = x.IsChecked ? "Да" : "Нет",
                    isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                }).ToList();

            dataGridView1.DataSource = searchedObjects;
        }

        private List<BuildingObject> SearchData(string searchText)
        {
            int objectNumber;
            bool isNumber = int.TryParse(searchText, out objectNumber);

            return _context.BuildingObjects.Include(x => x.Land)
                .Where(x => isNumber ? x.ObjectNumber.ToString().Contains(searchText) : x.Land.Address.Contains(searchText))
                .ToList();
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
