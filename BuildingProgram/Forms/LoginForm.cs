using BuildingProgram.Forms;

namespace BuildingProgram
{
    public partial class Login_Form : BaseForm
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            //MainMenu mmForm = new MainMenu();
            //mmForm.ShowDialog();

            //ObjectForm mm2Form = new ObjectForm();
            //mm2Form.ShowDialog();

            AddNewObject add = new AddNewObject();
            add.ShowDialog();
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}