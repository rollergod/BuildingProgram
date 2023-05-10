
using BuildingProgram.Context;
using BuildingProgram.Tools;

namespace BuildingProgram.Forms
{
    public partial class BuildingCompanyForm : OldBaseForm
    {
        private readonly AppDbContext _context;
        private int _companyId;
        bool siderbarExpand = false;
        bool reportCollapse = true;
        public BuildingCompanyForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void btn_AddBuildingCompany_Click(object sender, EventArgs e)
        {
            
        }

        private void BuildingCompanyForm_Load(object sender, EventArgs e)
        {
            var companies = _context.BuildingCompanies.ToList();

            dataGridView1.DataSource = companies;

            dataGridView1.Columns[0].HeaderText = "Номер строительной компании";
            dataGridView1.Columns[1].HeaderText = "Название";

            dataGridView1.Columns[1].Width = 250;
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
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ObjectForm_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void btn_OrgForm_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
        }

        private void btn_LandForm_Click(object sender, EventArgs e)
        {
            LandForm landForm = new LandForm();
            landForm.ShowDialog();
        }

        private void btn_BuildingCompanyForm_Click(object sender, EventArgs e)
        {
           //Building Company Form
        }

        private void btn_RepForm_Click(object sender, EventArgs e)
        {
            ReportForm repForm = new ReportForm();
            repForm.ShowDialog();
        }

        private void btn_BuildingCompanyRep_Click(object sender, EventArgs e)
        {
            BuildingCompanyReportForm buildingCompanyReportForm = new BuildingCompanyReportForm();
            buildingCompanyReportForm.ShowDialog();
        }

        private void menuPicture_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_ReportForm_Click(object sender, EventArgs e)
        {
            reportTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    siderbarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    siderbarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void reportTimer_Tick(object sender, EventArgs e)
        {
            if (reportCollapse)
            {
                reportContainer.Height += 10;
                if (reportContainer.Height == reportContainer.MaximumSize.Height)
                {
                    reportCollapse = false;
                    reportTimer.Stop();
                }
            }
            else
            {
                reportContainer.Height -= 10;
                if (reportContainer.Height == reportContainer.MinimumSize.Height)
                {
                    reportCollapse = true;
                    reportTimer.Stop();
                }
            }
        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            string textToSearch = tb_Search.Text;

            var buildingCompanies = _context.BuildingCompanies.Where(x => x.Name.Contains(textToSearch)).ToList();

            dataGridView1.DataSource = buildingCompanies;
        }

        private void btn_AddBuildingCompany_Click_1(object sender, EventArgs e)
        {
            AddBuildingCompanyForm addBuildingCompanyForm = new AddBuildingCompanyForm();
            addBuildingCompanyForm.ShowDialog();
        }

        private void btn_ChangeBtn_Click_1(object sender, EventArgs e)
        {
            AddBuildingCompanyForm addBuildingCompanyForm = new AddBuildingCompanyForm(_companyId);
            addBuildingCompanyForm.ShowDialog();
        }
    }
}
