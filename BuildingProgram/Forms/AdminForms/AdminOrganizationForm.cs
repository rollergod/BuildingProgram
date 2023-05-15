

using BuildingProgram.Context;
using BuildingProgram.Models;
using Microsoft.EntityFrameworkCore;

namespace BuildingProgram.Forms.AdminForms
{
    public partial class AdminOrganizationForm : OldBaseForm
    {
        private AppDbContext _context;
        private int _orgId;
        bool siderbarExpand = false;
        bool reportCollapse = true;
        public AdminOrganizationForm(int orgId = 0)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _orgId = orgId;
        }

        private void AdminOrganizationForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Organizations.ToList();

            dataGridView1.Columns[0].HeaderText = "Номер организации";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Директор";

            dataGridView1.Columns[1].Width = 375;
        }

        private void btn_ObjectForm_Click(object sender, EventArgs e)
        {
            MainMenu objForm = new MainMenu();
            objForm.ShowDialog();
        }

        private void btn_OrgForm_Click(object sender, EventArgs e)
        {
            AdminOrganizationForm orgForm = new AdminOrganizationForm();
            orgForm.ShowDialog();
        }

        private void btn_LandForm_Click(object sender, EventArgs e)
        {
            AdminLandForm landForm = new AdminLandForm();
            landForm.ShowDialog();
        }

        private void btn_BuildingCompanyForm_Click(object sender, EventArgs e)
        {
            AdminBuildingCompanyForm buildingCompanyForm = new AdminBuildingCompanyForm();
            buildingCompanyForm.ShowDialog();
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

        private void btn_AddOrg_Click(object sender, EventArgs e)
        {
            AddOrgForm addOrgForm = new AddOrgForm();
            addOrgForm.ShowDialog();
        }

        private void btn_ChangeOrg_Click(object sender, EventArgs e)
        {
            AddOrgForm changeOrgForm = new AddOrgForm(_orgId);
            changeOrgForm.ShowDialog();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchText = tb_Search.Text;

            if (string.IsNullOrEmpty(searchText))
                dataGridView1.DataSource = _context.Organizations.ToList();

            var searchedObjects = SearchData(searchText);

            dataGridView1.DataSource = searchedObjects;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _orgId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            if (_orgId > 0)
            {
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                lb_ObjectsNum.Visible = true;
                lb_OrgName.Visible = true;
                lb_TotalSum.Visible = true;

                btn_ChangeOrg.Enabled = true;

                var data = _context.Lands.Include(x => x.Owner).Where(x => x.Owner.Id == _orgId);

                var landIds = data.Select(x => x.Id);
                var buildingObjects = _context.BuildingObjects
                    .Include(x => x.Land)
                    .Where(x => landIds.Contains(x.LandId)).ToList();

                var buildingsCount = data.Count();

                var totalSum = buildingObjects
                    .Sum(x => x.Land.BuyPrice);

                var today = DateOnly.FromDateTime(DateTime.Today);
                var latestObject = buildingObjects
                    .Where(x => x.IsBuildingEnded)
                    .OrderByDescending(x => x.EndDate)
                    .FirstOrDefault();

                lb_ObjectsNum.Text = buildingsCount.ToString();
                lb_TotalSum.Text = totalSum.ToString();
                lb_OrgName.Text = latestObject.EndDate.ToString();
            }
        }

        private List<Organization> SearchData(string searchText)
        {
            return _context.Organizations
                .Where(x => x.OrganizationName.Contains(searchText) || x.DirectorName.Contains(searchText))
                .ToList();
        }
    }
}
