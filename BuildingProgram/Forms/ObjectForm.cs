using BuildingProgram.Context;
using BuildingProgram.Models.Enum;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;
using Test;

namespace BuildingProgram.Forms
{
    public partial class ObjectForm : BaseForm
    {
        private int _objNum;
        private int _noteId;
        private int _userId;
        private AppDbContext _context;
        bool siderbarExpand = false;
        bool reportCollapse = true;
        public ObjectForm(int objNum = 0,int userId = 0)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _objNum = objNum;
            _userId = userId;
        }

        private void ObjectForm_Load(object sender, EventArgs e)
        {
            var buildingObject = _context.BuildingObjects
                .Include(x => x. Land)
                .Include(x => x.BuildingCompany)
                .FirstOrDefault(x => x.ObjectNumber == _objNum);

            lb_Address.Text = buildingObject.Land.Address;
            lb_objectNum.Text = buildingObject.ObjectNumber.ToString();
            lb_IsBuildingPermit.Text = buildingObject.IsBuildPermit == true ? "Да" : "Нет";
            lb_DateStartFact.Text = buildingObject.StartActual.ToString();
            lb_DateStartPlan.Text = buildingObject.StartPlanned.ToString();
            lb_EndDate.Text = buildingObject.EndDate.ToString();
            lb_BuildingCompany.Text = buildingObject.BuildingCompany.Name;

            BuildingStatus buildingStatus = (BuildingStatus)buildingObject.BuildingStatus;
            lb_BuildingStatus.Text = buildingStatus.ToString();

            if (buildingObject.ImageName != null)
            {
                pictureBox1.Image = new Bitmap(@$"D:\Projects\2023\BuildingProgram\BuildingProgram\Images\{buildingObject.ImageName}");
            }

            var notes = _context.Notes.ToList();

            dataGridView1.DataSource = notes;

            dataGridView1.Columns[0].HeaderText = "Номер заметки";
            dataGridView1.Columns[1].HeaderText = "Важность";
            dataGridView1.Columns[2].HeaderText = "Текст заметки";

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 500;
        }
    
        private void btn_AddNote_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_ChangeNote_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_DeleteNote_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            _noteId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            if (_noteId > 0)
            {
                btn_ChangeNote.Enabled = true;
                btn_DeleteNote.Enabled = true;
            }
        }

        private void btn_ObjectForm_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }

        private void btn_OrgForm_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
        }

        private void btn_LandForm_Click(object sender, EventArgs e)
        {
            LandForm landForm = new LandForm();
            landForm.ShowDialog();
        }

        private void btn_BuildingCompanyForm_Click(object sender, EventArgs e)
        {
            BuildingCompanyForm buildingCompanyForm = new BuildingCompanyForm();
            buildingCompanyForm.ShowDialog();
        }

        private void btn_RepForm_Click(object sender, EventArgs e)
        {
            ReportForm repForm = new ReportForm();
            repForm.ShowDialog();
        }

        private void btn_BuildingCompanyRep_Click(object sender, EventArgs e)
        {
            BuildingCompanyReportForm buildingCompanyReportForm = new BuildingCompanyReportForm();
            buildingCompanyReportForm.ShowDialog();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (siderbarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width == sideBar.MinimumSize.Width)
                {
                    siderbarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width)
                {
                    siderbarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void reportTimer_Tick(object sender, EventArgs e)
        {
            if (reportCollapse)
            {
                reportContainer.Height += 10;
                if (reportContainer.Height == reportContainer.MaximumSize.Height)
                {
                    reportCollapse = false;
                    reportTimer.Stop();
                }
            }
            else
            {
                reportContainer.Height -= 10;
                if (reportContainer.Height == reportContainer.MinimumSize.Height)
                {
                    reportCollapse = true;
                    reportTimer.Stop();
                }
            }
        }

        private void menuPicture_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_ReportForm_Click(object sender, EventArgs e)
        {
            reportTimer.Start();
        }

        private void btn_AddNote_Click_1(object sender, EventArgs e)
        {
            var currentObject = _context.BuildingObjects.FirstOrDefault(x => x.ObjectNumber == _objNum);

            if (currentObject.UserId == _userId)
            {
                AddNoteForm addNoteForm = new AddNoteForm(_objNum);
                addNoteForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас нет прав для добавления заметок к этому объекту.");
            }
        }

        private void btn_DeleteNote_Click_1(object sender, EventArgs e)
        {
            var currentObject = _context.BuildingObjects.FirstOrDefault(x => x.ObjectNumber == _objNum);

            if (currentObject.UserId == _userId)
            {
                var noteForDelete = _context.Notes.FirstOrDefault(x => x.Id == _noteId);

                var confirmResult = MessageBox.Show("Вы действительно хотите удалить записку?", "Подтвердите удаление", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _context.Notes.Remove(noteForDelete);
                    _context.SaveChanges();
                    MessageBox.Show("Записка удалена");

                    var notes = _context.Notes.ToList();

                    dataGridView1.DataSource = notes;
                }
            }
            else
            {
                MessageBox.Show("У вас нет прав для удаления заметок у этого объекта.");
            }
        }

        private void btn_ChangeNote_Click_1(object sender, EventArgs e)
        {
            var currentObject = _context.BuildingObjects.FirstOrDefault(x => x.ObjectNumber == _objNum);

            if (currentObject.UserId == _userId)
            {
                AddNoteForm addNoteForm = new AddNoteForm(_objNum, _noteId);
                addNoteForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("У вас нет прав для изменения заметки у этого объекта.");
            }
        }
    }
}
