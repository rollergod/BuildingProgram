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
        private int _orgId;
        public OrganizationForm(int orgId = 0)
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
            _orgId = orgId;
        }

        private void OrganizationForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Organizations.ToList();

            dataGridView1.Columns[0].HeaderText = "Номер организации";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Директор";

            dataGridView1.Columns[1].Width = 375;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _orgId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            if(_orgId > 0)
            {
                btn_ChangeOrg.Enabled = true;
            }
        }

        private void btn_AddOrg_Click(object sender, EventArgs e)
        {
            AddOrgForm addOrgForm = new AddOrgForm();
            addOrgForm.ShowDialog();
        }

        private void btn_ChangeOrg_Click(object sender, EventArgs e)
        {
            AddOrgForm changeOrgForm = new AddOrgForm(_orgId);
            changeOrgForm.ShowDialog();
        }
    }
}
