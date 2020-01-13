namespace weekFour
{
    partial class empDataForm
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
            this.loadEmpButton = new System.Windows.Forms.Button();
            this.updateEmpButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmpTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmpType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadEmpButton
            // 
            this.loadEmpButton.AutoSize = true;
            this.loadEmpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loadEmpButton.Location = new System.Drawing.Point(190, 12);
            this.loadEmpButton.Name = "loadEmpButton";
            this.loadEmpButton.Size = new System.Drawing.Size(55, 30);
            this.loadEmpButton.TabIndex = 0;
            this.loadEmpButton.Text = "Load";
            this.loadEmpButton.UseVisualStyleBackColor = true;
            this.loadEmpButton.Click += new System.EventHandler(this.loadEmpButton_Click);
            // 
            // updateEmpButton
            // 
            this.updateEmpButton.AutoSize = true;
            this.updateEmpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateEmpButton.Location = new System.Drawing.Point(432, 12);
            this.updateEmpButton.Name = "updateEmpButton";
            this.updateEmpButton.Size = new System.Drawing.Size(72, 30);
            this.updateEmpButton.TabIndex = 1;
            this.updateEmpButton.Text = "Update";
            this.updateEmpButton.UseVisualStyleBackColor = true;
            this.updateEmpButton.Click += new System.EventHandler(this.updateEmpButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirstName,
            this.colLastName,
            this.colAge,
            this.colEmpType,
            this.colTitle,
            this.colPay});
            this.dataGridView1.Location = new System.Drawing.Point(525, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(933, 308);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colFirstName
            // 
            this.colFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFirstName.DataPropertyName = "firstName";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Width = 111;
            // 
            // colLastName
            // 
            this.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLastName.DataPropertyName = "lastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.Width = 111;
            // 
            // colAge
            // 
            this.colAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colAge.DataPropertyName = "age";
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Width = 63;
            // 
            // colEmpType
            // 
            this.colEmpType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEmpType.DataPropertyName = "empType";
            this.colEmpType.HeaderText = "Employee Type";
            this.colEmpType.Name = "colEmpType";
            this.colEmpType.Width = 142;
            // 
            // colTitle
            // 
            this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTitle.DataPropertyName = "empTitle";
            this.colTitle.HeaderText = "Employee Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Width = 137;
            // 
            // colPay
            // 
            this.colPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPay.DataPropertyName = "pay";
            this.colPay.HeaderText = "Salary";
            this.colPay.Name = "colPay";
            this.colPay.Width = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Load File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Updated Info";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxPay
            // 
            this.textBoxPay.Location = new System.Drawing.Point(102, 294);
            this.textBoxPay.Name = "textBoxPay";
            this.textBoxPay.Size = new System.Drawing.Size(402, 26);
            this.textBoxPay.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Salary";
            // 
            // textBoxEmpTitle
            // 
            this.textBoxEmpTitle.Location = new System.Drawing.Point(102, 249);
            this.textBoxEmpTitle.Name = "textBoxEmpTitle";
            this.textBoxEmpTitle.Size = new System.Drawing.Size(402, 26);
            this.textBoxEmpTitle.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Emp Title";
            // 
            // textBoxEmpType
            // 
            this.textBoxEmpType.Location = new System.Drawing.Point(102, 205);
            this.textBoxEmpType.Name = "textBoxEmpType";
            this.textBoxEmpType.Size = new System.Drawing.Size(402, 26);
            this.textBoxEmpType.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Emp Type";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(102, 159);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(402, 26);
            this.textBoxAge.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Emp Age";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(102, 111);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(402, 26);
            this.textBoxLastName.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Last Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(102, 66);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(402, 26);
            this.textBoxFirstName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "First Name";
            // 
            // empDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1481, 352);
            this.Controls.Add(this.textBoxPay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEmpTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmpType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateEmpButton);
            this.Controls.Add(this.loadEmpButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "empDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Data Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadEmpButton;
        private System.Windows.Forms.Button updateEmpButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBoxPay;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxEmpTitle;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBoxEmpType;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label8;
    }
}

