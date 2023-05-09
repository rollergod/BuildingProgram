using BuildingProgram.Context;
using BuildingProgram.Models;

namespace BuildingProgram.Forms
{
    public partial class RegisterForm : OldBaseForm
    {
        private AppDbContext _context;
        public RegisterForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void btn_Create2_Click(object sender, EventArgs e)
        {
            string login = tB_Login.Text;
            string password = tB_FirstPassword.Text;
            string equalPassword = tB_SecondPassword.Text;

            if (password != equalPassword)
            {
                MessageBox.Show("Вы ввели разные пароли");
                return;
            }

            var isUserExist = _context.Users
                                            .FirstOrDefault(x => x.Login == login);

            if (isUserExist != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }

            var createdUser = new User { Login = login, Password = password };

            _context.Users.Add(createdUser);
            _context.SaveChanges();

            MessageBox.Show("Пользователь успешно создан");
        }
    }
}
