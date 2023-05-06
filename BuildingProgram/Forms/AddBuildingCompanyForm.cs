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
            }
        }
    }
}
