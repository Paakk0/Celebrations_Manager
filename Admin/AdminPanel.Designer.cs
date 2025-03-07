
namespace Admin
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.lblTimeOfEnd = new System.Windows.Forms.Label();
            this.lblDateOfCelebration = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtTimeOfEnd = new System.Windows.Forms.TextBox();
            this.txtTimeOfStart = new System.Windows.Forms.TextBox();
            this.txtDateOfCelebration = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteReservation = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSwitchData = new System.Windows.Forms.Button();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblTimeOfStart = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.CelebrationTypeSelection = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.TextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.lblCelebrationType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimeOfEnd
            // 
            this.lblTimeOfEnd.AutoSize = true;
            this.lblTimeOfEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeOfEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeOfEnd.ForeColor = System.Drawing.Color.Red;
            this.lblTimeOfEnd.Location = new System.Drawing.Point(188, 235);
            this.lblTimeOfEnd.Name = "lblTimeOfEnd";
            this.lblTimeOfEnd.Size = new System.Drawing.Size(31, 16);
            this.lblTimeOfEnd.TabIndex = 33;
            this.lblTimeOfEnd.Text = "До:";
            // 
            // lblDateOfCelebration
            // 
            this.lblDateOfCelebration.AutoSize = true;
            this.lblDateOfCelebration.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfCelebration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateOfCelebration.ForeColor = System.Drawing.Color.Red;
            this.lblDateOfCelebration.Location = new System.Drawing.Point(26, 209);
            this.lblDateOfCelebration.Name = "lblDateOfCelebration";
            this.lblDateOfCelebration.Size = new System.Drawing.Size(188, 16);
            this.lblDateOfCelebration.TabIndex = 32;
            this.lblDateOfCelebration.Text = "Дата на празненството:";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(29, 331);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(237, 142);
            this.txtDetails.TabIndex = 31;
            // 
            // txtTimeOfEnd
            // 
            this.txtTimeOfEnd.Location = new System.Drawing.Point(220, 235);
            this.txtTimeOfEnd.Name = "txtTimeOfEnd";
            this.txtTimeOfEnd.Size = new System.Drawing.Size(109, 20);
            this.txtTimeOfEnd.TabIndex = 30;
            // 
            // txtTimeOfStart
            // 
            this.txtTimeOfStart.Location = new System.Drawing.Point(74, 234);
            this.txtTimeOfStart.Name = "txtTimeOfStart";
            this.txtTimeOfStart.Size = new System.Drawing.Size(108, 20);
            this.txtTimeOfStart.TabIndex = 29;
            // 
            // txtDateOfCelebration
            // 
            this.txtDateOfCelebration.Location = new System.Drawing.Point(220, 209);
            this.txtDateOfCelebration.Name = "txtDateOfCelebration";
            this.txtDateOfCelebration.Size = new System.Drawing.Size(109, 20);
            this.txtDateOfCelebration.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(363, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.AutoSize = true;
            this.btnDeleteReservation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteReservation.BackgroundImage")));
            this.btnDeleteReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteReservation.Location = new System.Drawing.Point(363, 238);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteReservation.TabIndex = 26;
            this.btnDeleteReservation.Text = "Delete";
            this.btnDeleteReservation.UseVisualStyleBackColor = true;
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(363, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 168);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnSwitchData
            // 
            this.btnSwitchData.AutoSize = true;
            this.btnSwitchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSwitchData.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSwitchData.Location = new System.Drawing.Point(638, 186);
            this.btnSwitchData.Name = "btnSwitchData";
            this.btnSwitchData.Size = new System.Drawing.Size(117, 39);
            this.btnSwitchData.TabIndex = 35;
            this.btnSwitchData.Text = "Switch";
            this.btnSwitchData.UseVisualStyleBackColor = true;
            this.btnSwitchData.Click += new System.EventHandler(this.btnSwitchData_Click);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.Transparent;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFName.ForeColor = System.Drawing.Color.Red;
            this.lblFName.Location = new System.Drawing.Point(26, 209);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(42, 16);
            this.lblFName.TabIndex = 37;
            this.lblFName.Text = "Име:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(126, 208);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(109, 20);
            this.txtFName.TabIndex = 36;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.Transparent;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLname.ForeColor = System.Drawing.Color.Red;
            this.lblLname.Location = new System.Drawing.Point(26, 235);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(78, 16);
            this.lblLname.TabIndex = 39;
            this.lblLname.Text = "Фамилия:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(126, 234);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(109, 20);
            this.txtLName.TabIndex = 38;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(26, 261);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 16);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "Имейл:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(126, 260);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(109, 20);
            this.txtEmail.TabIndex = 40;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.ForeColor = System.Drawing.Color.Red;
            this.lblPhone.Location = new System.Drawing.Point(26, 287);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(94, 16);
            this.lblPhone.TabIndex = 43;
            this.lblPhone.Text = "Тел. номер:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(126, 287);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(109, 20);
            this.txtPhone.TabIndex = 42;
            // 
            // lblTimeOfStart
            // 
            this.lblTimeOfStart.AutoSize = true;
            this.lblTimeOfStart.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeOfStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeOfStart.ForeColor = System.Drawing.Color.Red;
            this.lblTimeOfStart.Location = new System.Drawing.Point(26, 236);
            this.lblTimeOfStart.Name = "lblTimeOfStart";
            this.lblTimeOfStart.Size = new System.Drawing.Size(31, 16);
            this.lblTimeOfStart.TabIndex = 44;
            this.lblTimeOfStart.Text = "От:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDetails.ForeColor = System.Drawing.Color.Red;
            this.lblDetails.Location = new System.Drawing.Point(26, 306);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(75, 16);
            this.lblDetails.TabIndex = 45;
            this.lblDetails.Text = "Детайли:";
            // 
            // CelebrationTypeSelection
            // 
            this.CelebrationTypeSelection.FormattingEnabled = true;
            this.CelebrationTypeSelection.Location = new System.Drawing.Point(29, 277);
            this.CelebrationTypeSelection.Name = "CelebrationTypeSelection";
            this.CelebrationTypeSelection.Size = new System.Drawing.Size(121, 21);
            this.CelebrationTypeSelection.TabIndex = 46;
            this.CelebrationTypeSelection.SelectedIndexChanged += new System.EventHandler(this.CelebrationTypeSelection_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(680, 450);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddReservation.BackgroundImage")));
            this.btnAddReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddReservation.Location = new System.Drawing.Point(363, 209);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(75, 23);
            this.btnAddReservation.TabIndex = 48;
            this.btnAddReservation.Text = "Add";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // btnService
            // 
            this.btnService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnService.BackgroundImage")));
            this.btnService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.Location = new System.Drawing.Point(478, 209);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(127, 23);
            this.btnService.TabIndex = 49;
            this.btnService.Text = "Услуги";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(478, 241);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(127, 20);
            this.txtService.TabIndex = 50;
            // 
            // btnAddService
            // 
            this.btnAddService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddService.BackgroundImage")));
            this.btnAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Location = new System.Drawing.Point(478, 267);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(60, 23);
            this.btnAddService.TabIndex = 51;
            this.btnAddService.Text = "Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteService.BackgroundImage")));
            this.btnDeleteService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteService.ForeColor = System.Drawing.Color.White;
            this.btnDeleteService.Location = new System.Drawing.Point(544, 267);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(61, 23);
            this.btnDeleteService.TabIndex = 52;
            this.btnDeleteService.Text = "Delete";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // lblCelebrationType
            // 
            this.lblCelebrationType.AutoSize = true;
            this.lblCelebrationType.BackColor = System.Drawing.Color.Transparent;
            this.lblCelebrationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCelebrationType.ForeColor = System.Drawing.Color.Red;
            this.lblCelebrationType.Location = new System.Drawing.Point(26, 257);
            this.lblCelebrationType.Name = "lblCelebrationType";
            this.lblCelebrationType.Size = new System.Drawing.Size(141, 16);
            this.lblCelebrationType.TabIndex = 53;
            this.lblCelebrationType.Text = "Тип празненство:";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 492);
            this.Controls.Add(this.lblCelebrationType);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.CelebrationTypeSelection);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblTimeOfStart);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.btnSwitchData);
            this.Controls.Add(this.lblTimeOfEnd);
            this.Controls.Add(this.lblDateOfCelebration);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtTimeOfEnd);
            this.Controls.Add(this.txtTimeOfStart);
            this.Controls.Add(this.txtDateOfCelebration);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteReservation);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimeOfEnd;
        private System.Windows.Forms.Label lblDateOfCelebration;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtTimeOfEnd;
        private System.Windows.Forms.TextBox txtTimeOfStart;
        private System.Windows.Forms.TextBox txtDateOfCelebration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteReservation;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSwitchData;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblTimeOfStart;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ComboBox CelebrationTypeSelection;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Label lblCelebrationType;
    }
}

