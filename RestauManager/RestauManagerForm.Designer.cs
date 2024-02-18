namespace RestauManager
{
    partial class RestauManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestauManagerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.restauPictureBox = new System.Windows.Forms.PictureBox();
            this.infoGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.reservationGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.prixLabel = new System.Windows.Forms.Label();
            this.specialiteComboBox = new System.Windows.Forms.ComboBox();
            this.restaurantComboBox = new System.Windows.Forms.ComboBox();
            this.totalLLabel = new System.Windows.Forms.Label();
            this.prixLLabel = new System.Windows.Forms.Label();
            this.specialiteLabel = new System.Windows.Forms.Label();
            this.restaurantLabel = new System.Windows.Forms.Label();
            this.transactionMenuStrip = new System.Windows.Forms.MenuStrip();
            this.transactionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.restauPictureBox)).BeginInit();
            this.infoGroupBox.SuspendLayout();
            this.reservationGroupBox.SuspendLayout();
            this.transactionMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passez vos réservations. 😊";
            // 
            // restauPictureBox
            // 
            this.restauPictureBox.Image = global::RestauManager.Properties.Resources.Chinese;
            this.restauPictureBox.Location = new System.Drawing.Point(46, 66);
            this.restauPictureBox.Name = "restauPictureBox";
            this.restauPictureBox.Size = new System.Drawing.Size(456, 234);
            this.restauPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restauPictureBox.TabIndex = 1;
            this.restauPictureBox.TabStop = false;
            // 
            // infoGroupBox
            // 
            this.infoGroupBox.Controls.Add(this.dateTextBox);
            this.infoGroupBox.Controls.Add(this.nomTextBox);
            this.infoGroupBox.Controls.Add(this.dateLabel);
            this.infoGroupBox.Controls.Add(this.nomLabel);
            this.infoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGroupBox.Location = new System.Drawing.Point(46, 325);
            this.infoGroupBox.Name = "infoGroupBox";
            this.infoGroupBox.Size = new System.Drawing.Size(456, 144);
            this.infoGroupBox.TabIndex = 2;
            this.infoGroupBox.TabStop = false;
            this.infoGroupBox.Text = "Information du Cuisinomane";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(108, 86);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(285, 24);
            this.dateTextBox.TabIndex = 3;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(108, 35);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(285, 24);
            this.nomTextBox.TabIndex = 2;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(7, 89);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(39, 18);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(7, 42);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(41, 18);
            this.nomLabel.TabIndex = 0;
            this.nomLabel.Text = "Nom";
            // 
            // reservationGroupBox
            // 
            this.reservationGroupBox.Controls.Add(this.totalLabel);
            this.reservationGroupBox.Controls.Add(this.prixLabel);
            this.reservationGroupBox.Controls.Add(this.specialiteComboBox);
            this.reservationGroupBox.Controls.Add(this.restaurantComboBox);
            this.reservationGroupBox.Controls.Add(this.totalLLabel);
            this.reservationGroupBox.Controls.Add(this.prixLLabel);
            this.reservationGroupBox.Controls.Add(this.specialiteLabel);
            this.reservationGroupBox.Controls.Add(this.restaurantLabel);
            this.reservationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationGroupBox.Location = new System.Drawing.Point(46, 490);
            this.reservationGroupBox.Name = "reservationGroupBox";
            this.reservationGroupBox.Size = new System.Drawing.Size(456, 233);
            this.reservationGroupBox.TabIndex = 3;
            this.reservationGroupBox.TabStop = false;
            this.reservationGroupBox.Text = "Réservation";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(111, 179);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(138, 26);
            this.totalLabel.TabIndex = 11;
            // 
            // prixLabel
            // 
            this.prixLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.prixLabel.Location = new System.Drawing.Point(108, 126);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(142, 26);
            this.prixLabel.TabIndex = 10;
            // 
            // specialiteComboBox
            // 
            this.specialiteComboBox.FormattingEnabled = true;
            this.specialiteComboBox.Location = new System.Drawing.Point(108, 72);
            this.specialiteComboBox.Name = "specialiteComboBox";
            this.specialiteComboBox.Size = new System.Drawing.Size(285, 26);
            this.specialiteComboBox.TabIndex = 9;
            this.specialiteComboBox.SelectedIndexChanged += new System.EventHandler(this.specialiteComboBox_SelectedIndexChanged);
            // 
            // restaurantComboBox
            // 
            this.restaurantComboBox.FormattingEnabled = true;
            this.restaurantComboBox.Location = new System.Drawing.Point(108, 22);
            this.restaurantComboBox.Name = "restaurantComboBox";
            this.restaurantComboBox.Size = new System.Drawing.Size(285, 26);
            this.restaurantComboBox.TabIndex = 8;
            // 
            // totalLLabel
            // 
            this.totalLLabel.AutoSize = true;
            this.totalLLabel.Location = new System.Drawing.Point(10, 179);
            this.totalLLabel.Name = "totalLLabel";
            this.totalLLabel.Size = new System.Drawing.Size(41, 18);
            this.totalLLabel.TabIndex = 6;
            this.totalLLabel.Text = "Total";
            // 
            // prixLLabel
            // 
            this.prixLLabel.AutoSize = true;
            this.prixLLabel.Location = new System.Drawing.Point(10, 126);
            this.prixLLabel.Name = "prixLLabel";
            this.prixLLabel.Size = new System.Drawing.Size(33, 18);
            this.prixLLabel.TabIndex = 4;
            this.prixLLabel.Text = "Prix";
            // 
            // specialiteLabel
            // 
            this.specialiteLabel.AutoSize = true;
            this.specialiteLabel.Location = new System.Drawing.Point(10, 72);
            this.specialiteLabel.Name = "specialiteLabel";
            this.specialiteLabel.Size = new System.Drawing.Size(71, 18);
            this.specialiteLabel.TabIndex = 2;
            this.specialiteLabel.Text = "Specialité";
            // 
            // restaurantLabel
            // 
            this.restaurantLabel.AutoSize = true;
            this.restaurantLabel.Location = new System.Drawing.Point(10, 25);
            this.restaurantLabel.Name = "restaurantLabel";
            this.restaurantLabel.Size = new System.Drawing.Size(80, 18);
            this.restaurantLabel.TabIndex = 0;
            this.restaurantLabel.Text = "Restaurant";
            // 
            // transactionMenuStrip
            // 
            this.transactionMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.transactionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionFileToolStripMenuItem});
            this.transactionMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.transactionMenuStrip.Name = "transactionMenuStrip";
            this.transactionMenuStrip.Size = new System.Drawing.Size(546, 28);
            this.transactionMenuStrip.TabIndex = 4;
            this.transactionMenuStrip.Text = "menuStrip1";
            // 
            // transactionFileToolStripMenuItem
            // 
            this.transactionFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.imprimerToolStripMenuItem});
            this.transactionFileToolStripMenuItem.Name = "transactionFileToolStripMenuItem";
            this.transactionFileToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.transactionFileToolStripMenuItem.Text = "&Transaction";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
            this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
            this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.imprimerToolStripMenuItem.Text = "&Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // RestauManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(546, 780);
            this.Controls.Add(this.reservationGroupBox);
            this.Controls.Add(this.infoGroupBox);
            this.Controls.Add(this.restauPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transactionMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.transactionMenuStrip;
            this.Name = "RestauManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation chez RestauManager";
            this.Load += new System.EventHandler(this.RestauManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restauPictureBox)).EndInit();
            this.infoGroupBox.ResumeLayout(false);
            this.infoGroupBox.PerformLayout();
            this.reservationGroupBox.ResumeLayout(false);
            this.reservationGroupBox.PerformLayout();
            this.transactionMenuStrip.ResumeLayout(false);
            this.transactionMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox restauPictureBox;
        private System.Windows.Forms.GroupBox infoGroupBox;
        private System.Windows.Forms.GroupBox reservationGroupBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label totalLLabel;
        private System.Windows.Forms.Label prixLLabel;
        private System.Windows.Forms.Label specialiteLabel;
        private System.Windows.Forms.Label restaurantLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label prixLabel;
        private System.Windows.Forms.ComboBox specialiteComboBox;
        private System.Windows.Forms.ComboBox restaurantComboBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.MenuStrip transactionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem transactionFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
    }
}

