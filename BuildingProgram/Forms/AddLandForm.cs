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
    public partial class AddLandForm : BaseForm
    {
        private AppDbContext _context; 
        public AddLandForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
        }

        private void AddLandForm_Load(object sender, EventArgs e)
        {
            cb_sellerId.DataSource = _context.Organizations.Select(x => x.OrganizationName).ToList();
        }

        private void btn_AddLand_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_sellerId.SelectedValue.ToString());
            // TODO : добавить логику выбора объекта и получения его из бд COMBOBOX
        }
    }
}
