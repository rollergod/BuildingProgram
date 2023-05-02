using BuildingProgram.Context;
using BuildingProgram.Models.Enum;
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
    public partial class ObjectForm : BaseForm
    {
        private int _objNum;
        private AppDbContext _context;
        public ObjectForm(int objNum = 0)
        {
            InitializeComponent();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _context = new AppDbContext();
            _objNum = objNum;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ObjectForm objForm = new ObjectForm();
            objForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //справка
        }

        private void земельныеУчасткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandForm landForm = new LandForm();
            landForm.ShowDialog();  
        }

        private void ObjectForm_Load(object sender, EventArgs e)
        {
            var buildingObject = _context.BuildingObjects.Include(x => x. Land).FirstOrDefault(x => x.ObjectNumber == _objNum);

            lb_Address.Text = buildingObject.Land.Address;
            lb_objectNum.Text = buildingObject.ObjectNumber.ToString();
            lb_IsBuildingPermit.Text = buildingObject.IsBuildPermit == true ? "Да" : "Нет";
            lb_DateStartFact.Text = buildingObject.StartActual.ToString();
            lb_DateStartPlan.Text = buildingObject.StartPlanned.ToString();
            lb_EndDate.Text = buildingObject.EndDate.ToString();

            BuildingStatus buildingStatus = (BuildingStatus)buildingObject.BuildingStatus;
            lb_BuildingStatus.Text = buildingStatus.ToString();

            if (buildingObject.ImageName != null)
            {
                pictureBox1.Image = new Bitmap(@$"D:\Projects\2023\BuildingProgram\BuildingProgram\Images\{buildingObject.ImageName}");
            }

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
