using BuildingProgram.Context;
using BuildingProgram.Models;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BuildingProgram.Forms
{
    public partial class AddLandForm : OldBaseForm
    {
        private AppDbContext _context;
        private int _landId;
        public AddLandForm(int landId = 0)
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
            _landId = landId;
        }

        private void AddLandForm_Load(object sender, EventArgs e)
        {
            var organizationNames = _context.Organizations
                .Select(x => x.OrganizationName)
                .ToList();

            cb_OwnerId.DataSource = organizationNames;

            if (_landId > 0)
            {
                this.Text = "Изменение земельного участка";

                var land = _context.Lands.Include(x => x.Owner).FirstOrDefault(x => x.Id == _landId);

                tb_CadastralNum.Texts = land.CadastralNumber;
                tb_Address.Texts = land.Address;
                tb_BuyPrice.Texts = land.BuyPrice.ToString();
                tb_SellPrice.Texts = land.SellPrice.ToString();
                tb_Square.Texts = land.Square.ToString();

                cb_OwnerId.Text = land.Owner.OrganizationName;
                cb_LandType.SelectedIndex = land.LandType.Value;

                if (land.LandType.HasValue) 
                    cb_LandType.SelectedIndex = land.LandType.Value;

                btn_AddLand.Text = "Сохранить изменения";
            }
        }

        private void btn_AddLand_Click(object sender, EventArgs e)
        {
            // TODO : добавить валидацию 
            string cadastral = tb_CadastralNum.Texts;
            string address = tb_Address.Texts;
            decimal buyPrice = Convert.ToDecimal(tb_BuyPrice.Texts);
            decimal sellPrice = Convert.ToDecimal(tb_SellPrice.Texts);
            double square = Convert.ToDouble(tb_Square.Texts);
            string ownerOrgName = cb_OwnerId.SelectedValue.ToString();
            int landType = cb_LandType.SelectedIndex;

            var ownerOrganization = _context.Organizations.FirstOrDefault(x => x.OrganizationName == ownerOrgName);

            if(_landId == 0)
            {
                Land landForAdd = new Land
                {
                    CadastralNumber = cadastral,
                    Address = address,
                    BuyPrice = buyPrice,
                    SellPrice = sellPrice,
                    OwnerId = ownerOrganization.Id,
                    LandType = landType,
                    Square = square,
                };

                _context.Lands.Add(landForAdd);
            }
            else
            {
                var landForChange = _context.Lands.FirstOrDefault(x => x.Id == _landId);

                landForChange.Address = address;
                landForChange.CadastralNumber= cadastral;
                landForChange.BuyPrice = buyPrice;
                landForChange.SellPrice = sellPrice;
                landForChange.LandType = landType;
                landForChange.Square = square;

                _context.Lands.Update(landForChange);
            }
            _context.SaveChanges();
            MessageBox.Show(_landId == 0 ? $"Земельный участок с кадастровым номером - {cadastral} был добавлен в список." :
                $"Земельный участок с кадастровым номером - {cadastral} был добавлен в список.");
        }

        private void cb_IsSold_CheckedChanged(object sender, EventArgs e)
        {
            
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
            // справка
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
