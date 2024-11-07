using System.Windows.Forms;
using System;

namespace Park24
{
    partial class loginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.headerLineButton = new System.Windows.Forms.Button();
            this.appExitButton = new System.Windows.Forms.Button();
            this.usernameTBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.Park24_ImageButton = new System.Windows.Forms.Button();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLineButton
            // 
            this.headerLineButton.BackColor = System.Drawing.Color.Goldenrod;
            this.headerLineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.headerLineButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLineButton.FlatAppearance.BorderSize = 0;
            this.headerLineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headerLineButton.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLineButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.headerLineButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.headerLineButton.Location = new System.Drawing.Point(0, 0);
            this.headerLineButton.Name = "headerLineButton";
            this.headerLineButton.Size = new System.Drawing.Size(1617, 78);
            this.headerLineButton.TabIndex = 0;
            this.headerLineButton.TabStop = false;
            this.headerLineButton.Text = "Otopark Otomasyonu Giriş Ekranı";
            this.headerLineButton.UseVisualStyleBackColor = false;
            this.headerLineButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // appExitButton
            // 
            this.appExitButton.BackColor = System.Drawing.Color.Crimson;
            this.appExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appExitButton.Location = new System.Drawing.Point(1567, 19);
            this.appExitButton.Name = "appExitButton";
            this.appExitButton.Size = new System.Drawing.Size(35, 40);
            this.appExitButton.TabIndex = 1;
            this.appExitButton.TabStop = false;
            this.appExitButton.Text = "X";
            this.appExitButton.UseVisualStyleBackColor = false;
            this.appExitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // usernameTBox
            // 
            this.usernameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTBox.Location = new System.Drawing.Point(680, 411);
            this.usernameTBox.MaxLength = 32;
            this.usernameTBox.Name = "usernameTBox";
            this.usernameTBox.Size = new System.Drawing.Size(215, 28);
            this.usernameTBox.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.Location = new System.Drawing.Point(710, 528);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(156, 42);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // passwordTBox
            // 
            this.passwordTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTBox.Location = new System.Drawing.Point(680, 456);
            this.passwordTBox.MaxLength = 32;
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.PasswordChar = '*';
            this.passwordTBox.Size = new System.Drawing.Size(215, 28);
            this.passwordTBox.TabIndex = 1;
            // 
            // Park24_ImageButton
            // 
            this.Park24_ImageButton.BackColor = System.Drawing.Color.Transparent;
            this.Park24_ImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Park24_ImageButton.BackgroundImage")));
            this.Park24_ImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Park24_ImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Park24_ImageButton.Location = new System.Drawing.Point(680, 183);
            this.Park24_ImageButton.Name = "Park24_ImageButton";
            this.Park24_ImageButton.Size = new System.Drawing.Size(215, 190);
            this.Park24_ImageButton.TabIndex = 3;
            this.Park24_ImageButton.TabStop = false;
            this.Park24_ImageButton.UseVisualStyleBackColor = false;
            // 
            // dateLabel1
            // 
            this.dateLabel1.AutoSize = true;
            this.dateLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateLabel1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateLabel1.Location = new System.Drawing.Point(1530, 78);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.dateLabel1.Size = new System.Drawing.Size(87, 49);
            this.dateLabel1.TabIndex = 4;
            this.dateLabel1.Text = "tarih";
            this.dateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1617, 802);
            this.ControlBox = false;
            this.Controls.Add(this.dateLabel1);
            this.Controls.Add(this.Park24_ImageButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTBox);
            this.Controls.Add(this.usernameTBox);
            this.Controls.Add(this.appExitButton);
            this.Controls.Add(this.headerLineButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.giris_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button headerLineButton;
        private System.Windows.Forms.Button appExitButton;
        private System.Windows.Forms.TextBox usernameTBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTBox;
        private Button Park24_ImageButton;
        private Label dateLabel1;
    }
}

