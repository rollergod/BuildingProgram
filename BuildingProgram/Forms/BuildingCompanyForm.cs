
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
    }
}
