using BuildingProgram.Context;
using BuildingProgram.Models;
using BuildingProgram.Models.Enum;
using BuildingProgram.Tools;

namespace BuildingProgram.Forms
{
    public partial class AddNoteForm : OldBaseForm
    {
        private readonly AppDbContext _context;
        private int _objNum;
        private int _noteId;
        public AddNoteForm(int objNum,int noteId = 0)
        {
            InitializeComponent();
            _context = new AppDbContext();
            menuStrip1.Renderer = new NoHighlightRenderer();
            _objNum = objNum;
            _noteId = noteId;
        }
       
        private void btn_Add_Click(object sender, EventArgs e)
        {
            Priority type = (Priority)cb_ProrityType.SelectedIndex;
            string text = rtb_Text.Text;

            if(_noteId == 0)
            {
                var buildingObject = _context.BuildingObjects.FirstOrDefault(x => x.ObjectNumber == _objNum);

                var noteForAdd = new Note { Priority = type, Text = text, BuildingObjectId = buildingObject.Id };
                _context.Add(noteForAdd);
            }
            else
            {
                var noteForChange = _context.Notes.FirstOrDefault(x => x.Id == _noteId);

                noteForChange.Priority = type;
                noteForChange.Text = text;

                _context.Notes.Update(noteForChange);
            }
            
            _context.SaveChanges();
            MessageBox.Show(_noteId > 0 ? "Записка успешно изменена" : "Добавлена новая записка");
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNoteForm_Load(object sender, EventArgs e)
        {
            label3.Text = $"Добавление заметки для учатска №{_objNum}";
            if (_noteId > 0)
            {
                label3.Text = $"Изменение заметки для учатска №{_objNum}";

                var note = _context.Notes.FirstOrDefault(x => x.Id == _noteId);

                rtb_Text.Text = note.Text;
                cb_ProrityType.SelectedIndex = Convert.ToInt32(note.Priority);

                btn_Add.Text = "Изменить";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainMenu objForm = new MainMenu();
            objForm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrganizationForm orgForm = new OrganizationForm();
            orgForm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // справка
        }

        private void земельныеУчасткиToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
