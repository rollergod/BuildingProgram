using BuildingProgram.Context;
using BuildingProgram.Models;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;

namespace BuildingProgram.Forms
{
    public partial class AddOrgForm : BaseForm
    {
        private AppDbContext _context;
        private int _orgId;
        public AddOrgForm(int orgId = 0)
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
            _orgId = orgId;
        }

        private void btn_AddOrg_Click(object sender, EventArgs e)
        {
            string orgName = tb_OrgName.Texts;
            string director = tb_Director.Texts;

            var isOrgWithCurrentNameExist = _context.Organizations.Any(x => x.OrganizationName == orgName);

            if(isOrgWithCurrentNameExist && _orgId == 0)
            {
                MessageBox.Show("Организация с таким именем существует");
                return;
            }

            if(_orgId == 0)
            {
                var newOrg = new Organization
                {
                    OrganizationName = orgName,
                    DirectorName = director,
                };

                _context.Organizations.Add(newOrg);
            }
            else
            {
                var orgForChange = _context.Organizations.FirstOrDefault(x => x.Id == _orgId);

                orgForChange.OrganizationName = orgName;
                orgForChange.DirectorName = director; 

                _context.Organizations.Update(orgForChange);
            }

            _context.SaveChanges();

            MessageBox.Show(_orgId == 0 ? "Организация успешно добавлена" : "Данные организации были успешно изменены.");
        }

        private void AddOrgForm_Load(object sender, EventArgs e)
        {
            if(_orgId > 0)
            {
                this.Text = "Изменение организации";

                var org = _context.Organizations.FirstOrDefault(x => x.Id == _orgId);

                tb_Director.Texts = org.DirectorName;
                tb_OrgName.Texts = org.OrganizationName;

                btn_AddOrg.Text = "Изменить организацию";
            }
        }
    }
}
