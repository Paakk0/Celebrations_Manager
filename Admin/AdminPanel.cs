using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Model;
using Data;
using Business;
using Message = Data.Model.Message;

namespace Admin
{
    public partial class AdminPanel : Form
    {
        public Client admin;
        public ClientBusiness clientBusiness = new ClientBusiness();
        public ReservationBusiness reservationBusiness = new ReservationBusiness();
        public CelebrationTypeBusiness celebrationTypeBusiness = new CelebrationTypeBusiness();
        public MessageBusiness messageBusiness = new MessageBusiness();
        public Context context = new Context();
        public string currentLanguage = "Bulgarian";
        public bool exit = false;
        public int editId = 0, switchDataGrid = 1;//   1 = Clients | 2 = Reservations | 3 = Messages
        public string celebrationType;
        public AdminPanel(string language)
        {
            InitializeComponent();
            currentLanguage = language;
        }
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAddService.Visible = btnDeleteService.Visible = txtService.Visible = false;
            ChangeLanguage();
            AddCelebrationTypes();
            UpdateGrid();
            UpdateForm();
            btnSave.Visible = false;
        }
        public void AddCelebrationTypes()
        {
            CelebrationTypeSelection.Items.Clear();
            object[] items = new object[celebrationTypeBusiness.GetAllTypes().Count()];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = celebrationTypeBusiness.GetAllTypes()[i].celebrationType;
            }
            CelebrationTypeSelection.Items.AddRange(items);
        }
        private void UpdateGrid()
        {
            switch (switchDataGrid)
            {
                case 1:
                    dataGridView1.DataSource = clientBusiness.GetAllClients();
                    dataGridView1.ReadOnly = true;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    btnAddReservation.Visible = false;
                    break;
                case 2:
                    dataGridView1.DataSource = reservationBusiness.GetAllReservations();
                    dataGridView1.ReadOnly = true;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    btnAddReservation.Visible = true;
                    break;
                case 3:
                    dataGridView1.DataSource = messageBusiness.GetAllMessages();
                    dataGridView1.ReadOnly = true;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    btnAddReservation.Visible = true;
                    break;
            }
            if (btnAddService.Visible)
            {
                dataGridView1.DataSource = celebrationTypeBusiness.GetAllTypes();
            }
        }
        public void UpdateForm()
        {
            switch (switchDataGrid)
            {
                case 1://show Clients
                    lblFName.Visible =
                    lblLname.Visible =
                    lblEmail.Visible =
                    lblPhone.Visible = true;
                    txtFName.Visible =
                    txtLName.Visible =
                    txtEmail.Visible =
                    txtPhone.Visible = true;

                    lblDateOfCelebration.Visible =
                    lblTimeOfStart.Visible =
                    lblTimeOfEnd.Visible =
                    lblCelebrationType.Visible =
                    lblDetails.Visible = false;
                    txtDateOfCelebration.Visible =
                    txtTimeOfStart.Visible =
                    txtTimeOfEnd.Visible =
                    txtDetails.Visible =
                    CelebrationTypeSelection.Visible = false;
                    break;

                case 2://show Reservations
                    lblFName.Visible =
                    lblLname.Visible =
                    lblEmail.Visible =
                    lblPhone.Visible = false;
                    txtFName.Visible =
                    txtLName.Visible =
                    txtEmail.Visible =
                    txtPhone.Visible = false;

                    lblDateOfCelebration.Visible =
                    lblTimeOfStart.Visible =
                    lblTimeOfEnd.Visible =
                    lblCelebrationType.Visible =
                    lblDetails.Visible = true;
                    txtDateOfCelebration.Visible =
                    txtTimeOfStart.Visible =
                    txtTimeOfEnd.Visible =
                    txtDetails.Visible =
                    CelebrationTypeSelection.Visible = true;
                    break;

                case 3://show Messages
                    lblFName.Visible =
                    lblLname.Visible =
                    lblEmail.Visible =
                    lblPhone.Visible = false;
                    txtFName.Visible =
                    txtLName.Visible =
                    txtEmail.Visible =
                    txtPhone.Visible = false;

                    lblDateOfCelebration.Visible =
                    lblTimeOfStart.Visible =
                    lblTimeOfEnd.Visible =
                    lblCelebrationType.Visible =
                    lblDetails.Visible = false;
                    txtDateOfCelebration.Visible =
                    txtTimeOfStart.Visible =
                    txtTimeOfEnd.Visible =
                    txtDetails.Visible =
                    CelebrationTypeSelection.Visible = false;

                    lblFName.Visible = txtFName.Visible = true;
                    lblEmail.Visible = txtEmail.Visible = true;
                    lblDetails.Visible = txtDetails.Visible = true;
                    if (currentLanguage == "Bulgarian")
                    {
                        lblDetails.Text = "Съобщение:";
                    }
                    else
                    {
                        lblDetails.Text = "Message:";
                    }
                    break;
            }
        }

        private void btnSwitchData_Click(object sender, EventArgs e)
        {
            if (switchDataGrid == 3)
            {
                switchDataGrid = 0;
            }
            switchDataGrid += 1;
            UpdateGrid();
            ResetSelect();
            UpdateForm();
            ClearTextBoxes();
        }
        private void ResetSelect()
        {
            dataGridView1.Enabled = true;
            dataGridView1.ClearSelection();
        }
        private void ChangeLanguage()
        {
            switch (currentLanguage)
            {
                case "Bulgarian":
                    lblFName.Text = "Име:";
                    lblLname.Text = "Фамилия:";
                    lblEmail.Text = "Имейл:";
                    lblPhone.Text = "Тел. номер:";
                    lblDateOfCelebration.Text = "Дата на празненството:";
                    lblTimeOfStart.Text = "От:";
                    lblTimeOfEnd.Text = "До:";
                    lblDetails.Text = "Детайли:";
                    lblCelebrationType.Text = "Тип празненство:";

                    btnUpdate.Text = "Актуализирай";
                    btnSave.Text = "Запази";
                    btnDeleteReservation.Text = "Изтрий";
                    btnAddReservation.Text = "Добави";
                    btnSwitchData.Text = "Смяна";
                    btnExit.Text = "Назад";
                    btnService.Text = "Услуги";
                    btnAddService.Text = "Добави";
                    btnDeleteService.Text = "Изтрий";
                    break;

                case "English":
                    lblFName.Text = "First name:";
                    lblLname.Text = "Last name:";
                    lblEmail.Text = "Email:";
                    lblPhone.Text = "Phone:";
                    lblDateOfCelebration.Text = "Date of celebration:";
                    lblTimeOfStart.Text = "From:";
                    lblTimeOfEnd.Text = "To:";
                    lblDetails.Text = "Details:";
                    lblCelebrationType.Text = "Celebration type:";

                    btnUpdate.Text = "Update";
                    btnSave.Text = "Save";
                    btnDeleteReservation.Text = "Delete";
                    btnAddReservation.Text = "Add";
                    btnSwitchData.Text = "Switch";
                    btnExit.Text = "Back";
                    btnService.Text = "Services";
                    btnAddService.Text = "Add";
                    btnDeleteService.Text = "Delete";
                    break;
            }
        }

        private Reservation GetUpdatedReservation()
        {
            var item = dataGridView1.SelectedRows[0].Cells;
            Reservation r = reservationBusiness.GetReservationById(int.Parse(item[0].Value.ToString()));
            r.CelebrationType = celebrationType;
            r.CelebrationDate = txtDateOfCelebration.Text;
            r.TimeOfStart = txtTimeOfStart.Text;
            r.TimeOfEnd = txtTimeOfEnd.Text;
            r.details = txtDetails.Text;
            return r;
        }
        private Client GetUpdatedClient()
        {
            var item = dataGridView1.SelectedRows[0].Cells;
            Client c = clientBusiness.GetClientById(int.Parse(item[0].Value.ToString()));
            c.firstName = txtFName.Text;
            c.lastName = txtLName.Text;
            c.email = txtEmail.Text;
            c.phone = txtPhone.Text;
            return c;
        }
        private Message GetUpdatedMessage()
        {
            var item = dataGridView1.SelectedRows[0].Cells;
            Message m = messageBusiness.GetMessageById(int.Parse(item[0].Value.ToString()));
            m.name = txtFName.Text;
            m.email = txtEmail.Text;
            m.message = txtDetails.Text;
            return m;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (switchDataGrid)
            {
                case 1:
                    Client c = GetUpdatedClient();
                    clientBusiness.UpdateClient(c);
                    ClearTextBoxes();
                    UpdateGrid();
                    ResetSelect();
                    ToggleSaveUpdate();
                    break;

                case 2:
                    Reservation r = GetUpdatedReservation();
                    if (txtDateOfCelebration.Text != "YYYY-MM-DD" && txtTimeOfStart.Text != "hh:mm" && txtTimeOfEnd.Text != "hh:mm" &&
                !string.IsNullOrEmpty(celebrationType) && !string.IsNullOrEmpty(txtDetails.Text))
                    {
                        DateTime cDate = new DateTime();
                        DateTime startTime = new DateTime();
                        DateTime endTime = new DateTime();
                        try
                        {
                            cDate = DateTime.Parse(r.CelebrationDate.ToString());
                            startTime = DateTime.Parse(r.TimeOfStart.ToString());
                            endTime = DateTime.Parse(r.TimeOfEnd.ToString());
                        }
                        catch (FormatException)
                        {
                            r = null;
                            if (currentLanguage == "Bulgarian")
                            {
                                MessageBox.Show("Въведете правилни дати!");
                            }
                            else
                            {
                                MessageBox.Show("Enter correct dates!");
                            }
                        }
                        if (r != null)
                        {
                            reservationBusiness.UpdateReservation(r);
                            ClearTextBoxes();
                            UpdateGrid();
                            ResetSelect();
                            ToggleSaveUpdate();
                        }
                    }
                    else
                    {
                        if (currentLanguage == "Bulgarian")
                        {
                            MessageBox.Show("Не са попълнени всички полета!");
                        }
                        else
                        {
                            MessageBox.Show("Not all fields are filled!");
                        }
                    }
                    break;

                case 3:
                    Message m = GetUpdatedMessage();
                    messageBusiness.UpdateMessage(m);
                    ClearTextBoxes();
                    UpdateGrid();
                    ResetSelect();
                    ToggleSaveUpdate();
                    break;
            }
        }
        private void ToggleSaveUpdate()
        {
            btnUpdate.Visible = !btnUpdate.Visible;
            btnSave.Visible = !btnSave.Visible;
        }
        private void ClearTextBoxes()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtDateOfCelebration.Text = "YYYY-MM-DD";
            txtTimeOfStart.Text = "hh:mm";
            txtTimeOfEnd.Text = "hh:mm";
            txtDetails.Text = "";
        }
        private void DisableSelect()
        {
            dataGridView1.Enabled = false;
        }

        private void CelebrationTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            celebrationType = CelebrationTypeSelection.SelectedItem.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = editId = int.Parse(item[0].Value.ToString());
                UpdateTextBox(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
        }
        private void UpdateTextBox(int id)
        {
            switch (switchDataGrid)
            {
                case 1://Clients
                    Client client = clientBusiness.GetClientById(id);
                    txtFName.Text = client.firstName;
                    txtLName.Text = client.lastName;
                    txtEmail.Text = client.email;
                    txtPhone.Text = client.phone;
                    break;

                case 2://Reservations
                    Reservation reservation = reservationBusiness.GetReservationById(id);
                    txtDateOfCelebration.Text = reservation.CelebrationDate.ToString();
                    txtTimeOfStart.Text = reservation.TimeOfStart.ToString();
                    txtTimeOfEnd.Text = reservation.TimeOfEnd.ToString();
                    CelebrationTypeSelection.Text = reservation.CelebrationType;
                    txtDetails.Text = reservation.details;
                    break;

                case 3://Messages
                    Message message = messageBusiness.GetMessageById(id);
                    txtFName.Text = message.name;
                    txtEmail.Text = message.email;
                    txtDetails.Text = message.message;
                    break;
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            switch (switchDataGrid)
            {
                case 2://Reservations
                    if (txtDateOfCelebration.Text != "YYYY-MM-DD" && txtTimeOfStart.Text != "hh:mm" && txtTimeOfEnd.Text != "hh:mm" &&
                !string.IsNullOrEmpty(celebrationType) && !string.IsNullOrEmpty(txtDetails.Text))
                    {
                        DateTime cDate = new DateTime();
                        DateTime startTime = new DateTime();
                        DateTime endTime = new DateTime();
                        Reservation r = new Reservation()
                        {
                            cId = admin.ClientId,
                            CelebrationType = celebrationType,
                            CelebrationDate = txtDateOfCelebration.Text,
                            TimeOfStart = txtTimeOfStart.Text,
                            TimeOfEnd = txtTimeOfEnd.Text,
                            details = txtDetails.Text
                        };
                        try
                        {
                            cDate = DateTime.Parse(r.CelebrationDate.ToString());
                            startTime = DateTime.Parse(r.TimeOfStart.ToString());
                            endTime = DateTime.Parse(r.TimeOfEnd.ToString());
                        }
                        catch (FormatException)
                        {
                            r = null;
                            txtDateOfCelebration.Text = "YYYY-MM-DD";
                            txtTimeOfStart.Text = txtTimeOfEnd.Text = "hh:mm";
                            if (currentLanguage == "Bulgarian")
                            {
                                MessageBox.Show("Въведете правилни дати!");
                            }
                            else
                            {
                                MessageBox.Show("Enter correct dates!");
                            }
                        }
                        if (r != null)
                        {
                            reservationBusiness.AddReservation(r);
                            ClearTextBoxes();
                            ResetSelect();
                            UpdateGrid();
                        }
                    }
                    else
                    {
                        if (currentLanguage == "Bulgarian")
                        {
                            MessageBox.Show("Не са попълнени всички полета!");
                        }
                        else
                        {
                            MessageBox.Show("Not all fields are filled!");
                        }
                    }
                    break;

                case 3://Messages
                    if (!(string.IsNullOrEmpty(txtFName.Text) && string.IsNullOrEmpty(txtEmail.Text) && string.IsNullOrEmpty(txtDetails.Text)))
                    {
                        if (txtEmail.Text.Contains('@'))
                        {
                            var message = new Message
                            {
                                name = txtFName.Text,
                                email = txtEmail.Text,
                                message = txtDetails.Text
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
                    break;
            }
            ClearTextBoxes();
            ResetSelect();
            UpdateGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                switch (switchDataGrid)
                {
                    case 1://Clients
                        Client temp = clientBusiness.GetClientById(id);
                        if (temp.admin == "false")
                        {
                            clientBusiness.DeleteClientById(id);
                        }
                        else
                        {
                            if (currentLanguage == "Bulgarian")
                            {
                                MessageBox.Show("Не можеш да премахнеш админ!");
                            }
                            else
                            {
                                MessageBox.Show("You can't remove an admin!");
                            }
                        }
                        break;

                    case 2://Reservations
                        reservationBusiness.DeleteReservationById(id);
                        break;

                    case 3://Messages
                        messageBusiness.DeleteMessage(id);
                        break;
                }
                ClearTextBoxes();
                ResetSelect();
                UpdateGrid();
            }
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            btnAddService.Visible = btnDeleteService.Visible = txtService.Visible = !btnAddService.Visible;
            btnAddReservation.Enabled = btnDeleteReservation.Enabled = btnUpdate.Enabled = btnSwitchData.Enabled = !btnAddService.Visible;
            UpdateGrid();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtService.Text))
            {
                CelebrationType type = new CelebrationType
                {
                    celebrationType = txtService.Text
                };
                celebrationTypeBusiness.AddType(type);
                txtService.Text = "";
                UpdateGrid();
                AddCelebrationTypes();
            }
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                celebrationTypeBusiness.DeleteType(id);
                txtService.Text = "";
                UpdateGrid();
                ResetSelect();
                AddCelebrationTypes();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AdminPanel.ActiveForm.Dispose();
        }
    }
}
