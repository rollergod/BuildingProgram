using BuildingProgram.Forms;

namespace BuildingProgram
{
    public partial class Login_Form : BaseForm
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}