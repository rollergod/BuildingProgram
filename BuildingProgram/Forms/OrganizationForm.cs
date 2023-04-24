using BuildingProgram.Context;
using BuildingProgram.Tools;
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
    public partial class OrganizationForm : BaseForm
    {
        private AppDbContext _context;
        public OrganizationForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
        }

        private void OrganizationForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Organizations.ToList();

            dataGridView1.Columns[0].HeaderText = "Номер организации";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Директор";

            dataGridView1.Columns[1].Width = 375;
        }
    }
}
