using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Business;
using Data.Model;
using Data;

namespace Registration
{
    public partial class Registration : Form
    {
        public string currentLanguage;
        public Client client;
        public Context context = new Context();
        public ClientBusiness business = new ClientBusiness();

        public Registration(string language)
        {
            InitializeComponent();
            currentLanguage = language;
        }
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            OnLoad();
        }
        public void OnLoad()
        {
            ChangeLanguage();
            lblfName.Visible = txtFName.Visible = lblLName.Visible = txtLName.Visible = lblPhone.Visible = txtPhone.Visible = lblRepeatPassword.Visible = txtRepeatPassword.Visible = true;
            DisplayInformation();
            txtPassword.PasswordChar = '*';
            txtRepeatPassword.PasswordChar = '*';
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (btnLog.Text == "Вход" || btnLog.Text == "Log in")//------------For log in-------------
            {
                bool clientExists = false;
                if (!(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text)))
                {
                    foreach (Client item in business.GetAllClients())
                    {
                        if (item.email == txtEmail.Text && item.password == txtPassword.Text)
                        {
                            clientExists = true;
                            client = item;
                            break;
                        }
                        else
                        {
                            clientExists = false;
                        }
                    }
                    if (!clientExists)
                    {
                        if (currentLanguage == "Bulgarian")
                        {
                            MessageBox.Show("Няма такъв съществуващ потребител!");
                        }
                        else
                        {
                            MessageBox.Show("There is no such user!");
                        }
                    }//Ако клиентът не е намерен в базата данни
                }
                else
                {
                    if (currentLanguage == "Bulgarian")
                    {
                        MessageBox.Show("Моля попълнете всички полета.");
                    }
                    else
                    {
                        MessageBox.Show("Please fill all fields.");
                    }
                }//Ако някое от полетата е празно
                if (client != null)
                {
                    if (currentLanguage == "Bulgarian")
                    {
                        MessageBox.Show($"Добре дошли {client.firstName} {client.lastName}");
                    }
                    else
                    {
                        MessageBox.Show($"Welcome back {client.firstName} {client.lastName}");
                    }
                    DisplayInformation();
                }//При успешно логнат клиент
            }

