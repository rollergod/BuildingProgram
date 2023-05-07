
using BuildingProgram.Context;
using BuildingProgram.Tools;

namespace BuildingProgram.Forms
{
    public partial class BuildingCompanyForm : BaseForm
    {
        private readonly AppDbContext _context;
        private int _companyId;
        public BuildingCompanyForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
        }

        private void btn_AddBuildingCompany_Click(object sender, EventArgs e)
        {
            AddBuildingCompanyForm addBuildingCompanyForm = new AddBuildingCompanyForm();
            addBuildingCompanyForm.ShowDialog();
        }

        private void BuildingCompanyForm_Load(object sender, EventArgs e)
        {
            var companies = _context.BuildingCompanies.ToList();

            dataGridView1.DataSource = companies;

            dataGridView1.Columns[0].HeaderText = "Номер строительной компании";
            dataGridView1.Columns[1].HeaderText = "Название";

            dataGridView1.Columns[1].Width = 200;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _companyId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            if(_companyId > 0 )
            {
                btn_ChangeBtn.Enabled = true;
            }
        }

        private void btn_ChangeBtn_Click(object sender, EventArgs e)
        {
            AddBuildingCompanyForm addBuildingCompanyForm = new AddBuildingCompanyForm(_companyId);
            addBuildingCompanyForm.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string textToSearch = tb_Search.Text;

            var buildingCompanies = _context.BuildingCompanies.Where(x => x.Name.Contains(textToSearch)).ToList();

            dataGridView1.DataSource = buildingCompanies;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void поЗемельнымУчасткамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm repForm = new ReportForm();
            repForm.ShowDialog();
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
    }
}
