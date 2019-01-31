namespace VAPESHOP
{
    partial class zakaz_jidkosti
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodKlientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentOPokupkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodsotrydnikovpoproizvodstvyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodviboratovaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaiavlenieopokupkeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vapeShopDataSet = new VAPESHOP.VapeShopDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.zaiavlenieopokupkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kLientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zakazprobiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakaz_probiTableAdapter = new VAPESHOP.VapeShopDataSetTableAdapters.Zakaz_probiTableAdapter();
            this.fKVaрeShopZakazprobiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaрeShopTableAdapter = new VAPESHOP.VapeShopDataSetTableAdapters.VaрeShopTableAdapter();
            this.kLientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kLientsTableAdapter = new VAPESHOP.VapeShopDataSetTableAdapters.KLientsTableAdapter();
            this.zakazprobiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zakazprobiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zaiavlenie_o_pokupkeTableAdapter = new VAPESHOP.VapeShopDataSetTableAdapters.Zaiavlenie_o_pokupkeTableAdapter();
            this.zakazprobiBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.zaiavlenieopokupkeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaiavlenieopokupkeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vapeShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaiavlenieopokupkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazprobiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVaрeShopZakazprobiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazprobiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazprobiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazprobiBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaiavlenieopokupkeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 477);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodKlientDataGridViewTextBoxColumn,
            this.documentOPokupkeDataGridViewTextBoxColumn,
            this.kodsotrydnikovpoproizvodstvyDataGridViewTextBoxColumn,
            this.kodviboratovaraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zaiavlenieopokupkeBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 439);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
            // 
            // kodKlientDataGridViewTextBoxColumn
            // 
            this.kodKlientDataGridViewTextBoxColumn.DataPropertyName = "Kod_Klient";
            this.kodKlientDataGridViewTextBoxColumn.HeaderText = "Kod_Klient";
            this.kodKlientDataGridViewTextBoxColumn.Name = "kodKlientDataGridViewTextBoxColumn";
            // 
            // documentOPokupkeDataGridViewTextBoxColumn
            // 
            this.documentOPokupkeDataGridViewTextBoxColumn.DataPropertyName = "Document_O_Pokupke";
            this.documentOPokupkeDataGridViewTextBoxColumn.HeaderText = "Document_O_Pokupke";
            this.documentOPokupkeDataGridViewTextBoxColumn.Name = "documentOPokupkeDataGridViewTextBoxColumn";
            // 
            // kodsotrydnikovpoproizvodstvyDataGridViewTextBoxColumn
            // 
            this.kodsotrydnikovpoproizvodstvyDataGridViewTextBoxColumn.DataPropertyName = "Kod_sotrydnikov_po_proizvodstvy";
            this.kodsotrydnikovpoproizvodstvyDataGridViewTextBoxColumn.HeaderText = "Kod_sotrydnikov_po_proizvodstvy";
            this.kodsotrydnikovpoproizvodstvyDataGridViewTextBoxColumn.Name = "kodsotrydnikovpoproizvodstvyDataGridViewTextBoxColumn";
            // 
            // kodviboratovaraDataGridViewTextBoxColumn
            // 
            this.kodviboratovaraDataGridViewTextBoxColumn.DataPropertyName = "Kod_vibora_tovara";
            this.kodviboratovaraDataGridViewTextBoxColumn.HeaderText = "Kod_vibora_tovara";
            this.kodviboratovaraDataGridViewTextBoxColumn.Name = "kodviboratovaraDataGridViewTextBoxColumn";
            // 
            // zaiavlenieopokupkeBindingSource2
            // 
            this.zaiavlenieopokupkeBindingSource2.DataMember = "Zaiavlenie_o_pokupke";
            this.zaiavlenieopokupkeBindingSource2.DataSource = this.vapeShopDataSet;
            // 
            // vapeShopDataSet
            // 
            this.vapeShopDataSet.DataSetName = "VapeShopDataSet";
            this.vapeShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 445);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zaiavlenieopokupkeBindingSource
            // 
            this.zaiavlenieopokupkeBindingSource.DataMember = "Zaiavlenie_o_pokupke";
            this.zaiavlenieopokupkeBindingSource.DataSource = this.vapeShopDataSet;
            // 
            // kLientsBindingSource1
            // 
            this.kLientsBindingSource1.DataMember = "KLients";
            this.kLientsBindingSource1.DataSource = this.vapeShopDataSet;
            // 
            // zakazprobiBindingSource
            // 
            this.zakazprobiBindingSource.DataMember = "Zakaz_probi";
            this.zakazprobiBindingSource.DataSource = this.vapeShopDataSet;
            // 
            // zakaz_probiTableAdapter
            // 
            this.zakaz_probiTableAdapter.ClearBeforeFill = true;
            // 
            // fKVaрeShopZakazprobiBindingSource
            // 
            this.fKVaрeShopZakazprobiBindingSource.DataMember = "FK_VaрeShop_Zakaz_probi";
            this.fKVaрeShopZakazprobiBindingSource.DataSource = this.zakazprobiBindingSource;
            // 
            // vaрeShopTableAdapter
            // 
            this.vaрeShopTableAdapter.ClearBeforeFill = true;
            // 
            // kLientsBindingSource
            // 
            this.kLientsBindingSource.DataMember = "KLients";
            this.kLientsBindingSource.DataSource = this.vapeShopDataSet;
            // 
            // kLientsTableAdapter
            // 
            this.kLientsTableAdapter.ClearBeforeFill = true;
            // 
            // zakazprobiBindingSource1
            // 
            this.zakazprobiBindingSource1.DataMember = "Zakaz_probi";
            this.zakazprobiBindingSource1.DataSource = this.vapeShopDataSet;
            // 
            // zakazprobiBindingSource2
            // 
            this.zakazprobiBindingSource2.DataMember = "Zakaz_probi";
            this.zakazprobiBindingSource2.DataSource = this.vapeShopDataSet;
            // 
            // zaiavlenie_o_pokupkeTableAdapter
            // 
            this.zaiavlenie_o_pokupkeTableAdapter.ClearBeforeFill = true;
            // 
            // zakazprobiBindingSource3
            // 
            this.zakazprobiBindingSource3.DataMember = "Zakaz_probi";
            this.zakazprobiBindingSource3.DataSource = this.vapeShopDataSet;
            // 
            // zaiavlenieopokupkeBindingSource1
            // 
            this.zaiavlenieopokupkeBindingSource1.DataMember = "Zaiavlenie_o_pokupke";
            this.zaiavlenieopokupkeBindingSource1.DataSource = this.vapeShopDataSet;
            // 
            // zakaz_jidkosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 477);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "zakaz_jidkosti";
            this.Text = "zakaz_jidkosti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.zakaz_jidkosti_FormClosed);
            this.Load += new System.EventHandler(this.zakaz_jidkosti_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaiavlenieopokupkeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vapeShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaiavlenieopokupkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazprobiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKVaрeShopZakazprobiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazprobiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazprobiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazprobiBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaiavlenieopokupkeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private VapeShopDataSet vapeShopDataSet;
        private System.Windows.Forms.BindingSource zakazprobiBindingSource;
        private VapeShopDataSetTableAdapters.Zakaz_probiTableAdapter zakaz_probiTableAdapter;
        private System.Windows.Forms.BindingSource fKVaрeShopZakazprobiBindingSource;
        private VapeShopDataSetTableAdapters.VaрeShopTableAdapter vaрeShopTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource kLientsBindingSource;
        private VapeShopDataSetTableAdapters.KLientsTableAdapter kLientsTableAdapter;
        private System.Windows.Forms.BindingSource kLientsBindingSource1;
        private System.Windows.Forms.BindingSource zakazprobiBindingSource1;
        private System.Windows.Forms.BindingSource zakazprobiBindingSource2;
        private System.Windows.Forms.BindingSource zaiavlenieopokupkeBindingSource;
        private VapeShopDataSetTableAdapters.Zaiavlenie_o_pokupkeTableAdapter zaiavlenie_o_pokupkeTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource zaiavlenieopokupkeBindingSource1;
        private System.Windows.Forms.BindingSource zakazprobiBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodKlientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentOPokupkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodsotrydnikovpoproizvodstvyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodviboratovaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zaiavlenieopokupkeBindingSource2;
    }
}