            else//------------For registration--------------
            {
                if (!(string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrEmpty(txtEmail.Text) || 
                    string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtRepeatPassword.Text)))
                {
                    if (!string.IsNullOrEmpty(txtPassword.Text) && txtPassword.Text == txtRepeatPassword.Text)
                    {
                        if (txtEmail.Text.Contains('@') && CheckForDigits(txtPhone.Text))
                        {
                            client = new Client();
                            client.firstName = txtFName.Text;
                            client.lastName = txtLName.Text;
                            client.email = txtEmail.Text;
                            client.phone = txtPhone.Text;
                            client.password = txtPassword.Text;
                            client.admin = "false";
                            business.AddClient(client);
                            DisplayInformation();
                            if (currentLanguage == "Bulgarian")
                            {
                                MessageBox.Show("Създадохте нов акаунт.Вече можете да използвате другите услуги в първоначалната страница!");
                            }
                            else
                            {
                                MessageBox.Show("You have created a new account.You can now use the other services from the starting page!");
                            }
                        }
                        else if (!txtEmail.Text.Contains('@'))
                        {
                            if (currentLanguage == "Bulgarian")
                            {
                                MessageBox.Show("Имейлът трябва да съдържа '@'");
                            }
                            else
                            {
                                MessageBox.Show("The email must contain @");
                            }
                        }//Ако имейлът не съдържа '@'
                        else
                        {
                            if (currentLanguage == "Bulgarian")
                            {
                                MessageBox.Show("Телефонният номер не е правилен");
                            }
                            else
                            {
                                MessageBox.Show("The phone number isn't correct");
                            }
                        }//Ако телефонният номер не е в правилен формат
                    }
                    else
                    {
                        if (currentLanguage == "Bulgarian")
                        {
                            MessageBox.Show("Паролите не съвпадат.Моля опитайте отново.");
                        }
                        else
                        {
                            MessageBox.Show("The passwords do not match.Please try again.");
                        }
                    }//Ако паролите не съвпадат една с друга
                }
                else
                {
                    if (currentLanguage == "Bulgarian")
                    {
                        MessageBox.Show("Моля попълнете всички полета.");
                    }
                    else
                    {
                        MessageBox.Show("Please fill all fields.");
                    }
                }//Ако някое от полетата е празно
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            switch (currentLanguage)
            {
                case "Bulgarian":
                    if (btnLog.Text == "Вход")
                    {
                        lblfName.Visible = txtFName.Visible = lblLName.Visible = txtLName.Visible = lblPhone.Visible = txtPhone.Visible = lblRepeatPassword.Visible = txtRepeatPassword.Visible = true;
                        btnLog.Text = "Регистрация";
                        lblChange.Text = "Назад";
                    }
                    else
                    {
                        lblfName.Visible = txtFName.Visible = lblLName.Visible = txtLName.Visible = lblPhone.Visible = txtPhone.Visible = lblRepeatPassword.Visible = txtRepeatPassword.Visible = false;
                        btnLog.Text = "Вход";
                        lblChange.Text = "Ако не сте се регистрирали кликнете тук.";
                    }
                    break;

                case "English":
                    if (btnLog.Text == "Log in")
                    {
                        lblfName.Visible = txtFName.Visible = lblLName.Visible = txtLName.Visible = lblPhone.Visible = txtPhone.Visible = lblRepeatPassword.Visible = txtRepeatPassword.Visible = true;
                        btnLog.Text = "Register";
                        lblChange.Text = "Back";
                    }
                    else
                    {
                        lblfName.Visible = txtFName.Visible = lblLName.Visible = txtLName.Visible = lblPhone.Visible = txtPhone.Visible = lblRepeatPassword.Visible = txtRepeatPassword.Visible = false;
                        btnLog.Text = "Log in";
                        lblChange.Text = "If you haven't registrated yet, click here.";
                    }
                    break;
            }
        }

        private void DisplayInformation()
        {
            if (client != null)
            {
                lblfName.Visible = txtFName.Visible = lblLName.Visible = txtLName.Visible = lblPhone.Visible = txtPhone.Visible = lblRepeatPassword.Visible = txtRepeatPassword.Visible = true;

                txtFName.Text = client.firstName;
                txtLName.Text = client.lastName;
                txtEmail.Text = client.email;
                txtPhone.Text = client.phone;
                txtPassword.Text = client.password;
                txtRepeatPassword.Visible = lblRepeatPassword.Visible = false;

                txtFName.Enabled = false;
                txtLName.Enabled = false;
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;
                txtPassword.Enabled = false;

                lblChange.Visible = false;
                btnLog.Visible = false;
                btnLeave.Visible = true;
            }
            else
            {
                lblfName.Visible = txtFName.Visible = lblLName.Visible = txtLName.Visible = lblPhone.Visible = txtPhone.Visible = lblRepeatPassword.Visible = txtRepeatPassword.Visible = false;

                txtFName.Text = "";
                txtLName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtPassword.Text = "";

                txtFName.Enabled = true;
                txtLName.Enabled = true;
                txtEmail.Enabled = true;
                txtPhone.Enabled = true;
                txtPassword.Enabled = true;

                lblChange.Visible = true;
                btnLog.Visible = true;
                btnLeave.Visible = false;
            }
        }
        private void ChangeLanguage()
        {
            switch (currentLanguage)
            {
                case "Bulgarian":
                    lblfName.Text = "Име:";
                    lblLName.Text = "Фамилия:";
                    lblEmail.Text = "Имейл:";
                    lblPhone.Text = "Тел.номер:";
                    lblPassword.Text = "Парола:";
                    lblRepeatPassword.Text = "Повтори парола:";
                    lblChange.Text = "Ако не сте се регистрирали кликнете тук.";
                    btnLog.Text = "Вход";
                    btnLeave.Text = "Излез";
                    break;

                case "English":
                    lblfName.Text = "First name:";
                    lblLName.Text = "Last name:";
                    lblEmail.Text = "Email:";
                    lblPhone.Text = "Phone number:";
                    lblPassword.Text = "Password:";
                    lblRepeatPassword.Text = "Repeat password:";
                    lblChange.Text = "If you haven't registrated yet, click here.";
                    btnLog.Text = "Log in";
                    btnLeave.Text = "Leave";
                    break;
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            client = null;
            DisplayInformation();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Registration.ActiveForm.Dispose();
        }

        private bool CheckForDigits(string a)
        {
            if (a.Length == 10)
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if ((int)a[i] > 47 && (int)a[i] < 58)
                    {
                        count++;
                        if (count == 10)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else return false;
        }
    }
}
