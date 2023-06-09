﻿using BuildingProgram.Context;
using BuildingProgram.Models;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BuildingProgram.Forms
{
    public partial class AddNewObject : OldBaseForm
    {
        private AppDbContext _context;
        private int _objNum;
        private int _userId;
        public string imagePath;
        public AddNewObject(int userId,int objNum = 0)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _objNum = objNum;
            _userId = userId;
            imagePath = null;
        }

        private void btn_AddObject_Click(object sender, EventArgs e)
        {
            
        }

        private void AddNewObject_Load(object sender, EventArgs e)
        {
            //Занятые земельные уастки
            var buildingObjectsWithLands = _context.BuildingObjects.Where(x => x.LandId > 0 && x.ObjectNumber != _objNum).Select(x => x.LandId).ToList();

            cb_Land.DataSource = _context.Lands
                .Where(x => !buildingObjectsWithLands.Contains(x.Id))
                .Select(x => x.Address)
                .ToList();

            cb_BuildingCompany.DataSource = _context.BuildingCompanies
                .Select(x => x.Name)
                .ToList();

            if(_objNum > 0)
            {
                this.Text = "Изменение объекта";

                var buildingObject = _context.BuildingObjects
                    .Include(x => x.BuildingCompany)
                    .Include(x => x.Land)
                    .FirstOrDefault(x => x.ObjectNumber == _objNum);

                tb_ObjectNum.Texts = buildingObject.ObjectNumber.ToString();
                tb_ObjectName.Texts = buildingObject.ObjectName;
                dtp_StartFact.Value = DateTime.Parse(buildingObject.StartActual.ToString());
                dtp_StartPlan.Value = DateTime.Parse(buildingObject.StartPlanned.ToString());
                dtp_EndDate.Value =  DateTime.Parse(buildingObject.EndDate.ToString());

                cb_buildingPermit.Checked = buildingObject.IsBuildPermit;
                cb_buildingEnded.Checked = buildingObject.IsBuildingEnded;
                cb_isBuildingChecked.Checked = buildingObject.IsChecked;

                cb_buildingStatus.SelectedIndex = buildingObject.BuildingStatus;
                cb_BuildingCompany.Text = buildingObject.BuildingCompany.Name;
                cb_Land.Text = buildingObject.Land.Address;

                if(buildingObject.ImageName != null)
                {
                    pictureBox1.Image = new Bitmap(@$"D:\Projects\2023\BuildingProgram\BuildingProgram\Images\{buildingObject.ImageName}");
                }

                btn_AddObject.Text = "Изменить объект";
            }
        }

        private void btn_ChosePhoto_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            MainMenu objForm = new MainMenu();
            objForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            // Справка
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
            ReportForm repForm = new ReportForm();
            repForm.ShowDialog();
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

        private void cb_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            string landAddress = cb_Land.SelectedValue.ToString();

            var landOwner = _context.Lands.Include(x => x.Owner)
                .FirstOrDefault(x => x.Address== landAddress).Owner;

            lb_LandOrg.Text = landOwner.OrganizationName;
        }

        private void btn_AddObject_Click_1(object sender, EventArgs e)
        {
            string imageName = null;
            int objNumber;

            if (!int.TryParse(tb_ObjectNum.Texts, out objNumber))
            {
                MessageBox.Show("Номер объекта должен состоять только из цифр");
                return;
            }

            string objName = tb_ObjectName.Texts;
            if (string.IsNullOrEmpty(objName))
            {
                MessageBox.Show("Введите название объекта");
                return;
            }

            DateOnly startPlanned = DateOnly.Parse(dtp_StartPlan.Text);
            DateOnly startFact = DateOnly.Parse(dtp_StartFact.Text);
            DateOnly enddate = DateOnly.Parse(dtp_EndDate.Text);

            bool isPermit = cb_buildingPermit.Checked;
            bool isEnded = cb_buildingEnded.Checked;
            bool isChecked = cb_isBuildingChecked.Checked;

            int buildingStatus = cb_buildingStatus.SelectedIndex;
            if (buildingStatus <= 0)
            {
                MessageBox.Show("Выберите статус стройки");
                return;
            }

            var selectedBuilding = cb_Land.Text;
            if (string.IsNullOrEmpty(selectedBuilding))
            {
                MessageBox.Show("Выберите земельный участок");
                return;
            }

            var land = _context.Lands.FirstOrDefault(x => x.Address == selectedBuilding);

            var selectedBuildingCompany = cb_BuildingCompany.SelectedValue.ToString();
            if (string.IsNullOrEmpty(selectedBuildingCompany))
            {
                MessageBox.Show("Выберите строительную компаниюорганизацию");
                return;
            }
            var buildingCompany = _context.BuildingCompanies.FirstOrDefault(x => x.Name == selectedBuildingCompany);

            if (pictureBox1.Image != null)
            {
                imageName = Path.GetFileName(imagePath);
            }

            if (_objNum == 0)
            {
                var user = _context.Users.FirstOrDefault(x => x.Id == _userId);
                var isObjExist = _context.BuildingObjects.Any(x => x.ObjectNumber == objNumber);

                if (isObjExist)
                {
                    MessageBox.Show($"Объект с таким {objNumber} номером уже существует");
                    return;
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
                    BuildingCompany = buildingCompany,
                    ImageName = imageName,
                    User = user
                };

                if (string.IsNullOrEmpty(imagePath))
                {
                    MessageBox.Show("Выберите изображение");
                    return;
                }
                File.Copy(imagePath, Path.Combine(@"D:\Projects\2023\BuildingProgram\BuildingProgram\Images\", Path.GetFileName(imagePath)), true);
                _context.BuildingObjects.Add(addedBuilding);
            }
            else
            {
                var objForChange = _context.BuildingObjects.FirstOrDefault(x => x.ObjectNumber == _objNum);

                objForChange.ObjectName = objName;
                objForChange.ObjectNumber = objNumber;
                objForChange.StartPlanned = startPlanned;
                objForChange.StartActual = startFact;
                objForChange.EndDate = enddate;
                objForChange.IsBuildingEnded = isEnded;
                objForChange.IsBuildPermit = isPermit;
                objForChange.IsChecked = isChecked;
                objForChange.BuildingStatus = buildingStatus;
                objForChange.Land = land;
                objForChange.BuildingCompany = buildingCompany;

                if (pictureBox1.Image != null && imageName != null)
                {
                    objForChange.ImageName = imageName;
                    File.Copy(imagePath, Path.Combine(@"D:\Projects\2023\BuildingProgram\BuildingProgram\Images\", Path.GetFileName(imagePath)), true);
                }

                _context.BuildingObjects.Update(objForChange);
            }
            _context.SaveChanges();
            MessageBox.Show(_objNum == 0 ? $"Объект с номером {objNumber} успешно добавлен" : $"Объект с номером {objNumber} успешно изменён");
            this.Close();
        }

        private void btn_Exit1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChosePhoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
