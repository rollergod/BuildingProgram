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
                x.CadastralNumber,
                x.Square,
                x.Seller.OrganizationName,
                isSold = x.IsSold ? "Да" : "Нет"
            }).ToList();

            dataGridView1.DataSource = data;

            dataGridView1.Columns[0].HeaderText = "Кадастровый номер";
            dataGridView1.Columns[1].HeaderText = "Площадь(М^2)";
            dataGridView1.Columns[2].HeaderText = "Продавец";
            dataGridView1.Columns[3].HeaderText = "Продан";

            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;
        }

        private void btn_AddOrganization_Click(object sender, EventArgs e)
        {
            AddLandForm addLandForm = new AddLandForm();
            addLandForm.ShowDialog();   
        }
    }
}
