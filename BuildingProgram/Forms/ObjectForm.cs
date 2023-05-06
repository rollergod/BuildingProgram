using BuildingProgram.Context;
using BuildingProgram.Models.Enum;
using BuildingProgram.Tools;
using Microsoft.EntityFrameworkCore;

namespace BuildingProgram.Forms
{
    public partial class ObjectForm : BaseForm
    {
        private int _objNum;
        private int _noteId;
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

            var notes = _context.Notes.ToList();

            dataGridView1.DataSource = notes;

            dataGridView1.Columns[0].HeaderText = "Номер заметки";
            dataGridView1.Columns[1].HeaderText = "Важность";
            dataGridView1.Columns[2].HeaderText = "Текст заметки";
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddNote_Click(object sender, EventArgs e)
        {
            AddNoteForm addNoteForm = new AddNoteForm(_objNum);
            addNoteForm.ShowDialog();
        }

        private void btn_ChangeNote_Click(object sender, EventArgs e)
        {
            AddNoteForm addNoteForm = new AddNoteForm(_objNum,_noteId);
            addNoteForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _noteId  = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            if(_noteId > 0)
            {
                btn_ChangeNote.Enabled = true;
                btn_DeleteNote.Enabled = true;
            }
        }

        private void btn_DeleteNote_Click(object sender, EventArgs e)
        {
            var noteForDelete = _context.Notes.FirstOrDefault(x => x.Id == _noteId);

            var confirmResult = MessageBox.Show("Вы действительно хотите удалить записку?","Подтвердите удаление",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _context.Notes.Remove(noteForDelete);
                _context.SaveChanges();
                MessageBox.Show("Записка удалена");

                var notes = _context.Notes.ToList();

                dataGridView1.DataSource = notes;
            }
        }
    }
}
