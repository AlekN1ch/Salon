namespace Salon
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timePDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonDataSet = new Salon.SalonDataSet();
            this.fLOWERDataSet = new Salon.FLOWERDataSet();
            this.recordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordsTableAdapter = new Salon.FLOWERDataSetTableAdapters.recordsTableAdapter();
            this.recordsTableTableAdapter = new Salon.SalonDataSetTableAdapters.recordsTableTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLOWERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(451, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.timePDataGridViewTextBoxColumn,
            this.namePDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recordsTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(190, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 115);
            this.dataGridView1.TabIndex = 2;
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
            // fLOWERDataSet
            // 
            this.fLOWERDataSet.DataSetName = "FLOWERDataSet";
            this.fLOWERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recordsBindingSource
            // 
            this.recordsBindingSource.DataMember = "records";
            this.recordsBindingSource.DataSource = this.fLOWERDataSet;
            // 
            // recordsTableAdapter
            // 
            this.recordsTableAdapter.ClearBeforeFill = true;
            // 
            // recordsTableTableAdapter
            // 
            this.recordsTableTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(485, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Обновить страницу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Salon.Properties.Resources.парик;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLOWERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FLOWERDataSet fLOWERDataSet;
        private System.Windows.Forms.BindingSource recordsBindingSource;
        private FLOWERDataSetTableAdapters.recordsTableAdapter recordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePDataGridViewTextBoxColumn;
        private SalonDataSet salonDataSet;
        private System.Windows.Forms.BindingSource recordsTableBindingSource;
        private SalonDataSetTableAdapters.recordsTableTableAdapter recordsTableTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}