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
    public partial class AddNewObject : BaseForm
    {
        private AppDbContext _context;
        private int _objectId;
        public string imagePath;
        public AddNewObject(int objectId = 0)
        {
            InitializeComponent();
            _context = new AppDbContext();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _objectId = objectId;
            imagePath = null;
        }

        private void btn_AddObject_Click(object sender, EventArgs e)
        {
            string imageName = null;
            int objNumber = Convert.ToInt32(tb_ObjectNum.Texts);
            string objName = tb_ObjectName.Texts;

            DateOnly startPlanned = DateOnly.Parse(dtp_StartPlan.Text);
            DateOnly startFact = DateOnly.Parse(dtp_StartFact.Text);
            DateOnly enddate = DateOnly.Parse(dtp_EndDate.Text);

            bool isPermit = cb_buildingPermit.Checked;
            bool isEnded = cb_buildingEnded.Checked;
            bool isChecked = cb_isBuildingChecked.Checked;

            int buildingStatus = cb_buildingStatus.SelectedIndex;

            var selectedBuilding = cb_Land.SelectedValue.ToString();
            if(selectedBuilding == null)
            {
                MessageBox.Show("Выберите земельный участок");
                return;
            }
            var land = _context.Lands.FirstOrDefault(x => x.Address == selectedBuilding);

            var selectedOrganization = cb_Organization.SelectedValue.ToString();
            if (selectedOrganization == null)
            {
                MessageBox.Show("Выберите задействованную организацию");
                return;
            }
            var organization = _context.Organizations.FirstOrDefault(x => x.OrganizationName == selectedOrganization);

            if(pictureBox1.Image != null)
            {
               imageName = Path.GetFileName(imagePath);
            }

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
                Land = land,
                Organization= organization,
                ImageName = imageName
            };

            try
            {
                File.Copy(imagePath, Path.Combine(@"D:\Projects\2023\BuildingProgram\BuildingProgram\Images\", Path.GetFileName(imagePath)), true);
                _context.BuildingObjects.Add(addedBuilding);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла какая-то ошибка.");
                return;
            }

            MessageBox.Show($"Объект с номером {objNumber} успешно добавлен ");
        }

        private void AddNewObject_Load(object sender, EventArgs e)
        {
            //Занятые земельные уастки
            var buildingObjectsWithLands = _context.BuildingObjects.Where(x => x.LandId > 0).Select(x => x.LandId).ToList();

            cb_Land.DataSource = _context.Lands
                .Where(x => !x.IsSold && !buildingObjectsWithLands.Contains(x.Id))
                .Select(x => x.Address)
                .ToList();

            cb_Organization.DataSource = _context.Organizations
                .Select(x => x.OrganizationName)
                .ToList();

            if(_objectId > 0)
            {
                this.Text = "Изменение объекта";

                var buildingObject = _context.BuildingObjects.FirstOrDefault(x => x.ObjectNumber == _objectId);

                tb_ObjectNum.Texts = buildingObject.ObjectNumber.ToString();
                tb_ObjectName.Texts = buildingObject.ObjectName;
                dtp_StartFact.Value = DateTime.Parse(buildingObject.StartActual.ToString());
                dtp_StartPlan.Value = DateTime.Parse(buildingObject.StartPlanned.ToString());
                dtp_EndDate.Value =  DateTime.Parse(buildingObject.EndDate.ToString());

                cb_buildingPermit.Checked = buildingObject.IsBuildPermit;
                cb_buildingEnded.Checked = buildingObject.IsBuildingEnded;
                cb_isBuildingChecked.Checked = buildingObject.IsChecked;

                cb_buildingStatus.SelectedIndex = buildingObject.BuildingStatus;

                if(buildingObject.ImageName != null)
                {
                    pictureBox1.Image = new Bitmap(@$"D:\Projects\2023\BuildingProgram\BuildingProgram\Images\{buildingObject.ImageName}");
                }

                btn_AddObject.Text = "Изменить объект";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ObjectForm objForm = new ObjectForm();
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
        }

        private void btn_ChosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
