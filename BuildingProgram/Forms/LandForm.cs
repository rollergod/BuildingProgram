using BuildingProgram.Context;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BuildingProgram.Forms
{
    public partial class LandForm : OldBaseForm
    {
        private AppDbContext _context;
        private int _landId;

        bool siderbarExpand = false;
        bool reportCollapse = true;
        public LandForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void LandForm_Load(object sender, EventArgs e)
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
            
        }

        private void btn_ObjectForm_Click(object sender, EventArgs e)
        {
            MainMenu objForm = new MainMenu();
            objForm.ShowDialog();
        }

        private void btn_OrgForm_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
        }

        private void btn_LandForm_Click(object sender, EventArgs e)
        {
            // LAnd Form
        }

        private void btn_BuildingCompanyForm_Click(object sender, EventArgs e)
        {
            BuildingCompanyForm buildingCompanyForm = new BuildingCompanyForm();
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

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            string cadastralNum = tb_Search.Text;

            var data = _context.Lands.Select(x => new
            {
                x.Id,
                x.CadastralNumber,
                x.Square,
                x.Owner.OrganizationName,
            });

            if (string.IsNullOrEmpty(cadastralNum))
                dataGridView1.DataSource = data.ToList();

            var lands = data
                .Where(x => x.CadastralNumber.Contains(cadastralNum))
                .ToList();

            dataGridView1.DataSource = lands;
        }

        private void btn_AddOrganization_Click_1(object sender, EventArgs e)
        {
            AddLandForm addLandForm = new AddLandForm();
            addLandForm.ShowDialog();
        }

        private void btn_ChangeOrganization_Click_1(object sender, EventArgs e)
        {
            AddLandForm changeLandForm = new AddLandForm(_landId);
            changeLandForm.ShowDialog();
        }
    }
}
