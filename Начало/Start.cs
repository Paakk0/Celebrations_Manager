using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celebrations_Project;
using Data.Model;
using Business;

namespace Начало
{
    public partial class Start : Form
    {
        public static string currentLanguage = "Bulgarian";
        public Информация.About about = new Информация.About(currentLanguage);
        public Reservations reservation = new Reservations();
        public Registration.Registration registration = new Registration.Registration();
        public Admin.AdminPanel admin = new Admin.AdminPanel();
        public Client client;
        public Form form;
        public CelebrationTypeBusiness ctR = new CelebrationTypeBusiness();
        public ClientBusiness cB = new ClientBusiness();
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckIfClientIsLogged();
            btnConfirmExitY.Visible = btnConfirmExitN.Visible = false;
            update.Tick += UpdateEvent;
            update.Interval = 500;
            AddTypes();
            AddAdmin();
        }

        public void AddTypes()
        {
            switch (ctR.GetAllTypes().Count)
            {
                case 1:
                    List<CelebrationType> temp = ctR.GetAllTypes();
                    if (temp[0].celebrationType == "Birthday")
                    {
                        CelebrationType type = new CelebrationType { celebrationType = "Wedding" };
                        ctR.AddType(type);
                    }
                    else if (temp[0].celebrationType == "Wedding")
                    {
                        CelebrationType type = new CelebrationType { celebrationType = "Birthday" };
                        ctR.AddType(type);
                    }
                    else
                    {
                        CelebrationType t1 = new CelebrationType { celebrationType = "Birthday" };
                        CelebrationType t2 = new CelebrationType { celebrationType = "Wedding" };
                        ctR.AddType(t1);
                        ctR.AddType(t2);
                    }
                    break;
                case 0:
                    CelebrationType type1 = new CelebrationType { celebrationType = "Birthday" };
                    CelebrationType type2 = new CelebrationType { celebrationType = "Wedding" };
                    ctR.AddType(type1);
                    ctR.AddType(type2);
                    break;
            }
        }
        public void AddAdmin()
        {
            bool hasAdmin = false;
            foreach (var item in cB.GetAllClients())
            {
                if (item.admin == "true")
                {
                    hasAdmin = true;
                }
            }
            if (!hasAdmin)
            {
                Client temp = new Client
                {
                    firstName = "Християн",
                    lastName = "Керкенезов",
                    email = "admin@1",
                    phone = "0123323321",
                    password = "123123",
                    admin = "true"
                };
                cB.AddClient(temp);
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            if (reservation.IsDisposed)
            {
                reservation = new Reservations();
            }
            AddTypes();
            reservation.currentLanguage = currentLanguage;
            reservation.client = this.client;
            Start.ActiveForm.Hide();
            reservation.Show();
            form = reservation;
            transitionTimer.Start();
        }


        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (about.IsDisposed)
            {
                about = new Информация.About();
            }
            about.currentLanguage = currentLanguage;
            about.Info = true;
            Start.ActiveForm.Hide();
            about.Show();
            update.Start();
            form = about;
            transitionTimer.Start();
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            if (about.IsDisposed)
            {
                about = new Информация.About(currentLanguage);
            }
            about.Info = false;
            Start.ActiveForm.Hide();
            about.Show();
            update.Start();
            form = about;
            transitionTimer.Start();
        }

        private void btnChangeLanguage_Click(object sender, EventArgs e)
        {
            if (btnChangeLanguage.Text == "English")
            {
                btnAbout.Text = "About 'SweetMoments'";
                btnContacts.Text = "Contacts";
                btnRegistration.Text = "Registration";
                btnReservation.Text = "Reservations";
                btnAdminPannel.Text = "Admin Panel";
                btnChangeLanguage.Text = "Bulgarian";
                btnConfirmExitY.Text = "Yes";
                btnConfirmExitN.Text = "No";
                btnExit.Text = "Exit";

                currentLanguage = "English";
            }

            else if (btnChangeLanguage.Text == "Bulgarian")
            {
                btnAbout.Text = "За 'SweetMoments'";
                btnContacts.Text = "Контакти";
                btnRegistration.Text = "Регистрации";
                btnReservation.Text = "Резервации";
                btnAdminPannel.Text = "Админски панел";
                btnChangeLanguage.Text = "English";
                btnConfirmExitY.Text = "Да";
                btnConfirmExitN.Text = "Не";
                btnExit.Text = "Изход";

                currentLanguage = "Bulgarian";
            }
        }
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (registration.IsDisposed)
            {
                registration = new Registration.Registration(currentLanguage);
            }
            if (client != null)
            {
                registration.client = client;
            }
            registration.currentLanguage = currentLanguage;
            update.Start();
            Start.ActiveForm.Hide();
            registration.Show();
            form = registration;
            transitionTimer.Start();
        }
        private void TransitionTimer_Tick(object sender, EventArgs e)
        {
            if (form != null)
            {
                if (form.IsDisposed)
                {
                    this.Show();
                    transitionTimer.Stop();
                }
            }
        }
        private void CheckIfClientIsLogged()
        {
            if (client != null)
            {
                btnReservation.Enabled = true;
                if (client.admin == "true")
                {
                    btnAdminPannel.Visible = true;
                }
                else btnAdminPannel.Visible = false;
            }
            else
            {
                btnReservation.Enabled = false;
                btnAdminPannel.Visible = false;
            }
        }
        private void btnAdminPannel_Click(object sender, EventArgs e)
        {
            if (admin.IsDisposed)
            {
                admin = new Admin.AdminPanel();
            }
            AddTypes();
            admin.currentLanguage = currentLanguage;
            admin.admin = this.client;
            Start.ActiveForm.Hide();
            admin.Show();
            form = admin;
            transitionTimer.Start();
        }

        public void UpdateEvent(object sender, EventArgs e)
        {
            if (registration.client != null)
            {
                this.client = registration.client;
                CheckIfClientIsLogged();
            }
            else
            {
                this.client = null;
                CheckIfClientIsLogged();
            }
            if (registration.IsDisposed)
            {
                update.Stop();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnConfirmExitY.Visible = btnConfirmExitN.Visible = true;
            btnExit.Visible = false;
        }

        private void btnConfirmExitY_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirmExitN_Click(object sender, EventArgs e)
        {
            btnConfirmExitY.Visible = btnConfirmExitN.Visible = false;
            btnExit.Visible = true;
        }
    }
}