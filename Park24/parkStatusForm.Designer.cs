using System.Windows.Forms;

namespace Park24
{
    partial class parkStatusForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.carListButton = new System.Windows.Forms.Button();
            this.parkPlacesButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.parkListGView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkPlacesPanel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkListGView1)).BeginInit();
            this.parkPlacesPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // carListButton
            // 
            this.carListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carListButton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carListButton.Location = new System.Drawing.Point(326, 5);
            this.carListButton.Name = "carListButton";
            this.carListButton.Size = new System.Drawing.Size(217, 57);
            this.carListButton.TabIndex = 1;
            this.carListButton.Text = "Araç Listesi";
            this.carListButton.UseVisualStyleBackColor = true;
            this.carListButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // parkPlacesButton
            // 
            this.parkPlacesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parkPlacesButton.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parkPlacesButton.Location = new System.Drawing.Point(564, 5);
            this.parkPlacesButton.Name = "parkPlacesButton";
            this.parkPlacesButton.Size = new System.Drawing.Size(217, 57);
            this.parkPlacesButton.TabIndex = 2;
            this.parkPlacesButton.Text = "Park Yerleri";
            this.parkPlacesButton.UseVisualStyleBackColor = true;
            this.parkPlacesButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.parkListGView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 472);
            this.panel1.TabIndex = 3;
            // 
            // parkListGView1
            // 
            this.parkListGView1.AllowUserToAddRows = false;
            this.parkListGView1.AllowUserToDeleteRows = false;
            this.parkListGView1.AllowUserToResizeColumns = false;
            this.parkListGView1.AllowUserToResizeRows = false;
            this.parkListGView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.parkListGView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.parkListGView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.parkListGView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.parkListGView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.parkListGView1.ColumnHeadersHeight = 50;
            this.parkListGView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.parkListGView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column8});
            this.parkListGView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.parkListGView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parkListGView1.EnableHeadersVisualStyles = false;
            this.parkListGView1.Location = new System.Drawing.Point(0, 0);
            this.parkListGView1.MultiSelect = false;
            this.parkListGView1.Name = "parkListGView1";
            this.parkListGView1.ReadOnly = true;
            this.parkListGView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.parkListGView1.RowHeadersVisible = false;
            this.parkListGView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.parkListGView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.parkListGView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.parkListGView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.parkListGView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parkListGView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.parkListGView1.RowTemplate.Height = 40;
            this.parkListGView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.parkListGView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.parkListGView1.Size = new System.Drawing.Size(1108, 472);
            this.parkListGView1.TabIndex = 0;
            this.parkListGView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "P. No";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.ToolTipText = "Park Yeri No";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad Soyad";
            this.Column2.MinimumWidth = 202;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 202;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefon No.";
            this.Column3.MinimumWidth = 145;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 145;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Araç Plaka";
            this.Column4.MinimumWidth = 140;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Araç Markası";
            this.Column5.MinimumWidth = 165;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 165;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Giriş Tarihi";
            this.Column6.MinimumWidth = 100;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giriş Saati";
            this.Column7.MinimumWidth = 80;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Toplam Süre";
            this.Column9.MinimumWidth = 140;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 140;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ücret";
            this.Column8.MinimumWidth = 83;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 83;
            // 
            // parkPlacesPanel1
            // 
            this.parkPlacesPanel1.Controls.Add(this.button3);
            this.parkPlacesPanel1.Location = new System.Drawing.Point(0, 265);
            this.parkPlacesPanel1.Name = "parkPlacesPanel1";
            this.parkPlacesPanel1.Size = new System.Drawing.Size(1108, 275);
            this.parkPlacesPanel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 103);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // parkStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1108, 540);
            this.Controls.Add(this.parkPlacesPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.parkPlacesButton);
            this.Controls.Add(this.carListButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "parkStatusForm";
            this.Text = "statusForm";
            this.Load += new System.EventHandler(this.statusForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parkListGView1)).EndInit();
            this.parkPlacesPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button carListButton;
        private System.Windows.Forms.Button parkPlacesButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel parkPlacesPanel1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView parkListGView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column8;
    }
}