using BuildingProgram.Context;
using BuildingProgram.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingProgram.Forms
{
    public partial class RegisterForm : BaseForm
    {
        private AppDbContext _context;
        public RegisterForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string login = tB_Login.Text;
            string password = tb_FirstPassword.Text;
            string equalPassword = tB_SecondPassword.Text;

            if(password != equalPassword)
            {
                MessageBox.Show("Вы ввели разные пароли");
                return;
            }

            var isUserExist = _context.Users
                                            .FirstOrDefault(x => x.Login == login);

            if(isUserExist != null) 
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
