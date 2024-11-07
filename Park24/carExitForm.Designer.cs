using System.Drawing;
using System.Windows.Forms;

namespace Park24
{
    partial class carExitForm
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
            this.plateLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.carInfoGBox = new System.Windows.Forms.GroupBox();
            this.parknoLabel2 = new System.Windows.Forms.Label();
            this.parknoLabel1 = new System.Windows.Forms.Label();
            this.modelTBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.brandTBox = new System.Windows.Forms.TextBox();
            this.plateTBox = new System.Windows.Forms.TextBox();
            this.headLabel = new System.Windows.Forms.Label();
            this.customerInfoGBox = new System.Windows.Forms.GroupBox();
            this.phoneTBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.surnTBox = new System.Windows.Forms.TextBox();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.surnLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.carExitButton = new System.Windows.Forms.Button();
            this.registerInfoGBox = new System.Windows.Forms.GroupBox();
            this.timeLabel2 = new System.Windows.Forms.Label();
            this.feeLabel2 = new System.Windows.Forms.Label();
            this.registrarLabel2 = new System.Windows.Forms.Label();
            this.entryTimeLabel2 = new System.Windows.Forms.Label();
            this.entryDateLabel2 = new System.Windows.Forms.Label();
            this.feeLabel1 = new System.Windows.Forms.Label();
            this.timeLabel1 = new System.Windows.Forms.Label();
            this.entryTimeLabel1 = new System.Windows.Forms.Label();
            this.registrarLabel1 = new System.Windows.Forms.Label();
            this.entryDateLabel1 = new System.Windows.Forms.Label();
            this.carInfoGBox.SuspendLayout();
            this.customerInfoGBox.SuspendLayout();
            this.registerInfoGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // plateLabel
            // 
            this.plateLabel.AutoSize = true;
            this.plateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plateLabel.Location = new System.Drawing.Point(76, 52);
            this.plateLabel.Name = "plateLabel";
            this.plateLabel.Size = new System.Drawing.Size(112, 24);
            this.plateLabel.TabIndex = 0;
            this.plateLabel.Text = "Araç Plakası";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandLabel.Location = new System.Drawing.Point(69, 97);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(118, 24);
            this.brandLabel.TabIndex = 1;
            this.brandLabel.Text = "Araç Markası";
            // 
            // carInfoGBox
            // 
            this.carInfoGBox.Controls.Add(this.parknoLabel2);
            this.carInfoGBox.Controls.Add(this.parknoLabel1);
            this.carInfoGBox.Controls.Add(this.modelTBox);
            this.carInfoGBox.Controls.Add(this.modelLabel);
            this.carInfoGBox.Controls.Add(this.brandTBox);
            this.carInfoGBox.Controls.Add(this.plateTBox);
            this.carInfoGBox.Controls.Add(this.brandLabel);
            this.carInfoGBox.Controls.Add(this.plateLabel);
            this.carInfoGBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carInfoGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carInfoGBox.ForeColor = System.Drawing.Color.Black;
            this.carInfoGBox.Location = new System.Drawing.Point(25, 88);
            this.carInfoGBox.Name = "carInfoGBox";
            this.carInfoGBox.Size = new System.Drawing.Size(528, 247);
            this.carInfoGBox.TabIndex = 2;
            this.carInfoGBox.TabStop = false;
            this.carInfoGBox.Text = "Araç Bilgileri";
            this.carInfoGBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // parknoLabel2
            // 
            this.parknoLabel2.AutoSize = true;
            this.parknoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parknoLabel2.Location = new System.Drawing.Point(212, 205);
            this.parknoLabel2.Name = "parknoLabel2";
            this.parknoLabel2.Size = new System.Drawing.Size(82, 25);
            this.parknoLabel2.TabIndex = 8;
            this.parknoLabel2.Text = "Park No";
            // 
            // parknoLabel1
            // 
            this.parknoLabel1.AutoSize = true;
            this.parknoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parknoLabel1.Location = new System.Drawing.Point(116, 205);
            this.parknoLabel1.Name = "parknoLabel1";
            this.parknoLabel1.Size = new System.Drawing.Size(92, 24);
            this.parknoLabel1.TabIndex = 6;
            this.parknoLabel1.Text = "Park No : ";
            // 
            // modelTBox
            // 
            this.modelTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.modelTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelTBox.ForeColor = System.Drawing.Color.Black;
            this.modelTBox.Location = new System.Drawing.Point(216, 141);
            this.modelTBox.Name = "modelTBox";
            this.modelTBox.ReadOnly = true;
            this.modelTBox.Size = new System.Drawing.Size(195, 28);
            this.modelTBox.TabIndex = 5;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelLabel.Location = new System.Drawing.Point(82, 142);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(111, 24);
            this.modelLabel.TabIndex = 4;
            this.modelLabel.Text = "Araç Modeli";
            // 
            // brandTBox
            // 
            this.brandTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.brandTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brandTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandTBox.ForeColor = System.Drawing.Color.Black;
            this.brandTBox.Location = new System.Drawing.Point(216, 96);
            this.brandTBox.Name = "brandTBox";
            this.brandTBox.ReadOnly = true;
            this.brandTBox.Size = new System.Drawing.Size(195, 28);
            this.brandTBox.TabIndex = 3;
            // 
            // plateTBox
            // 
            this.plateTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.plateTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plateTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plateTBox.ForeColor = System.Drawing.Color.Black;
            this.plateTBox.Location = new System.Drawing.Point(216, 51);
            this.plateTBox.Name = "plateTBox";
            this.plateTBox.ReadOnly = true;
            this.plateTBox.Size = new System.Drawing.Size(195, 28);
            this.plateTBox.TabIndex = 2;
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headLabel.Location = new System.Drawing.Point(467, 19);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(220, 33);
            this.headLabel.TabIndex = 3;
            this.headLabel.Text = "Araç Çıkış Formu";
            // 
            // customerInfoGBox
            // 
            this.customerInfoGBox.Controls.Add(this.phoneTBox);
            this.customerInfoGBox.Controls.Add(this.phoneLabel);
            this.customerInfoGBox.Controls.Add(this.surnTBox);
            this.customerInfoGBox.Controls.Add(this.nameTBox);
            this.customerInfoGBox.Controls.Add(this.surnLabel);
            this.customerInfoGBox.Controls.Add(this.nameLabel);
            this.customerInfoGBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerInfoGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerInfoGBox.ForeColor = System.Drawing.Color.Black;
            this.customerInfoGBox.Location = new System.Drawing.Point(607, 88);
            this.customerInfoGBox.Name = "customerInfoGBox";
            this.customerInfoGBox.Size = new System.Drawing.Size(528, 247);
            this.customerInfoGBox.TabIndex = 6;
            this.customerInfoGBox.TabStop = false;
            this.customerInfoGBox.Text = "Müşteri Bilgileri";
            this.customerInfoGBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // phoneTBox
            // 
            this.phoneTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.phoneTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneTBox.ForeColor = System.Drawing.Color.Black;
            this.phoneTBox.Location = new System.Drawing.Point(216, 145);
            this.phoneTBox.Name = "phoneTBox";
            this.phoneTBox.ReadOnly = true;
            this.phoneTBox.Size = new System.Drawing.Size(195, 28);
            this.phoneTBox.TabIndex = 5;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneLabel.Location = new System.Drawing.Point(87, 146);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(109, 24);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Telefon No.";
            // 
            // surnTBox
            // 
            this.surnTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.surnTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnTBox.ForeColor = System.Drawing.Color.Black;
            this.surnTBox.Location = new System.Drawing.Point(216, 100);
            this.surnTBox.Name = "surnTBox";
            this.surnTBox.ReadOnly = true;
            this.surnTBox.Size = new System.Drawing.Size(195, 28);
            this.surnTBox.TabIndex = 3;
            // 
            // nameTBox
            // 
            this.nameTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.nameTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTBox.ForeColor = System.Drawing.Color.Black;
            this.nameTBox.Location = new System.Drawing.Point(216, 55);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.ReadOnly = true;
            this.nameTBox.Size = new System.Drawing.Size(195, 28);
            this.nameTBox.TabIndex = 2;
            // 
            // surnLabel
            // 
            this.surnLabel.AutoSize = true;
            this.surnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnLabel.Location = new System.Drawing.Point(135, 101);
            this.surnLabel.Name = "surnLabel";
            this.surnLabel.Size = new System.Drawing.Size(63, 24);
            this.surnLabel.TabIndex = 1;
            this.surnLabel.Text = "Soyad";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(164, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(34, 24);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Ad";
            // 
            // carExitButton
            // 
            this.carExitButton.BackColor = System.Drawing.Color.IndianRed;
            this.carExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.carExitButton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carExitButton.Location = new System.Drawing.Point(488, 674);
            this.carExitButton.Name = "carExitButton";
            this.carExitButton.Size = new System.Drawing.Size(189, 59);
            this.carExitButton.TabIndex = 8;
            this.carExitButton.Text = "Araç Çıkışı Yap";
            this.carExitButton.UseVisualStyleBackColor = false;
            this.carExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerInfoGBox
            // 
            this.registerInfoGBox.Controls.Add(this.timeLabel2);
            this.registerInfoGBox.Controls.Add(this.feeLabel2);
            this.registerInfoGBox.Controls.Add(this.registrarLabel2);
            this.registerInfoGBox.Controls.Add(this.entryTimeLabel2);
            this.registerInfoGBox.Controls.Add(this.entryDateLabel2);
            this.registerInfoGBox.Controls.Add(this.feeLabel1);
            this.registerInfoGBox.Controls.Add(this.timeLabel1);
            this.registerInfoGBox.Controls.Add(this.entryTimeLabel1);
            this.registerInfoGBox.Controls.Add(this.registrarLabel1);
            this.registerInfoGBox.Controls.Add(this.entryDateLabel1);
            this.registerInfoGBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerInfoGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerInfoGBox.ForeColor = System.Drawing.Color.Black;
            this.registerInfoGBox.Location = new System.Drawing.Point(241, 385);
            this.registerInfoGBox.Name = "registerInfoGBox";
            this.registerInfoGBox.Size = new System.Drawing.Size(663, 223);
            this.registerInfoGBox.TabIndex = 7;
            this.registerInfoGBox.TabStop = false;
            this.registerInfoGBox.Text = "Kayıt Bilgileri";
            // 
            // timeLabel2
            // 
            this.timeLabel2.AutoSize = true;
            this.timeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel2.Location = new System.Drawing.Point(499, 56);
            this.timeLabel2.Name = "timeLabel2";
            this.timeLabel2.Size = new System.Drawing.Size(27, 25);
            this.timeLabel2.TabIndex = 6;
            this.timeLabel2.Text = "...";
            // 
            // feeLabel2
            // 
            this.feeLabel2.AutoSize = true;
            this.feeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feeLabel2.Location = new System.Drawing.Point(499, 158);
            this.feeLabel2.Name = "feeLabel2";
            this.feeLabel2.Size = new System.Drawing.Size(27, 25);
            this.feeLabel2.TabIndex = 6;
            this.feeLabel2.Text = "...";
            // 
            // registrarLabel2
            // 
            this.registrarLabel2.AutoSize = true;
            this.registrarLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registrarLabel2.Location = new System.Drawing.Point(183, 158);
            this.registrarLabel2.Name = "registrarLabel2";
            this.registrarLabel2.Size = new System.Drawing.Size(27, 25);
            this.registrarLabel2.TabIndex = 6;
            this.registrarLabel2.Text = "...";
            // 
            // entryTimeLabel2
            // 
            this.entryTimeLabel2.AutoSize = true;
            this.entryTimeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entryTimeLabel2.Location = new System.Drawing.Point(183, 95);
            this.entryTimeLabel2.Name = "entryTimeLabel2";
            this.entryTimeLabel2.Size = new System.Drawing.Size(25, 24);
            this.entryTimeLabel2.TabIndex = 6;
            this.entryTimeLabel2.Text = "...";
            // 
            // entryDateLabel2
            // 
            this.entryDateLabel2.AutoSize = true;
            this.entryDateLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entryDateLabel2.Location = new System.Drawing.Point(183, 56);
            this.entryDateLabel2.Name = "entryDateLabel2";
            this.entryDateLabel2.Size = new System.Drawing.Size(25, 24);
            this.entryDateLabel2.TabIndex = 6;
            this.entryDateLabel2.Text = "...";
            // 
            // feeLabel1
            // 
            this.feeLabel1.AutoSize = true;
            this.feeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.feeLabel1.Location = new System.Drawing.Point(420, 158);
            this.feeLabel1.Name = "feeLabel1";
            this.feeLabel1.Size = new System.Drawing.Size(69, 24);
            this.feeLabel1.TabIndex = 5;
            this.feeLabel1.Text = "Ücret : ";
            // 
            // timeLabel1
            // 
            this.timeLabel1.AutoSize = true;
            this.timeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel1.Location = new System.Drawing.Point(426, 56);
            this.timeLabel1.Name = "timeLabel1";
            this.timeLabel1.Size = new System.Drawing.Size(65, 24);
            this.timeLabel1.TabIndex = 4;
            this.timeLabel1.Text = "Süre : ";
            // 
            // entryTimeLabel1
            // 
            this.entryTimeLabel1.AutoSize = true;
            this.entryTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entryTimeLabel1.Location = new System.Drawing.Point(56, 95);
            this.entryTimeLabel1.Name = "entryTimeLabel1";
            this.entryTimeLabel1.Size = new System.Drawing.Size(107, 24);
            this.entryTimeLabel1.TabIndex = 0;
            this.entryTimeLabel1.Text = "Giriş Saati : ";
            // 
            // registrarLabel1
            // 
            this.registrarLabel1.AutoSize = true;
            this.registrarLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registrarLabel1.Location = new System.Drawing.Point(18, 158);
            this.registrarLabel1.Name = "registrarLabel1";
            this.registrarLabel1.Size = new System.Drawing.Size(141, 24);
            this.registrarLabel1.TabIndex = 1;
            this.registrarLabel1.Text = "Kayıt Görevlisi : ";
            // 
            // entryDateLabel1
            // 
            this.entryDateLabel1.AutoSize = true;
            this.entryDateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.entryDateLabel1.Location = new System.Drawing.Point(47, 56);
            this.entryDateLabel1.Name = "entryDateLabel1";
            this.entryDateLabel1.Size = new System.Drawing.Size(114, 24);
            this.entryDateLabel1.TabIndex = 0;
            this.entryDateLabel1.Text = "Giriş Tarihi : ";
            // 
            // carExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1160, 777);
            this.Controls.Add(this.registerInfoGBox);
            this.Controls.Add(this.carExitButton);
            this.Controls.Add(this.customerInfoGBox);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.carInfoGBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "carExitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Çıkış";
            this.Load += new System.EventHandler(this.carExitForm_Load);
            this.carInfoGBox.ResumeLayout(false);
            this.carInfoGBox.PerformLayout();
            this.customerInfoGBox.ResumeLayout(false);
            this.customerInfoGBox.PerformLayout();
            this.registerInfoGBox.ResumeLayout(false);
            this.registerInfoGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label plateLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.GroupBox carInfoGBox;
        private System.Windows.Forms.Label headLabel;
        private TextBox brandTBox;
        private TextBox plateTBox;
        private TextBox modelTBox;
        private Label modelLabel;
        private GroupBox customerInfoGBox;
        private TextBox phoneTBox;
        private Label phoneLabel;
        private TextBox surnTBox;
        private TextBox nameTBox;
        private Label surnLabel;
        private Label nameLabel;
        private Label parknoLabel1;
        private Button carExitButton;
        private GroupBox registerInfoGBox;
        private Label timeLabel2;
        private Label feeLabel2;
        private Label registrarLabel2;
        private Label entryDateLabel2;
        private Label feeLabel1;
        private Label timeLabel1;
        private Label registrarLabel1;
        private Label entryDateLabel1;
        private Label parknoLabel2;
        private Label entryTimeLabel2;
        private Label entryTimeLabel1;
    }
}