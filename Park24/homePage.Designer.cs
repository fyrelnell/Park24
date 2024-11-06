using System.Drawing;
using System.Windows.Forms;

namespace Park24
{
    partial class Form22
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
            this.button1 = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.status_Button = new System.Windows.Forms.Button();
            this.info_Button = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aracKayit_Buton = new System.Windows.Forms.Button();
            this.aracDuzenle_Buton = new System.Windows.Forms.Button();
            this.aracCikis_Buton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1617, 78);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Otopark Otomasyonu";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // exit_Button
            // 
            this.exit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_Button.BackColor = System.Drawing.Color.Crimson;
            this.exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_Button.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit_Button.Location = new System.Drawing.Point(1567, 19);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(35, 40);
            this.exit_Button.TabIndex = 7;
            this.exit_Button.TabStop = false;
            this.exit_Button.Text = "X";
            this.exit_Button.UseVisualStyleBackColor = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // status_Button
            // 
            this.status_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.status_Button.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.status_Button.Location = new System.Drawing.Point(12, 360);
            this.status_Button.Name = "status_Button";
            this.status_Button.Size = new System.Drawing.Size(243, 70);
            this.status_Button.TabIndex = 2;
            this.status_Button.Text = "Otopark Durumu";
            this.status_Button.UseVisualStyleBackColor = true;
            this.status_Button.Click += new System.EventHandler(this.status_Button_Click);
            // 
            // info_Button
            // 
            this.info_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_Button.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.info_Button.Location = new System.Drawing.Point(12, 180);
            this.info_Button.Name = "info_Button";
            this.info_Button.Size = new System.Drawing.Size(243, 70);
            this.info_Button.TabIndex = 1;
            this.info_Button.Text = "Otopark Bilgileri";
            this.info_Button.UseVisualStyleBackColor = true;
            this.info_Button.Click += new System.EventHandler(this.info_Button_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Corbel", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(12, 540);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(243, 70);
            this.button6.TabIndex = 3;
            this.button6.Text = "Eski Kayıtlar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(300, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 540);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // aracKayit_Buton
            // 
            this.aracKayit_Buton.BackColor = System.Drawing.Color.Green;
            this.aracKayit_Buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aracKayit_Buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aracKayit_Buton.FlatAppearance.BorderSize = 0;
            this.aracKayit_Buton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracKayit_Buton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aracKayit_Buton.Location = new System.Drawing.Point(1434, 254);
            this.aracKayit_Buton.Name = "aracKayit_Buton";
            this.aracKayit_Buton.Size = new System.Drawing.Size(171, 71);
            this.aracKayit_Buton.TabIndex = 16;
            this.aracKayit_Buton.Text = "Araç Kayıt";
            this.aracKayit_Buton.UseVisualStyleBackColor = false;
            this.aracKayit_Buton.Visible = false;
            this.aracKayit_Buton.Click += new System.EventHandler(this.aracKayit_Buton_Click);
            // 
            // aracDuzenle_Buton
            // 
            this.aracDuzenle_Buton.BackColor = System.Drawing.Color.Goldenrod;
            this.aracDuzenle_Buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aracDuzenle_Buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aracDuzenle_Buton.FlatAppearance.BorderSize = 0;
            this.aracDuzenle_Buton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracDuzenle_Buton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aracDuzenle_Buton.Location = new System.Drawing.Point(1434, 377);
            this.aracDuzenle_Buton.Name = "aracDuzenle_Buton";
            this.aracDuzenle_Buton.Size = new System.Drawing.Size(171, 71);
            this.aracDuzenle_Buton.TabIndex = 17;
            this.aracDuzenle_Buton.Text = "Düzenle";
            this.aracDuzenle_Buton.UseVisualStyleBackColor = false;
            this.aracDuzenle_Buton.Visible = false;
            this.aracDuzenle_Buton.Click += new System.EventHandler(this.aracDuzenle_Buton_Click);
            // 
            // aracCikis_Buton
            // 
            this.aracCikis_Buton.BackColor = System.Drawing.Color.Brown;
            this.aracCikis_Buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.aracCikis_Buton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aracCikis_Buton.FlatAppearance.BorderSize = 0;
            this.aracCikis_Buton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracCikis_Buton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.aracCikis_Buton.Location = new System.Drawing.Point(1434, 500);
            this.aracCikis_Buton.Name = "aracCikis_Buton";
            this.aracCikis_Buton.Size = new System.Drawing.Size(171, 71);
            this.aracCikis_Buton.TabIndex = 17;
            this.aracCikis_Buton.Text = "Araç Çıkış";
            this.aracCikis_Buton.UseVisualStyleBackColor = false;
            this.aracCikis_Buton.Visible = false;
            this.aracCikis_Buton.Click += new System.EventHandler(this.aracCikis_Buton_Click);
            // 
            // Form22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1617, 802);
            this.ControlBox = false;
            this.Controls.Add(this.aracCikis_Buton);
            this.Controls.Add(this.aracDuzenle_Buton);
            this.Controls.Add(this.aracKayit_Buton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.info_Button);
            this.Controls.Add(this.status_Button);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(1619, 804);
            this.Name = "Form22";
            this.Load += new System.EventHandler(this.Form22_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button status_Button;
        private System.Windows.Forms.Button info_Button;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private Button aracKayit_Buton;
        private Button aracDuzenle_Buton;
        private Button aracCikis_Buton;
    }
}