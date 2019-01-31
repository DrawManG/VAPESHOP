namespace VAPESHOP
{
    partial class Jidkosti
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
            this.vapeShopDataSet = new VAPESHOP.VapeShopDataSet();
            this.pokupkasostavlausheiJidkostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokupka_sostavlaushei_JidkostiTableAdapter = new VAPESHOP.VapeShopDataSetTableAdapters.Pokupka_sostavlaushei_JidkostiTableAdapter();
            this.kodPokupkisostavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentOpokupkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavlausheiJidkostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vapeShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupkasostavlausheiJidkostiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodPokupkisostavaDataGridViewTextBoxColumn,
            this.dokumentOpokupkeDataGridViewTextBoxColumn,
            this.sostavlausheiJidkostiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pokupkasostavlausheiJidkostiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 196);
            this.dataGridView1.TabIndex = 0;
            // 
            // vapeShopDataSet
            // 
            this.vapeShopDataSet.DataSetName = "VapeShopDataSet";
            this.vapeShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokupkasostavlausheiJidkostiBindingSource
            // 
            this.pokupkasostavlausheiJidkostiBindingSource.DataMember = "Pokupka_sostavlaushei_Jidkosti";
            this.pokupkasostavlausheiJidkostiBindingSource.DataSource = this.vapeShopDataSet;
            // 
            // pokupka_sostavlaushei_JidkostiTableAdapter
            // 
            this.pokupka_sostavlaushei_JidkostiTableAdapter.ClearBeforeFill = true;
            // 
            // kodPokupkisostavaDataGridViewTextBoxColumn
            // 
            this.kodPokupkisostavaDataGridViewTextBoxColumn.DataPropertyName = "Kod_Pokupki_sostava";
            this.kodPokupkisostavaDataGridViewTextBoxColumn.HeaderText = "Kod_Pokupki_sostava";
            this.kodPokupkisostavaDataGridViewTextBoxColumn.Name = "kodPokupkisostavaDataGridViewTextBoxColumn";
            this.kodPokupkisostavaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dokumentOpokupkeDataGridViewTextBoxColumn
            // 
            this.dokumentOpokupkeDataGridViewTextBoxColumn.DataPropertyName = "Dokument_O_pokupke";
            this.dokumentOpokupkeDataGridViewTextBoxColumn.HeaderText = "Dokument_O_pokupke";
            this.dokumentOpokupkeDataGridViewTextBoxColumn.Name = "dokumentOpokupkeDataGridViewTextBoxColumn";
            // 
            // sostavlausheiJidkostiDataGridViewTextBoxColumn
            // 
            this.sostavlausheiJidkostiDataGridViewTextBoxColumn.DataPropertyName = "Sostavlaushei_Jidkosti";
            this.sostavlausheiJidkostiDataGridViewTextBoxColumn.HeaderText = "Sostavlaushei_Jidkosti";
            this.sostavlausheiJidkostiDataGridViewTextBoxColumn.Name = "sostavlausheiJidkostiDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Jidkosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 318);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Jidkosti";
            this.Text = "Jidkosti";
            this.Load += new System.EventHandler(this.Jidkosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vapeShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokupkasostavlausheiJidkostiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VapeShopDataSet vapeShopDataSet;
        private System.Windows.Forms.BindingSource pokupkasostavlausheiJidkostiBindingSource;
        private VapeShopDataSetTableAdapters.Pokupka_sostavlaushei_JidkostiTableAdapter pokupka_sostavlaushei_JidkostiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodPokupkisostavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentOpokupkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostavlausheiJidkostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}