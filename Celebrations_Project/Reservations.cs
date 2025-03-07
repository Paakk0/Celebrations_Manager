using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data.Model;
using Data;
using Celebrations_Project;

namespace Celebrations_Project
{
    public partial class Reservations : Form
    {
        public ReservationBusiness reservationBusiness = new ReservationBusiness();
        public CelebrationTypeBusiness celebrationTypeBusiness = new CelebrationTypeBusiness();
        public Client client;
        public int editId = 0;
        public string currentLanguage, celebrationType;

        public Reservations(string language)
        {
            InitializeComponent();
            currentLanguage = language;
        }
        public Reservations()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            AddCelebrationTypes();
            ClearTextBoxes();
            UpdateGrid();
            ChangeLanguage();
        }
        public void AddCelebrationTypes()
        {
            object[] items = new object[celebrationTypeBusiness.GetAllTypes().Count()];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = celebrationTypeBusiness.GetAllTypes()[i].celebrationType;
            }
            CelebrationTypeSelection.Items.AddRange(items);
        }

        private void ClearTextBoxes()
        {
            txtDateOfCelebration.Text = "YYYY-MM-DD";
            txtTimeOfStart.Text = "hh:mm";
            txtTimeOfEnd.Text = "hh:mm";
            txtDetails.Text = "";
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = reservationBusiness.GetAllReservations();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDateOfCelebration.Text != "YYYY-MM-DD" && txtTimeOfStart.Text != "hh:mm" && txtTimeOfEnd.Text != "hh:mm" &&
                !string.IsNullOrEmpty(celebrationType) && !string.IsNullOrEmpty(txtDetails.Text))
            {
                DateTime cDate = new DateTime();
                DateTime startTime = new DateTime();
                DateTime endTime = new DateTime();
                Reservation r = new Reservation()
                {
                    cId = client.ClientId,
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
                    MessageBox.Show("Моля попълнете всички полета!");
                }
                else
                {
                    MessageBox.Show("Please fill all fields!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                reservationBusiness.DeleteReservationById(id);
                UpdateGrid();
                dataGridView1.ClearSelection();
            }
        }

        private void UpdateTextBox(int id)
        {
            Reservation update = reservationBusiness.GetReservationById(id);
            txtDateOfCelebration.Text = update.CelebrationDate.ToString();
            txtTimeOfStart.Text = update.TimeOfStart.ToString();
            txtTimeOfEnd.Text = update.TimeOfEnd.ToString();
            txtDetails.Text = update.details;
            foreach (object item in CelebrationTypeSelection.Items)
            {
                if (update.CelebrationType == item.ToString())
                {
                    CelebrationTypeSelection.SelectedItem = item;
                }
            }
        }

        private void ToggleSaveUpdate()
        {
            btnUpdate.Visible = !btnUpdate.Visible;
            btnSave.Visible = !btnSave.Visible;
        }

        private void DisableSelect()
        {
            dataGridView1.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].Cells;
                var id = editId = int.Parse(item[0].Value.ToString());
                if (client.ClientId == int.Parse(item[1].Value.ToString()))
                {
                    UpdateTextBox(id);
                    ToggleSaveUpdate();
                    DisableSelect();
                }
                else
                {
                    if (currentLanguage == "Bulgarian")
                    {
                        MessageBox.Show("Не можете да променяте чужда информация!");
                    }
                    else
                    {
                        MessageBox.Show("You can't change other's information!");
                    }
                }
            }
        }

        private Reservation GetUpdatedReservation()
        {
            var item = dataGridView1.SelectedRows[0].Cells;
            Reservation r = new Reservation()
            {
                ReservationId = editId,
                cId = client.ClientId,
                CelebrationType = CelebrationTypeSelection.SelectedItem.ToString(),
                CelebrationDate = txtDateOfCelebration.Text,
                TimeOfStart = txtTimeOfStart.Text,
                TimeOfEnd = txtTimeOfEnd.Text,
                details = txtDetails.Text
            };
            return r;
        }

        private void ResetSelect()
        {
            dataGridView1.Enabled = true;
            dataGridView1.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("Моля попълнете всички полета!");
                }
                else
                {
                    MessageBox.Show("Please fill all fields!");
                }
            }
        }

        private void ChangeLanguage()
        {
            switch (currentLanguage)
            {
                case "Bulgarian":
                    lblDateOfCelebration.Text = "Дата на празненството:";
                    lblTimeOfStart.Text = "От:";
                    lblTimeOfEnd.Text = "До:";
                    lblDetails.Text = "Детайли:";
                    lblCelebrationType.Text = "Тип празненство:";

                    btnAdd.Text = "Добави";
                    btnUpdate.Text = "Актуализирай";
                    btnSave.Text = "Запази";
                    btnDelete.Text = "Изтрий";
                    btnExit.Text = "Назад";
                    break;

                case "English":
                    lblDateOfCelebration.Text = "Date of celebration:";
                    lblTimeOfStart.Text = "From:";
                    lblTimeOfEnd.Text = "To:";
                    lblDetails.Text = "Details:";
                    lblCelebrationType.Text = "Celebration type:";

                    btnAdd.Text = "Add";
                    btnUpdate.Text = "Update";
                    btnSave.Text = "Save";
                    btnDelete.Text = "Delete";
                    btnExit.Text = "Back";
                    break;
            }
        }

        private void CelebrationTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            celebrationType = CelebrationTypeSelection.SelectedItem.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
