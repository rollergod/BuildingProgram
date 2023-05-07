using BuildingProgram.Context;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BuildingProgram.Forms
{
    public partial class LandForm : BaseForm
    {
        private AppDbContext _context;
        private int _landId;
        public LandForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
        }

        private void LandForm_Load(object sender, EventArgs e)
        {
            var lands = _context.Lands.Include(x => x.Seller).ToList();

            var data = lands.Select(x => new
            {
                x.Id,
                x.CadastralNumber,
                x.Square,
                x.Seller.OrganizationName,
                isSold = x.IsSold ? "Да" : "Нет"
            }).ToList();

            dataGridView1.DataSource = data;

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Кадастровый номер";
            dataGridView1.Columns[2].HeaderText = "Площадь(М^2)";
            dataGridView1.Columns[3].HeaderText = "Продавец";
            dataGridView1.Columns[4].HeaderText = "Продан";

            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 150;
        }

        private void btn_AddOrganization_Click(object sender, EventArgs e)
        {
            AddLandForm addLandForm = new AddLandForm();
            addLandForm.ShowDialog();   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _landId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            if(_landId > 0)
            {
                btn_ChangeOrganization.Enabled = true;
            }
        }

        private void btn_ChangeOrganization_Click(object sender, EventArgs e)
        {
            AddLandForm changeLandForm = new AddLandForm(_landId);
            changeLandForm.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string cadastralNum = tb_Search.Text;

            var data = _context.Lands.Select(x => new
            {
                x.Id,
                x.CadastralNumber,
                x.Square,
                x.Seller.OrganizationName,
                isSold = x.IsSold ? "Да" : "Нет"
            });

            if (string.IsNullOrEmpty(cadastralNum))
                dataGridView1.DataSource = data.ToList();

            var lands = data
                .Where(x => x.CadastralNumber.Contains(cadastralNum))
                .ToList();

            dataGridView1.DataSource = lands;
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainMenu objForm = new MainMenu();
            objForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrganizationForm organizationForm = new OrganizationForm();
            organizationForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //справка
        }

        private void земельныеУчасткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandForm landForm = new LandForm();
            landForm.ShowDialog();
        }

        private void строительныеКомпанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildingCompanyForm buildingCompanyForm = new BuildingCompanyForm();
            buildingCompanyForm.ShowDialog();
        }

        private void поЗемельнымУчасткамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void поСтроительнымКомпаниямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildingCompanyReportForm buildingCompanyReportForm = new BuildingCompanyReportForm();
            buildingCompanyReportForm.ShowDialog();
        }

        private void xToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
