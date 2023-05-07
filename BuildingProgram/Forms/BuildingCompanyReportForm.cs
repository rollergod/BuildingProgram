using BuildingProgram.Context;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;

namespace BuildingProgram.Forms
{
    public partial class BuildingCompanyReportForm : BaseForm
    {
        private readonly AppDbContext _context;
        public BuildingCompanyReportForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
        }

        private void поЗемельнымУчасткамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void cb_BuildingCompanies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string companyName = cb_BuildingCompanies.SelectedValue.ToString();

            var buildingObjectWithCurrentCompany = _context.BuildingObjects
                .Include(x => x.BuildingCompany)
                .Where(x => x.BuildingCompany.Name == companyName)
                .Select(x => new
                {
                    x.ObjectNumber,
                    x.Land.Address,
                    isChecked = x.IsChecked ? "Да" : "Нет",
                    isEnded = x.IsBuildingEnded ? "Да" : "Нет",
                    x.BuildingCompany.Name,
                    x.StartPlanned,
                    x.StartActual,
                    x.EndDate
                })
                .ToList();

            dataGridView1.DataSource = buildingObjectWithCurrentCompany;

            dataGridView1.Columns[0].HeaderText = "Номер объекта";
            dataGridView1.Columns[1].HeaderText = "Адрес";
            dataGridView1.Columns[2].HeaderText = "Проверен ли объект";
            dataGridView1.Columns[3].HeaderText = "Закончена ли стройка";
            dataGridView1.Columns[4].HeaderText = "Строительная компания";
            dataGridView1.Columns[5].HeaderText = "Начало плановое";
            dataGridView1.Columns[6].HeaderText = "Начало фактическое";
            dataGridView1.Columns[7].HeaderText = "Конец";

            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 76;
            dataGridView1.Columns[3].Width = 76;
        }

        private void BuildingCompanyReportForm_Load(object sender, EventArgs e)
        {
            cb_BuildingCompanies.DataSource = _context.BuildingCompanies.Select(x => x.Name).ToList();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

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

        private void поЗемельнымУчасткамToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ReportForm repForm = new ReportForm();
            repForm.ShowDialog();
        }

        private void поСтроительнымКомпаниямToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
