using BuildingProgram.Context;
using BuildingProgram.Models;
using BuildingProgram.Tools;

namespace BuildingProgram.Forms
{
    public partial class AddBuildingCompanyForm : BaseForm
    {
        private int _companyId;
        private readonly AppDbContext _context;
        public AddBuildingCompanyForm(int companyId = 0)
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
            _companyId = companyId;
        }

        private void btn_AddOrg_Click(object sender, EventArgs e)
        {
            string name = tb_BuildingCompanyName.Texts;

            if(_companyId == 0)
            {
                var buildingCompany = new BuildingCompany() { Name = name };

                _context.BuildingCompanies.Add(buildingCompany);
            }
            else
            {
                var buildingCompanyForChange = _context.BuildingCompanies.FirstOrDefault(x => x.Id == _companyId);

                buildingCompanyForChange.Name = name;
                _context.Update(buildingCompanyForChange);
            }
            _context.SaveChanges();
            MessageBox.Show(_companyId > 0 ? "Данные строительной компании успешно изменены" : "Добавлена новая строительная компания");
        }

        private void AddBuildingCompanyForm_Load(object sender, EventArgs e)
        {
            if(_companyId > 0)
            {
                btn_AddOrg.Text = "Изменить строительную компанию";

                var buildingCompany = _context.BuildingCompanies.FirstOrDefault(x => x.Id == _companyId);

                tb_BuildingCompanyName.Texts = buildingCompany.Name;
            }
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
            //СПРАВКА
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
