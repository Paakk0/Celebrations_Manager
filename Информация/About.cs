using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Data;
using Business;
using Message = Data.Model.Message;

namespace Информация
{
    public partial class About : Form
    {
        public string currentLanguage;
        public bool Info = true;//true = About us / false = Contacts
        public MessageBusiness messageBusiness = new MessageBusiness();
        public About(string language)
        {
            InitializeComponent();
            currentLanguage = language;
        }
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            ChangeLanguage();
            DisplayInformation();
        }

        public void DisplayInformation()
        {
            if (Info)
            {
                this.Size = new Size(570, 450);
                btnExit.Location = new Point(467, 376);
            }
            else
            {
                this.Size = new Size(570, 650);
                btnExit.Location = new Point(467, 576);
                lblInfo.TextAlign = ContentAlignment.TopLeft;
                switch (currentLanguage)
                {
                    case "Bulgarian":
                        lblAboutUsTxt.Text = "Контакти";
                        lblInfo.Text = "Имейл:SweetMoments@gmail.com\n\nТел.номер:088 645 8391\n\nГрад:София\n\nКвартал:Младост\n\nУлица:'Филип Аврамов'";
                        break;

                    case "English":
                        lblAboutUsTxt.Text = "Contacts";
                        lblInfo.Text = "Email:SweetMoments@gmail.com\n\nPhone number:088 645 8391\n\nCity:Sofia\n\nNeighbourhood:Mladost\n\nStreet:'Филип Аврамов'";
                        break;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMessage.Text)))
            {
                if (txtEmail.Text.Contains('@'))
                {
                    var message = new Message
                    {
                        name = txtName.Text,
                        email = txtEmail.Text,
                        message = txtMessage.Text
                    };
                    messageBusiness.AddMessage(message);
                }
                else
                {
                    switch (currentLanguage)
                    {
                        case "Bulgarian":
                            MessageBox.Show("Имейлът трябва да съдържа '@'!");
                            break;

                        case "English":
                            MessageBox.Show("The email must contain '@'!");
                            break;
                    }
                }
            }
            else
            {
                switch (currentLanguage)
                {
                    case "Bulgarian":
                        MessageBox.Show("Всички полета трябва да са попълнени!");
                        break;

                    case "English":
                        MessageBox.Show("All fields must be filled!");
                        break;
                }
            }
            txtName.Text = txtEmail.Text = txtMessage.Text = string.Empty;
        }

        public void ChangeLanguage()
        {
            switch (currentLanguage)
            {
                case "Bulgarian":
                    lblInfo.Text = "„SweetMoments” е приложение създадено през 2018 година, то предлага организиране на различни празненства и услуги." +
                        "Неговата цел е да улесни онлайн клентите с организирането на техните желани празненства.";
                    lblAboutUsTxt.Text = "За нас";
                    lblName.Text = "Име:";
                    lblEmail.Text = "Имейл:";
                    lblMessage.Text = "Съобщение:";
                    btnExit.Text = "Назад";
                    btnSubmit.Text = "Изпрати";
                    break;

                case "English":
                    lblInfo.Text = "„SweetMoments” е приложение създадено през 2018 година, то предлага организиране на различни празненства и услуги." +
                        "Неговата цел е да улесни онлайн клентите с организирането на техните желани празненства.";
                    lblAboutUsTxt.Text = "About us";
                    lblName.Text = "Name:";
                    lblEmail.Text = "Email:";
                    lblMessage.Text = "Message:";
                    btnExit.Text = "Back";
                    btnSubmit.Text = "Send";
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
