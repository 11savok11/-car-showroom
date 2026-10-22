using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text.Trim();
            string password = tbPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
            if (password != tbPassReload.Text)
            {
                MessageBox.Show("Пароли не совпадают. Пожалуйста, попробуйте снова.");
                return;
            }

            if (!IsValidPassword(password))
            {
                MessageBox.Show("Пароль содержит недопустимые символы. Используйте только буквы и цифры.");
                return;
            }

            DataRow[] duplicateUsers = БДДАТАСЕТ.Аккаунты.Select($"Username = '{username.Replace("'", "''")}'");
            if (duplicateUsers.Length > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует! Придумайте другой.");
                return;
            }

            try
            {
                DataRow nRow = БДДАТАСЕТ.Аккаунты.NewRow();

                nRow["Username"] = username;
                nRow["PasswordText"] = password;

                БДДАТАСЕТ.Аккаунты.Rows.Add(nRow);
                бдTableAdapter.Update(БДДАТАСЕТ.Аккаунты);

                MessageBox.Show("Регистрация Успешна!");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при сохранении в базу данных");
            }
        }
    }
}
