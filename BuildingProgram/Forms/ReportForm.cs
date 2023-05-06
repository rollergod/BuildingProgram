
using BuildingProgram.Context;
using BuildingProgram.Models;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;

namespace BuildingProgram.Forms
{
    public partial class ReportForm : BaseForm
    {
        private AppDbContext _context;
        int cbType;
        public ReportForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
            menuStrip1.Renderer = new NoHighlightRenderer();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            var lands = _context.Lands.Include(x => x.Seller).ToList();

            var data = lands.Select(x => new
            {
                x.Id,
                x.CadastralNumber,
                x.Square,
                x.Seller.OrganizationName,
                isSold = x.IsSold ? "Да" : "Нет"
            }).ToList();

            dataGridView1.DataSource = data;

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Кадастровый номер";
            dataGridView1.Columns[2].HeaderText = "Площадь(М^2)";
            dataGridView1.Columns[3].HeaderText = "Продавец";
            dataGridView1.Columns[4].HeaderText = "Продан";

            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 150;
        }

        private void cb_LandType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbType = cb_LandType.SelectedIndex;

            var data = (IQueryable<Land>)_context.Lands
                .Include(x => x.Seller)
                .Include(X => X.Buyer);

            switch (cbType)
            {
                case 0:
                case 1:
                case 2:
                    data = data.Where(x => x.LandType == cbType);
                    dataGridView1.DataSource = data.
                        Select(x => new
                        {
                            x.Id,
                            x.CadastralNumber,
                            x.Square,
                            x.Seller.OrganizationName,
                            isSold = x.IsSold ? "Да" : "Нет",
                        }).ToList();
                    break;
                case 3:
                    data = data.Where(x => x.IsSold);
                    dataGridView1.DataSource = data.
                    Select(x => new
                    {
                        x.Id,
                        x.CadastralNumber,
                        x.Square,
                        x.Seller.OrganizationName,
                        isSold = x.IsSold ? "Да" : "Нет",
                        BuyerName = x.IsSold ? x.Buyer.OrganizationName : ""
                    }).ToList();
                    dataGridView1.Columns[5].HeaderText = "Покупатель";
                    dataGridView1.Columns[5].Width = 200;
                    break;
                case 4:
                    data = data.Where(x => !x.IsSold);
                    dataGridView1.DataSource = data.
                   Select(x => new
                   {
                       x.Id,
                       x.CadastralNumber,
                       x.Square,
                       x.Seller.OrganizationName,
                       isSold = x.IsSold ? "Да" : "Нет",
                       BuyerName = x.IsSold ? x.Buyer.OrganizationName : ""
                   }).ToList();
                    break;
            }

          
        }
    }
}
