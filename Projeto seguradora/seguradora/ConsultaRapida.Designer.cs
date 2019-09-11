namespace seguradora
{
    partial class ConsultaRapida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaRapida));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codcarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chassiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anofabricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anomodeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seguradoraDataSet = new seguradora.seguradoraDataSet();
            this.carroTableAdapter = new seguradora.seguradoraDataSetTableAdapters.carroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcarDataGridViewTextBoxColumn,
            this.chassiDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.anofabricaoDataGridViewTextBoxColumn,
            this.anomodeloDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.codcliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carroBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(844, 333);
            this.dataGridView1.TabIndex = 2;
            // 
            // codcarDataGridViewTextBoxColumn
            // 
            this.codcarDataGridViewTextBoxColumn.DataPropertyName = "cod_car";
            this.codcarDataGridViewTextBoxColumn.HeaderText = "cod_car";
            this.codcarDataGridViewTextBoxColumn.Name = "codcarDataGridViewTextBoxColumn";
            this.codcarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chassiDataGridViewTextBoxColumn
            // 
            this.chassiDataGridViewTextBoxColumn.DataPropertyName = "chassi";
            this.chassiDataGridViewTextBoxColumn.HeaderText = "chassi";
            this.chassiDataGridViewTextBoxColumn.Name = "chassiDataGridViewTextBoxColumn";
            this.chassiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anofabricaoDataGridViewTextBoxColumn
            // 
            this.anofabricaoDataGridViewTextBoxColumn.DataPropertyName = "ano_fabricao";
            this.anofabricaoDataGridViewTextBoxColumn.HeaderText = "ano_fabricao";
            this.anofabricaoDataGridViewTextBoxColumn.Name = "anofabricaoDataGridViewTextBoxColumn";
            this.anofabricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anomodeloDataGridViewTextBoxColumn
            // 
            this.anomodeloDataGridViewTextBoxColumn.DataPropertyName = "ano_modelo";
            this.anomodeloDataGridViewTextBoxColumn.HeaderText = "ano_modelo";
            this.anomodeloDataGridViewTextBoxColumn.Name = "anomodeloDataGridViewTextBoxColumn";
            this.anomodeloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codcliDataGridViewTextBoxColumn
            // 
            this.codcliDataGridViewTextBoxColumn.DataPropertyName = "cod_cli";
            this.codcliDataGridViewTextBoxColumn.HeaderText = "cod_cli";
            this.codcliDataGridViewTextBoxColumn.Name = "codcliDataGridViewTextBoxColumn";
            this.codcliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataMember = "carro";
            this.carroBindingSource.DataSource = this.seguradoraDataSet;
            // 
            // seguradoraDataSet
            // 
            this.seguradoraDataSet.DataSetName = "seguradoraDataSet";
            this.seguradoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carroTableAdapter
            // 
            this.carroTableAdapter.ClearBeforeFill = true;
            // 
            // ConsultaRapida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 333);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaRapida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA RAPIDA";
            this.Load += new System.EventHandler(this.ConsultaRapida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguradoraDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private seguradoraDataSet seguradoraDataSet;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private seguradoraDataSetTableAdapters.carroTableAdapter carroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chassiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anofabricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anomodeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcliDataGridViewTextBoxColumn;
    }
}