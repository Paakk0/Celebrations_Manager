
namespace Celebrations_Project
{
    partial class Reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            this.txtDateOfCelebration = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTimeOfStart = new System.Windows.Forms.TextBox();
            this.txtTimeOfEnd = new System.Windows.Forms.TextBox();
            this.lblDateOfCelebration = new System.Windows.Forms.Label();
            this.lblTimeOfStart = new System.Windows.Forms.Label();
            this.lblTimeOfEnd = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.CelebrationTypeSelection = new System.Windows.Forms.ComboBox();
            this.lblCelebrationType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDateOfCelebration
            // 
            this.txtDateOfCelebration.Location = new System.Drawing.Point(208, 15);
            this.txtDateOfCelebration.Name = "txtDateOfCelebration";
            this.txtDateOfCelebration.Size = new System.Drawing.Size(109, 20);
            this.txtDateOfCelebration.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(176, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(95, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(176, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(14, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 339);
            this.dataGridView1.TabIndex = 6;
            // 
            // txtTimeOfStart
            // 
            this.txtTimeOfStart.Location = new System.Drawing.Point(62, 40);
            this.txtTimeOfStart.Name = "txtTimeOfStart";
            this.txtTimeOfStart.Size = new System.Drawing.Size(108, 20);
            this.txtTimeOfStart.TabIndex = 12;
            // 
            // txtTimeOfEnd
            // 
            this.txtTimeOfEnd.Location = new System.Drawing.Point(208, 41);
            this.txtTimeOfEnd.Name = "txtTimeOfEnd";
            this.txtTimeOfEnd.Size = new System.Drawing.Size(109, 20);
            this.txtTimeOfEnd.TabIndex = 13;
            // 
            // lblDateOfCelebration
            // 
            this.lblDateOfCelebration.AutoSize = true;
            this.lblDateOfCelebration.BackColor = System.Drawing.Color.Transparent;
            this.lblDateOfCelebration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateOfCelebration.ForeColor = System.Drawing.Color.Blue;
            this.lblDateOfCelebration.Location = new System.Drawing.Point(14, 15);
            this.lblDateOfCelebration.Name = "lblDateOfCelebration";
            this.lblDateOfCelebration.Size = new System.Drawing.Size(188, 16);
            this.lblDateOfCelebration.TabIndex = 16;
            this.lblDateOfCelebration.Text = "Дата на празненството:";
            // 
            // lblTimeOfStart
            // 
            this.lblTimeOfStart.AutoSize = true;
            this.lblTimeOfStart.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeOfStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeOfStart.ForeColor = System.Drawing.Color.Blue;
            this.lblTimeOfStart.Location = new System.Drawing.Point(14, 41);
            this.lblTimeOfStart.Name = "lblTimeOfStart";
            this.lblTimeOfStart.Size = new System.Drawing.Size(31, 16);
            this.lblTimeOfStart.TabIndex = 17;
            this.lblTimeOfStart.Text = "От:";
            // 
            // lblTimeOfEnd
            // 
            this.lblTimeOfEnd.AutoSize = true;
            this.lblTimeOfEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeOfEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeOfEnd.ForeColor = System.Drawing.Color.Blue;
            this.lblTimeOfEnd.Location = new System.Drawing.Point(176, 41);
            this.lblTimeOfEnd.Name = "lblTimeOfEnd";
            this.lblTimeOfEnd.Size = new System.Drawing.Size(31, 16);
            this.lblTimeOfEnd.TabIndex = 18;
            this.lblTimeOfEnd.Text = "До:";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(14, 129);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(237, 142);
            this.txtDetails.TabIndex = 15;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(885, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDetails.ForeColor = System.Drawing.Color.Blue;
            this.lblDetails.Location = new System.Drawing.Point(14, 110);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(75, 16);
            this.lblDetails.TabIndex = 41;
            this.lblDetails.Text = "Детайли:";
            // 
            // CelebrationTypeSelection
            // 
            this.CelebrationTypeSelection.FormattingEnabled = true;
            this.CelebrationTypeSelection.Location = new System.Drawing.Point(17, 86);
            this.CelebrationTypeSelection.Name = "CelebrationTypeSelection";
            this.CelebrationTypeSelection.Size = new System.Drawing.Size(121, 21);
            this.CelebrationTypeSelection.TabIndex = 47;
            this.CelebrationTypeSelection.SelectedIndexChanged += new System.EventHandler(this.CelebrationTypeSelection_SelectedIndexChanged);
            // 
            // lblCelebrationType
            // 
            this.lblCelebrationType.AutoSize = true;
            this.lblCelebrationType.BackColor = System.Drawing.Color.Transparent;
            this.lblCelebrationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCelebrationType.ForeColor = System.Drawing.Color.Blue;
            this.lblCelebrationType.Location = new System.Drawing.Point(14, 67);
            this.lblCelebrationType.Name = "lblCelebrationType";
            this.lblCelebrationType.Size = new System.Drawing.Size(141, 16);
            this.lblCelebrationType.TabIndex = 48;
            this.lblCelebrationType.Text = "Тип празненство:";
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 424);
            this.Controls.Add(this.lblCelebrationType);
            this.Controls.Add(this.CelebrationTypeSelection);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTimeOfEnd);
            this.Controls.Add(this.lblTimeOfStart);
            this.Controls.Add(this.lblDateOfCelebration);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtTimeOfEnd);
            this.Controls.Add(this.txtTimeOfStart);
            this.Controls.Add(this.txtDateOfCelebration);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDateOfCelebration;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTimeOfStart;
        private System.Windows.Forms.TextBox txtTimeOfEnd;
        private System.Windows.Forms.Label lblDateOfCelebration;
        private System.Windows.Forms.Label lblTimeOfStart;
        private System.Windows.Forms.Label lblTimeOfEnd;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ComboBox CelebrationTypeSelection;
        private System.Windows.Forms.Label lblCelebrationType;
    }
}

