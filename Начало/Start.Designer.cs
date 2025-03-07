
namespace Начало
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnChangeLanguage = new System.Windows.Forms.Button();
            this.btnAdminPannel = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfirmExitY = new System.Windows.Forms.Button();
            this.btnConfirmExitN = new System.Windows.Forms.Button();
            this.transitionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSize = true;
            this.btnAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.BackgroundImage")));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAbout.Location = new System.Drawing.Point(263, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(180, 26);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "За \"SweetMoments\"";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContacts.BackgroundImage")));
            this.btnContacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContacts.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnContacts.Location = new System.Drawing.Point(446, 12);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(180, 25);
            this.btnContacts.TabIndex = 1;
            this.btnContacts.Text = "Контакти";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistration.BackgroundImage")));
            this.btnRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistration.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.Location = new System.Drawing.Point(632, 12);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(180, 25);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.Text = "Регистрация";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReservation.BackgroundImage")));
            this.btnReservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservation.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnReservation.Location = new System.Drawing.Point(77, 13);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(180, 25);
            this.btnReservation.TabIndex = 4;
            this.btnReservation.Text = "Резервации";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnChangeLanguage
            // 
            this.btnChangeLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeLanguage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeLanguage.BackgroundImage")));
            this.btnChangeLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChangeLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeLanguage.Location = new System.Drawing.Point(783, 416);
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.Size = new System.Drawing.Size(75, 23);
            this.btnChangeLanguage.TabIndex = 7;
            this.btnChangeLanguage.Text = "English";
            this.btnChangeLanguage.UseVisualStyleBackColor = false;
            this.btnChangeLanguage.Click += new System.EventHandler(this.btnChangeLanguage_Click);
            // 
            // btnAdminPannel
            // 
            this.btnAdminPannel.AutoSize = true;
            this.btnAdminPannel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminPannel.BackgroundImage")));
            this.btnAdminPannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdminPannel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdminPannel.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnAdminPannel.Location = new System.Drawing.Point(24, 416);
            this.btnAdminPannel.Name = "btnAdminPannel";
            this.btnAdminPannel.Size = new System.Drawing.Size(126, 26);
            this.btnAdminPannel.TabIndex = 8;
            this.btnAdminPannel.Text = "Админски панел";
            this.btnAdminPannel.UseVisualStyleBackColor = true;
            this.btnAdminPannel.Click += new System.EventHandler(this.btnAdminPannel_Click);
            // 
            // update
            // 
            this.update.Enabled = true;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(379, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Изход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirmExitY
            // 
            this.btnConfirmExitY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmExitY.BackgroundImage")));
            this.btnConfirmExitY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmExitY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmExitY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirmExitY.ForeColor = System.Drawing.Color.White;
            this.btnConfirmExitY.Location = new System.Drawing.Point(379, 416);
            this.btnConfirmExitY.Name = "btnConfirmExitY";
            this.btnConfirmExitY.Size = new System.Drawing.Size(64, 23);
            this.btnConfirmExitY.TabIndex = 10;
            this.btnConfirmExitY.Text = "Да";
            this.btnConfirmExitY.UseVisualStyleBackColor = true;
            this.btnConfirmExitY.Click += new System.EventHandler(this.btnConfirmExitY_Click);
            // 
            // btnConfirmExitN
            // 
            this.btnConfirmExitN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmExitN.BackgroundImage")));
            this.btnConfirmExitN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmExitN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmExitN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirmExitN.ForeColor = System.Drawing.Color.White;
            this.btnConfirmExitN.Location = new System.Drawing.Point(449, 415);
            this.btnConfirmExitN.Name = "btnConfirmExitN";
            this.btnConfirmExitN.Size = new System.Drawing.Size(69, 23);
            this.btnConfirmExitN.TabIndex = 11;
            this.btnConfirmExitN.Text = "Не";
            this.btnConfirmExitN.UseVisualStyleBackColor = true;
            this.btnConfirmExitN.Click += new System.EventHandler(this.btnConfirmExitN_Click);
            // 
            // transitionTimer
            // 
            this.transitionTimer.Enabled = true;
            this.transitionTimer.Interval = 500;
            this.transitionTimer.Tick += new System.EventHandler(this.TransitionTimer_Tick);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnConfirmExitN);
            this.Controls.Add(this.btnConfirmExitY);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdminPannel);
            this.Controls.Add(this.btnChangeLanguage);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnChangeLanguage;
        private System.Windows.Forms.Button btnAdminPannel;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfirmExitY;
        private System.Windows.Forms.Button btnConfirmExitN;
        private System.Windows.Forms.Timer transitionTimer;
    }
}

