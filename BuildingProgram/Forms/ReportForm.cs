
using BuildingProgram.Context;
using BuildingProgram.Models;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;

namespace BuildingProgram.Forms
{
    public partial class ReportForm : BaseForm
    {
        private AppDbContext _context;
        int cbType;
        public ReportForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            menuStrip1.Renderer = new NoHighlightRenderer();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            var lands = _context.Lands.Include(x => x.Owner).ToList();

            var data = lands.Select(x => new
            {
                x.Id,
                x.CadastralNumber,
                x.Square,
                x.Owner.OrganizationName,
            }).ToList();

            dataGridView1.DataSource = data;

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Кадастровый номер";
            dataGridView1.Columns[2].HeaderText = "Площадь(М^2)";
            dataGridView1.Columns[3].HeaderText = "Владелец";

            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 150;
        }

        private void cb_LandType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbType = cb_LandType.SelectedIndex;

            var data = (IQueryable<Land>)_context.Lands
                .Include(x => x.Owner);

            switch (cbType)
            {
                case 0:
                case 1:
                case 2:
                    data = data.Where(x => x.LandType == cbType);
                    dataGridView1.DataSource = data.
                        Select(x => new
                        {
                            x.Id,
                            x.CadastralNumber,
                            x.Square,
                            x.Owner.OrganizationName,
                        }).ToList();
                    break;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainMenu objForm = new MainMenu();
            objForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
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

        private void поСтроительнымКомпаниямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildingCompanyReportForm buildingCompanyReportForm = new BuildingCompanyReportForm();
            buildingCompanyReportForm.ShowDialog();
        }

        private void xToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void поЗемельнымУчасткамToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
