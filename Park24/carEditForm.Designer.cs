using System.Drawing;
using System.Windows.Forms;

namespace Park24
{
    partial class carEditForm
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
            this.parknoCBox = new System.Windows.Forms.ComboBox();
            this.parknoLabel = new System.Windows.Forms.Label();
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
            this.arackayitOK = new System.Windows.Forms.Button();
            this.carInfoGBox.SuspendLayout();
            this.customerInfoGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // plateLabel
            // 
            this.plateLabel.AutoSize = true;
            this.plateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plateLabel.Location = new System.Drawing.Point(76, 56);
            this.plateLabel.Name = "plateLabel";
            this.plateLabel.Size = new System.Drawing.Size(112, 24);
            this.plateLabel.TabIndex = 0;
            this.plateLabel.Text = "Araç Plakası";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandLabel.Location = new System.Drawing.Point(69, 101);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(118, 24);
            this.brandLabel.TabIndex = 1;
            this.brandLabel.Text = "Araç Markası";
            // 
            // carInfoGBox
            // 
            this.carInfoGBox.Controls.Add(this.parknoCBox);
            this.carInfoGBox.Controls.Add(this.parknoLabel);
            this.carInfoGBox.Controls.Add(this.modelTBox);
            this.carInfoGBox.Controls.Add(this.modelLabel);
            this.carInfoGBox.Controls.Add(this.brandTBox);
            this.carInfoGBox.Controls.Add(this.plateTBox);
            this.carInfoGBox.Controls.Add(this.brandLabel);
            this.carInfoGBox.Controls.Add(this.plateLabel);
            this.carInfoGBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carInfoGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carInfoGBox.ForeColor = System.Drawing.Color.Black;
            this.carInfoGBox.Location = new System.Drawing.Point(62, 97);
            this.carInfoGBox.Name = "carInfoGBox";
            this.carInfoGBox.Size = new System.Drawing.Size(528, 253);
            this.carInfoGBox.TabIndex = 2;
            this.carInfoGBox.TabStop = false;
            this.carInfoGBox.Text = "Araç Bilgileri";
            this.carInfoGBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // parknoCBox
            // 
            this.parknoCBox.BackColor = System.Drawing.Color.DarkGray;
            this.parknoCBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parknoCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parknoCBox.FormattingEnabled = true;
            this.parknoCBox.Location = new System.Drawing.Point(216, 209);
            this.parknoCBox.Name = "parknoCBox";
            this.parknoCBox.Size = new System.Drawing.Size(120, 33);
            this.parknoCBox.TabIndex = 7;
            // 
            // parknoLabel
            // 
            this.parknoLabel.AutoSize = true;
            this.parknoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parknoLabel.Location = new System.Drawing.Point(116, 213);
            this.parknoLabel.Name = "parknoLabel";
            this.parknoLabel.Size = new System.Drawing.Size(77, 24);
            this.parknoLabel.TabIndex = 6;
            this.parknoLabel.Text = "Park No";
            // 
            // modelTBox
            // 
            this.modelTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(140)))), ((int)(((byte)(80)))));
            this.modelTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelTBox.Location = new System.Drawing.Point(216, 145);
            this.modelTBox.Name = "modelTBox";
            this.modelTBox.Size = new System.Drawing.Size(195, 28);
            this.modelTBox.TabIndex = 5;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.modelLabel.Location = new System.Drawing.Point(82, 146);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(111, 24);
            this.modelLabel.TabIndex = 4;
            this.modelLabel.Text = "Araç Modeli";
            // 
            // brandTBox
            // 
            this.brandTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(140)))), ((int)(((byte)(80)))));
            this.brandTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brandTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brandTBox.Location = new System.Drawing.Point(216, 100);
            this.brandTBox.Name = "brandTBox";
            this.brandTBox.Size = new System.Drawing.Size(195, 28);
            this.brandTBox.TabIndex = 3;
            // 
            // plateTBox
            // 
            this.plateTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(140)))), ((int)(((byte)(80)))));
            this.plateTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plateTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plateTBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.plateTBox.Location = new System.Drawing.Point(216, 55);
            this.plateTBox.Name = "plateTBox";
            this.plateTBox.Size = new System.Drawing.Size(195, 28);
            this.plateTBox.TabIndex = 2;
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headLabel.Location = new System.Drawing.Point(176, 30);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(310, 33);
            this.headLabel.TabIndex = 3;
            this.headLabel.Text = " Kayıt Düzenleme Formu";
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
            this.customerInfoGBox.Location = new System.Drawing.Point(62, 373);
            this.customerInfoGBox.Name = "customerInfoGBox";
            this.customerInfoGBox.Size = new System.Drawing.Size(528, 244);
            this.customerInfoGBox.TabIndex = 6;
            this.customerInfoGBox.TabStop = false;
            this.customerInfoGBox.Text = "Müşteri Bilgileri";
            // 
            // phoneTBox
            // 
            this.phoneTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(140)))), ((int)(((byte)(80)))));
            this.phoneTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneTBox.Location = new System.Drawing.Point(216, 145);
            this.phoneTBox.Name = "phoneTBox";
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
            this.surnTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(140)))), ((int)(((byte)(80)))));
            this.surnTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnTBox.Location = new System.Drawing.Point(216, 100);
            this.surnTBox.Name = "surnTBox";
            this.surnTBox.Size = new System.Drawing.Size(195, 28);
            this.surnTBox.TabIndex = 3;
            // 
            // nameTBox
            // 
            this.nameTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(140)))), ((int)(((byte)(80)))));
            this.nameTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameTBox.Location = new System.Drawing.Point(216, 55);
            this.nameTBox.Name = "nameTBox";
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
            this.surnLabel.Click += new System.EventHandler(this.label6_Click);
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
            // arackayitOK
            // 
            this.arackayitOK.BackColor = System.Drawing.Color.ForestGreen;
            this.arackayitOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arackayitOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.arackayitOK.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arackayitOK.Location = new System.Drawing.Point(260, 688);
            this.arackayitOK.Name = "arackayitOK";
            this.arackayitOK.Size = new System.Drawing.Size(151, 59);
            this.arackayitOK.TabIndex = 7;
            this.arackayitOK.Text = "Kaydet";
            this.arackayitOK.UseVisualStyleBackColor = false;
            this.arackayitOK.Click += new System.EventHandler(this.arackayitOK_Click);
            // 
            // carEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(722, 798);
            this.Controls.Add(this.arackayitOK);
            this.Controls.Add(this.customerInfoGBox);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.carInfoGBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "carEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Düzenleme";
            this.Load += new System.EventHandler(this.editForm_Load);
            this.carInfoGBox.ResumeLayout(false);
            this.carInfoGBox.PerformLayout();
            this.customerInfoGBox.ResumeLayout(false);
            this.customerInfoGBox.PerformLayout();
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
        private ComboBox parknoCBox;
        private Label parknoLabel;
        private Button arackayitOK;
    }
}