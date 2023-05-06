using BuildingProgram.Context;
using BuildingProgram.Models;
using BuildingProgram.Models.Enum;
using BuildingProgram.Tools;

namespace BuildingProgram.Forms
{
    public partial class AddNoteForm : BaseForm
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
            if(_noteId > 0)
            {
                label3.Text = $"Изменение заметки для учатска №{_objNum}";

                var note = _context.Notes.FirstOrDefault(x => x.Id == _noteId);

                rtb_Text.Text = note.Text;
                cb_ProrityType.SelectedIndex = Convert.ToInt32(note.Priority);

                btn_Add.Text = "Изменить";
            }
            label3.Text = $"Добавление заметки для учатска №{_objNum}";
        }
    }
}
