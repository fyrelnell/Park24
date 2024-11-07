using System.Drawing;
using System.Windows.Forms;

namespace Park24
{
    partial class homePageForm
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
            this.headerLineButton = new System.Windows.Forms.Button();
            this.appExitButton = new System.Windows.Forms.Button();
            this.parkStatusButton = new System.Windows.Forms.Button();
            this.parkInfoButton = new System.Windows.Forms.Button();
            this.logListButton = new System.Windows.Forms.Button();
            this.contentPanel1 = new System.Windows.Forms.Panel();
            this.carRegisterButton = new System.Windows.Forms.Button();
            this.carEditButton = new System.Windows.Forms.Button();
            this.carExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLineButton
            // 
            this.headerLineButton.BackColor = System.Drawing.Color.Goldenrod;
            this.headerLineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.headerLineButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLineButton.FlatAppearance.BorderSize = 0;
            this.headerLineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.headerLineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.headerLineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLineButton.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLineButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.headerLineButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.headerLineButton.Location = new System.Drawing.Point(0, 0);
            this.headerLineButton.Name = "headerLineButton";
            this.headerLineButton.Size = new System.Drawing.Size(1617, 78);
            this.headerLineButton.TabIndex = 0;
            this.headerLineButton.TabStop = false;
            this.headerLineButton.Text = "Otopark Otomasyonu";
            this.headerLineButton.UseVisualStyleBackColor = false;
            // 
            // appExitButton
            // 
            this.appExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appExitButton.BackColor = System.Drawing.Color.Crimson;
            this.appExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appExitButton.Location = new System.Drawing.Point(1567, 19);
            this.appExitButton.Name = "appExitButton";
            this.appExitButton.Size = new System.Drawing.Size(35, 40);
            this.appExitButton.TabIndex = 7;
            this.appExitButton.TabStop = false;
            this.appExitButton.Text = "X";
            this.appExitButton.UseVisualStyleBackColor = false;
            this.appExitButton.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // parkStatusButton
            // 
            this.parkStatusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkStatusButton.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parkStatusButton.Location = new System.Drawing.Point(12, 360);
            this.parkStatusButton.Name = "parkStatusButton";
            this.parkStatusButton.Size = new System.Drawing.Size(243, 70);
            this.parkStatusButton.TabIndex = 2;
            this.parkStatusButton.Text = "Otopark Durumu";
            this.parkStatusButton.UseVisualStyleBackColor = true;
            this.parkStatusButton.Click += new System.EventHandler(this.status_Button_Click);
            // 
            // parkInfoButton
            // 
            this.parkInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkInfoButton.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parkInfoButton.Location = new System.Drawing.Point(12, 180);
            this.parkInfoButton.Name = "parkInfoButton";
            this.parkInfoButton.Size = new System.Drawing.Size(243, 70);
            this.parkInfoButton.TabIndex = 1;
            this.parkInfoButton.Text = "Otopark Bilgileri";
            this.parkInfoButton.UseVisualStyleBackColor = true;
            this.parkInfoButton.Click += new System.EventHandler(this.info_Button_Click);
            // 
            // logListButton
            // 
            this.logListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logListButton.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logListButton.Location = new System.Drawing.Point(12, 540);
            this.logListButton.Name = "logListButton";
            this.logListButton.Size = new System.Drawing.Size(243, 70);
            this.logListButton.TabIndex = 3;
            this.logListButton.Text = "Eski Kayıtlar";
            this.logListButton.UseVisualStyleBackColor = true;
            this.logListButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // contentPanel1
            // 
            this.contentPanel1.Location = new System.Drawing.Point(300, 157);
            this.contentPanel1.Name = "contentPanel1";
            this.contentPanel1.Size = new System.Drawing.Size(1108, 540);
            this.contentPanel1.TabIndex = 12;
            this.contentPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // carRegisterButton
            // 
            this.carRegisterButton.BackColor = System.Drawing.Color.Green;
            this.carRegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.carRegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carRegisterButton.FlatAppearance.BorderSize = 0;
            this.carRegisterButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carRegisterButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.carRegisterButton.Location = new System.Drawing.Point(1434, 254);
            this.carRegisterButton.Name = "carRegisterButton";
            this.carRegisterButton.Size = new System.Drawing.Size(171, 71);
            this.carRegisterButton.TabIndex = 16;
            this.carRegisterButton.Text = "Araç Kayıt";
            this.carRegisterButton.UseVisualStyleBackColor = false;
            this.carRegisterButton.Visible = false;
            this.carRegisterButton.Click += new System.EventHandler(this.aracKayit_Buton_Click);
            // 
            // carEditButton
            // 
            this.carEditButton.BackColor = System.Drawing.Color.Goldenrod;
            this.carEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.carEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carEditButton.FlatAppearance.BorderSize = 0;
            this.carEditButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carEditButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.carEditButton.Location = new System.Drawing.Point(1434, 377);
            this.carEditButton.Name = "carEditButton";
            this.carEditButton.Size = new System.Drawing.Size(171, 71);
            this.carEditButton.TabIndex = 17;
            this.carEditButton.Text = "Düzenle";
            this.carEditButton.UseVisualStyleBackColor = false;
            this.carEditButton.Visible = false;
            this.carEditButton.Click += new System.EventHandler(this.aracDuzenle_Buton_Click);
            // 
            // carExitButton
            // 
            this.carExitButton.BackColor = System.Drawing.Color.Brown;
            this.carExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.carExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carExitButton.FlatAppearance.BorderSize = 0;
            this.carExitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carExitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.carExitButton.Location = new System.Drawing.Point(1434, 500);
            this.carExitButton.Name = "carExitButton";
            this.carExitButton.Size = new System.Drawing.Size(171, 71);
            this.carExitButton.TabIndex = 17;
            this.carExitButton.Text = "Araç Çıkış";
            this.carExitButton.UseVisualStyleBackColor = false;
            this.carExitButton.Visible = false;
            this.carExitButton.Click += new System.EventHandler(this.aracCikis_Buton_Click);
            // 
            // homePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1617, 802);
            this.ControlBox = false;
            this.Controls.Add(this.carExitButton);
            this.Controls.Add(this.carEditButton);
            this.Controls.Add(this.carRegisterButton);
            this.Controls.Add(this.contentPanel1);
            this.Controls.Add(this.logListButton);
            this.Controls.Add(this.parkInfoButton);
            this.Controls.Add(this.parkStatusButton);
            this.Controls.Add(this.appExitButton);
            this.Controls.Add(this.headerLineButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(1619, 804);
            this.Name = "homePageForm";
            this.Load += new System.EventHandler(this.Form22_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button headerLineButton;
        private System.Windows.Forms.Button appExitButton;
        private System.Windows.Forms.Button parkStatusButton;
        private System.Windows.Forms.Button parkInfoButton;
        private System.Windows.Forms.Button logListButton;
        private System.Windows.Forms.Panel contentPanel1;
        private Button carRegisterButton;
        private Button carEditButton;
        private Button carExitButton;
    }
}