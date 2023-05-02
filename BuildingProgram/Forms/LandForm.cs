using BuildingProgram.Context;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingProgram.Forms
{
    public partial class LandForm : BaseForm
    {
        private AppDbContext _context;
        private int _landId;
        public LandForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
        }

        private void LandForm_Load(object sender, EventArgs e)
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
            string cadastralNum = tb_Search.Text;

            var data = _context.Lands.Select(x => new
            {
                x.Id,
                x.CadastralNumber,
                x.Square,
                x.Seller.OrganizationName,
                isSold = x.IsSold ? "Да" : "Нет"
            });

            if (string.IsNullOrEmpty(cadastralNum))
                dataGridView1.DataSource = data.ToList();

            var lands = data
                .Where(x => x.CadastralNumber.Contains(cadastralNum))
                .ToList();

            dataGridView1.DataSource = lands;
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
