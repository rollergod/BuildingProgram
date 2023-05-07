using BuildingProgram.Context;
using BuildingProgram.Models;
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
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                lb_ObjectsNum.Visible = true;
                lb_OrgName.Visible = true;
                lb_TotalSum.Visible = true;

                btn_ChangeOrg.Enabled = true;

                var data = _context.Lands.Include(x => x.Owner).Where(x => x.Owner.Id == _orgId);

                var landIds = data.Select(x => x.Id);
                var buildingObjects = _context.BuildingObjects
                    .Include(x => x.Land)
                    .Where(x => landIds.Contains(x.LandId)).ToList();
               
                var buildingsCount = data.Count();

                var totalSum = buildingObjects
                    .Sum(x => x.Land.BuyPrice);

                var today = DateOnly.FromDateTime(DateTime.Today);
                var latestObject = buildingObjects
                    .Where(x => x.IsBuildingEnded)
                    .OrderByDescending(x => x.EndDate)
                    .FirstOrDefault();

                lb_ObjectsNum.Text = buildingsCount.ToString();
                lb_TotalSum.Text = totalSum.ToString();
                lb_OrgName.Text = latestObject.EndDate.ToString();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchText = tb_Search.Text;

            if (string.IsNullOrEmpty(searchText))
                dataGridView1.DataSource = _context.Organizations.ToList();

            var searchedObjects = SearchData(searchText);

            dataGridView1.DataSource = searchedObjects;
        }

        private List<Organization> SearchData(string searchText)
        {
            return _context.Organizations
                .Where(x => x.OrganizationName.Contains(searchText) || x.DirectorName.Contains(searchText))
                .ToList();
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            MainMenu objForm = new MainMenu();
            objForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            //справка
        }

        private void земельныеУчасткиToolStripMenuItem_Click_1(object sender, EventArgs e)
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
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
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
