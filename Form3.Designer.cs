namespace Salon
{
    partial class Form3
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
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timePDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonDataSet = new Salon.SalonDataSet();
            this.recordsTableTableAdapter = new Salon.SalonDataSetTableAdapters.recordsTableTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numericUpDown3.Location = new System.Drawing.Point(396, 152);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numericUpDown4.Location = new System.Drawing.Point(270, 152);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown4.TabIndex = 3;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(348, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Время";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.comboBox1.Location = new System.Drawing.Point(316, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(299, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.timePDataGridViewTextBoxColumn,
            this.namePDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recordsTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(71, 29);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Visible = false;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // timePDataGridViewTextBoxColumn
            // 
            this.timePDataGridViewTextBoxColumn.DataPropertyName = "timeP";
            this.timePDataGridViewTextBoxColumn.HeaderText = "timeP";
            this.timePDataGridViewTextBoxColumn.Name = "timePDataGridViewTextBoxColumn";
            // 
            // namePDataGridViewTextBoxColumn
            // 
            this.namePDataGridViewTextBoxColumn.DataPropertyName = "nameP";
            this.namePDataGridViewTextBoxColumn.HeaderText = "nameP";
            this.namePDataGridViewTextBoxColumn.Name = "namePDataGridViewTextBoxColumn";
            // 
            // recordsTableBindingSource
            // 
            this.recordsTableBindingSource.DataMember = "recordsTable";
            this.recordsTableBindingSource.DataSource = this.salonDataSet;
            // 
            // salonDataSet
            // 
            this.salonDataSet.DataSetName = "SalonDataSet";
            this.salonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordsTableTableAdapter
            // 
            this.recordsTableTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 343);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(70, 30);
            this.listBox1.TabIndex = 9;
            this.listBox1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Salon.Properties.Resources.флакон;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SalonDataSet salonDataSet;
        private System.Windows.Forms.BindingSource recordsTableBindingSource;
        private SalonDataSetTableAdapters.recordsTableTableAdapter recordsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
    }
}