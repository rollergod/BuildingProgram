
using Test;

namespace BuildingProgram.Forms
{
    public partial class OldBaseForm : BaseForm
    {
        public OldBaseForm()
        {
            InitializeComponent();
        }

        //private void BaseForm_MouseDown(object sender, MouseEventArgs e)
        //{
        //    base.Capture = false;
        //    Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
        //    this.WndProc(ref m);
        //}
    }
}
