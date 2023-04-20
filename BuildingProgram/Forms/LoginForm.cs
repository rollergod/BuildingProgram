using BuildingProgram.Context;
using BuildingProgram.Forms;

namespace BuildingProgram
{
    public partial class Login_Form : BaseForm
    {
        private AppDbContext _context;
        public Login_Form()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            string login = tB_Login.Text;
            string password = tB_Password.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Вы пропустили какое-то поле.");
                return;
            }

            var user = _context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);

            if (user == null)
            {
                MessageBox.Show("Неверные данные для входа");
                return;
            }

            //this.Hide();
            MainMenu mmForm = new MainMenu();
            mmForm.ShowDialog();
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}