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
    public partial class MainMenu : BaseForm
    {
        private AppDbContext _context;
        public MainMenu()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();

            _context = new AppDbContext();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.BuildingObjects.ToList();
        }
    }
}
