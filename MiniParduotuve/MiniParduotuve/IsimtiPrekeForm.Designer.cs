namespace MiniParduotuve
{
    partial class IsimtiPrekeForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kainaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svorisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuotraukaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prekesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lentelesDataSet = new MiniParduotuve.LentelesDataSet();
            this.prekesTableAdapter = new MiniParduotuve.LentelesDataSetTableAdapters.PrekesTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.IsimtiPrekeBt = new System.Windows.Forms.Button();
            this.PridetiPrekeLb = new System.Windows.Forms.Label();
            this.PavadinimasLb = new System.Windows.Forms.Label();
            this.PrekesIdTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lentelesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.pavadinimasDataGridViewTextBoxColumn,
            this.kainaDataGridViewTextBoxColumn,
            this.svorisDataGridViewTextBoxColumn,
            this.nuotraukaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prekesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(366, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(809, 794);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // pavadinimasDataGridViewTextBoxColumn
            // 
            this.pavadinimasDataGridViewTextBoxColumn.DataPropertyName = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.HeaderText = "Pavadinimas";
            this.pavadinimasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pavadinimasDataGridViewTextBoxColumn.Name = "pavadinimasDataGridViewTextBoxColumn";
            this.pavadinimasDataGridViewTextBoxColumn.Width = 125;
            // 
            // kainaDataGridViewTextBoxColumn
            // 
            this.kainaDataGridViewTextBoxColumn.DataPropertyName = "Kaina";
            this.kainaDataGridViewTextBoxColumn.HeaderText = "Kaina";
            this.kainaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kainaDataGridViewTextBoxColumn.Name = "kainaDataGridViewTextBoxColumn";
            this.kainaDataGridViewTextBoxColumn.Width = 125;
            // 
            // svorisDataGridViewTextBoxColumn
            // 
            this.svorisDataGridViewTextBoxColumn.DataPropertyName = "Svoris";
            this.svorisDataGridViewTextBoxColumn.HeaderText = "Svoris";
            this.svorisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.svorisDataGridViewTextBoxColumn.Name = "svorisDataGridViewTextBoxColumn";
            this.svorisDataGridViewTextBoxColumn.Width = 125;
            // 
            // nuotraukaDataGridViewTextBoxColumn
            // 
            this.nuotraukaDataGridViewTextBoxColumn.DataPropertyName = "Nuotrauka";
            this.nuotraukaDataGridViewTextBoxColumn.HeaderText = "Nuotrauka";
            this.nuotraukaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nuotraukaDataGridViewTextBoxColumn.Name = "nuotraukaDataGridViewTextBoxColumn";
            this.nuotraukaDataGridViewTextBoxColumn.Width = 125;
            // 
            // prekesBindingSource
            // 
            this.prekesBindingSource.DataMember = "Prekes";
            this.prekesBindingSource.DataSource = this.lentelesDataSet;
            // 
            // lentelesDataSet
            // 
            this.lentelesDataSet.DataSetName = "LentelesDataSet";
            this.lentelesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prekesTableAdapter
            // 
            this.prekesTableAdapter.ClearBeforeFill = true;
            // 
            // IsimtiPrekeBt
            // 
            this.IsimtiPrekeBt.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsimtiPrekeBt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IsimtiPrekeBt.Location = new System.Drawing.Point(84, 230);
            this.IsimtiPrekeBt.Name = "IsimtiPrekeBt";
            this.IsimtiPrekeBt.Size = new System.Drawing.Size(203, 112);
            this.IsimtiPrekeBt.TabIndex = 2;
            this.IsimtiPrekeBt.Text = "ISIMTI";
            this.IsimtiPrekeBt.UseVisualStyleBackColor = true;
            this.IsimtiPrekeBt.Click += new System.EventHandler(this.IsimtiPrekeBt_Click);
            // 
            // PridetiPrekeLb
            // 
            this.PridetiPrekeLb.AutoSize = true;
            this.PridetiPrekeLb.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PridetiPrekeLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PridetiPrekeLb.Location = new System.Drawing.Point(81, 93);
            this.PridetiPrekeLb.Name = "PridetiPrekeLb";
            this.PridetiPrekeLb.Size = new System.Drawing.Size(83, 17);
            this.PridetiPrekeLb.TabIndex = 11;
            this.PridetiPrekeLb.Text = "ISIMTI PREKE";
            // 
            // PavadinimasLb
            // 
            this.PavadinimasLb.AutoSize = true;
            this.PavadinimasLb.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PavadinimasLb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PavadinimasLb.Location = new System.Drawing.Point(81, 119);
            this.PavadinimasLb.Name = "PavadinimasLb";
            this.PavadinimasLb.Size = new System.Drawing.Size(67, 17);
            this.PavadinimasLb.TabIndex = 10;
            this.PavadinimasLb.Text = "PREKES ID";
            // 
            // PrekesIdTB
            // 
            this.PrekesIdTB.Font = new System.Drawing.Font("Poor Richard", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrekesIdTB.Location = new System.Drawing.Point(84, 144);
            this.PrekesIdTB.Name = "PrekesIdTB";
            this.PrekesIdTB.Size = new System.Drawing.Size(203, 22);
            this.PrekesIdTB.TabIndex = 9;
            // 
            // IsimtiPrekeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 835);
            this.Controls.Add(this.PridetiPrekeLb);
            this.Controls.Add(this.PavadinimasLb);
            this.Controls.Add(this.PrekesIdTB);
            this.Controls.Add(this.IsimtiPrekeBt);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IsimtiPrekeForm";
            this.Text = "IsimtiPrekeForm";
            this.Load += new System.EventHandler(this.IsimtiPrekeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prekesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lentelesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LentelesDataSet lentelesDataSet;
        private System.Windows.Forms.BindingSource prekesBindingSource;
        private LentelesDataSetTableAdapters.PrekesTableAdapter prekesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kainaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svorisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuotraukaDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button IsimtiPrekeBt;
        private System.Windows.Forms.Label PridetiPrekeLb;
        private System.Windows.Forms.Label PavadinimasLb;
        private System.Windows.Forms.TextBox PrekesIdTB;
    }
}