using BuildingProgram.Context;
using BuildingProgram.Models;
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
    public partial class AddNewObject : BaseForm
    {
        private AppDbContext _context;
        public AddNewObject()
        {
            InitializeComponent();
            _context = new AppDbContext();
            menuStrip1.Renderer = new NoHighlightRenderer();
        }

        private void btn_AddObject_Click(object sender, EventArgs e)
        {
            int objNumber = Convert.ToInt32(tb_ObjectNum.Texts);
            string objName = tb_ObjectName.Texts;

            DateOnly startPlanned = DateOnly.Parse(dtp_StartPlan.Text);
            DateOnly startFact = DateOnly.Parse(dtp_StartFact.Text);
            DateOnly enddate = DateOnly.Parse(dtp_EndDate.Text);

            bool isPermit = cb_buildingPermit.Checked;
            bool isEnded = cb_buildingEnded.Checked;
            bool isChecked = cb_isBuildingChecked.Checked;

            int buildingStatus = cb_buildingStatus.SelectedIndex;
            int landId = 0;

            var addedBuilding = new BuildingObject
            {
                ObjectName = objName,
                ObjectNumber = objNumber,
                StartPlanned = startPlanned,
                StartActual = startFact,
                EndDate = enddate,
                IsBuildingEnded = isEnded,
                IsBuildPermit = isPermit, 
                BuildingStatus = buildingStatus,
                IsChecked = isChecked,
                LandId = landId
            };

            try
            {
                _context.BuildingObjects.Add(addedBuilding);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла какая-то ошибка.");
            }

            MessageBox.Show($"Объект с номером {objNumber} успешно добавлен ");
        }

        private void AddNewObject_Load(object sender, EventArgs e)
        {
            cb_objectId.DataSource = _context.Lands
                .Where(x => !x.IsSold)
                .Select(x =>
                    new  { 
                        x.Id, x.Address 
                    })
                .ToList();
        }
    }
}
