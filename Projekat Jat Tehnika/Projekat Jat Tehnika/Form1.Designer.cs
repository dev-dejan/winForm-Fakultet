namespace Projekat_Jat_Tehnika
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBrAv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAvSrb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBrisanje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.jatDataSet = new Projekat_Jat_Tehnika.JatDataSet();
            this.jatDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avionTableAdapter = new Projekat_Jat_Tehnika.JatDataSetTableAdapters.AvionTableAdapter();
            this.hangarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangarTableAdapter = new Projekat_Jat_Tehnika.JatDataSetTableAdapters.HangarTableAdapter();
            this.nabavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nabavkaTableAdapter = new Projekat_Jat_Tehnika.JatDataSetTableAdapters.NabavkaTableAdapter();
            this.odrzavanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odrzavanjeTableAdapter = new Projekat_Jat_Tehnika.JatDataSetTableAdapters.OdrzavanjeTableAdapter();
            this.radnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radnikTableAdapter = new Projekat_Jat_Tehnika.JatDataSetTableAdapters.RadnikTableAdapter();
            this.avionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeAvionaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojPopravkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hangarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nabavkaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.odrzavanjeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unesiNoviAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrisiAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jatDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odrzavanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.avionIDDataGridViewTextBoxColumn,
            this.imeAvionaDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.brojPopravkiDataGridViewTextBoxColumn,
            this.radnikIDDataGridViewTextBoxColumn,
            this.hangarIDDataGridViewTextBoxColumn,
            this.nabavkaIDDataGridViewTextBoxColumn,
            this.odrzavanjeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.avionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAvSrb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBrAv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj Aviona na popravci";
            // 
            // tbBrAv
            // 
            this.tbBrAv.Location = new System.Drawing.Point(157, 36);
            this.tbBrAv.Name = "tbBrAv";
            this.tbBrAv.ReadOnly = true;
            this.tbBrAv.Size = new System.Drawing.Size(100, 20);
            this.tbBrAv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj Aviona iz Srbije";
            // 
            // tbAvSrb
            // 
            this.tbAvSrb.Location = new System.Drawing.Point(157, 80);
            this.tbAvSrb.Name = "tbAvSrb";
            this.tbAvSrb.ReadOnly = true;
            this.tbAvSrb.Size = new System.Drawing.Size(100, 20);
            this.tbAvSrb.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbBrisanje);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(341, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brisanje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Broj Aviona za Brisanje (ID)";
            // 
            // tbBrisanje
            // 
            this.tbBrisanje.Location = new System.Drawing.Point(169, 36);
            this.tbBrisanje.Name = "tbBrisanje";
            this.tbBrisanje.Size = new System.Drawing.Size(100, 20);
            this.tbBrisanje.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Obrisi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jatDataSet
            // 
            this.jatDataSet.DataSetName = "JatDataSet";
            this.jatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jatDataSetBindingSource
            // 
            this.jatDataSetBindingSource.DataSource = this.jatDataSet;
            this.jatDataSetBindingSource.Position = 0;
            // 
            // avionBindingSource
            // 
            this.avionBindingSource.DataMember = "Avion";
            this.avionBindingSource.DataSource = this.jatDataSet;
            // 
            // avionTableAdapter
            // 
            this.avionTableAdapter.ClearBeforeFill = true;
            // 
            // hangarBindingSource
            // 
            this.hangarBindingSource.DataMember = "Hangar";
            this.hangarBindingSource.DataSource = this.jatDataSet;
            // 
            // hangarTableAdapter
            // 
            this.hangarTableAdapter.ClearBeforeFill = true;
            // 
            // nabavkaBindingSource
            // 
            this.nabavkaBindingSource.DataMember = "Nabavka";
            this.nabavkaBindingSource.DataSource = this.jatDataSet;
            // 
            // nabavkaTableAdapter
            // 
            this.nabavkaTableAdapter.ClearBeforeFill = true;
            // 
            // odrzavanjeBindingSource
            // 
            this.odrzavanjeBindingSource.DataMember = "Odrzavanje";
            this.odrzavanjeBindingSource.DataSource = this.jatDataSet;
            // 
            // odrzavanjeTableAdapter
            // 
            this.odrzavanjeTableAdapter.ClearBeforeFill = true;
            // 
            // radnikBindingSource
            // 
            this.radnikBindingSource.DataMember = "Radnik";
            this.radnikBindingSource.DataSource = this.jatDataSet;
            // 
            // radnikTableAdapter
            // 
            this.radnikTableAdapter.ClearBeforeFill = true;
            // 
            // avionIDDataGridViewTextBoxColumn
            // 
            this.avionIDDataGridViewTextBoxColumn.DataPropertyName = "AvionID";
            this.avionIDDataGridViewTextBoxColumn.HeaderText = "AvionID";
            this.avionIDDataGridViewTextBoxColumn.Name = "avionIDDataGridViewTextBoxColumn";
            // 
            // imeAvionaDataGridViewTextBoxColumn
            // 
            this.imeAvionaDataGridViewTextBoxColumn.DataPropertyName = "Ime Aviona";
            this.imeAvionaDataGridViewTextBoxColumn.HeaderText = "Ime Aviona";
            this.imeAvionaDataGridViewTextBoxColumn.Name = "imeAvionaDataGridViewTextBoxColumn";
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "Drzava";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            // 
            // brojPopravkiDataGridViewTextBoxColumn
            // 
            this.brojPopravkiDataGridViewTextBoxColumn.DataPropertyName = "Broj popravki";
            this.brojPopravkiDataGridViewTextBoxColumn.HeaderText = "Broj popravki";
            this.brojPopravkiDataGridViewTextBoxColumn.Name = "brojPopravkiDataGridViewTextBoxColumn";
            // 
            // radnikIDDataGridViewTextBoxColumn
            // 
            this.radnikIDDataGridViewTextBoxColumn.DataPropertyName = "RadnikID";
            this.radnikIDDataGridViewTextBoxColumn.DataSource = this.radnikBindingSource;
            this.radnikIDDataGridViewTextBoxColumn.DisplayMember = "Ime";
            this.radnikIDDataGridViewTextBoxColumn.HeaderText = "RadnikID";
            this.radnikIDDataGridViewTextBoxColumn.Name = "radnikIDDataGridViewTextBoxColumn";
            this.radnikIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.radnikIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.radnikIDDataGridViewTextBoxColumn.ValueMember = "RadnikID";
            // 
            // hangarIDDataGridViewTextBoxColumn
            // 
            this.hangarIDDataGridViewTextBoxColumn.DataPropertyName = "HangarID";
            this.hangarIDDataGridViewTextBoxColumn.DataSource = this.hangarBindingSource;
            this.hangarIDDataGridViewTextBoxColumn.DisplayMember = "HangarID";
            this.hangarIDDataGridViewTextBoxColumn.HeaderText = "HangarID";
            this.hangarIDDataGridViewTextBoxColumn.Name = "hangarIDDataGridViewTextBoxColumn";
            this.hangarIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hangarIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.hangarIDDataGridViewTextBoxColumn.ValueMember = "HangarID";
            // 
            // nabavkaIDDataGridViewTextBoxColumn
            // 
            this.nabavkaIDDataGridViewTextBoxColumn.DataPropertyName = "NabavkaID";
            this.nabavkaIDDataGridViewTextBoxColumn.DataSource = this.nabavkaBindingSource;
            this.nabavkaIDDataGridViewTextBoxColumn.DisplayMember = "Naziv dela";
            this.nabavkaIDDataGridViewTextBoxColumn.HeaderText = "NabavkaID";
            this.nabavkaIDDataGridViewTextBoxColumn.Name = "nabavkaIDDataGridViewTextBoxColumn";
            this.nabavkaIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nabavkaIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.nabavkaIDDataGridViewTextBoxColumn.ValueMember = "NabavkaID";
            // 
            // odrzavanjeIDDataGridViewTextBoxColumn
            // 
            this.odrzavanjeIDDataGridViewTextBoxColumn.DataPropertyName = "OdrzavanjeID";
            this.odrzavanjeIDDataGridViewTextBoxColumn.DataSource = this.odrzavanjeBindingSource;
            this.odrzavanjeIDDataGridViewTextBoxColumn.DisplayMember = "Naziv odrzavanja";
            this.odrzavanjeIDDataGridViewTextBoxColumn.HeaderText = "OdrzavanjeID";
            this.odrzavanjeIDDataGridViewTextBoxColumn.Name = "odrzavanjeIDDataGridViewTextBoxColumn";
            this.odrzavanjeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.odrzavanjeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.odrzavanjeIDDataGridViewTextBoxColumn.ValueMember = "OdrzavanjeID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(691, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Informacije";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(664, 258);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 134);
            this.listBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Osvezi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.brisanjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unesiNoviAvionToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // brisanjeToolStripMenuItem
            // 
            this.brisanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbrisiAvionToolStripMenuItem});
            this.brisanjeToolStripMenuItem.Name = "brisanjeToolStripMenuItem";
            this.brisanjeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.brisanjeToolStripMenuItem.Text = "Brisanje";
            // 
            // unesiNoviAvionToolStripMenuItem
            // 
            this.unesiNoviAvionToolStripMenuItem.Name = "unesiNoviAvionToolStripMenuItem";
            this.unesiNoviAvionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.unesiNoviAvionToolStripMenuItem.Text = "Unesi novi Avion";
            this.unesiNoviAvionToolStripMenuItem.Click += new System.EventHandler(this.unesiNoviAvionToolStripMenuItem_Click);
            // 
            // izbrisiAvionToolStripMenuItem
            // 
            this.izbrisiAvionToolStripMenuItem.Name = "izbrisiAvionToolStripMenuItem";
            this.izbrisiAvionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izbrisiAvionToolStripMenuItem.Text = "Izbrisi avion";
            this.izbrisiAvionToolStripMenuItem.Click += new System.EventHandler(this.izbrisiAvionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jatDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nabavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odrzavanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnikBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAvSrb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBrAv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbBrisanje;
        private System.Windows.Forms.Label label3;
        private JatDataSet jatDataSet;
        private System.Windows.Forms.BindingSource jatDataSetBindingSource;
        private System.Windows.Forms.BindingSource avionBindingSource;
        private JatDataSetTableAdapters.AvionTableAdapter avionTableAdapter;
        private System.Windows.Forms.BindingSource hangarBindingSource;
        private JatDataSetTableAdapters.HangarTableAdapter hangarTableAdapter;
        private System.Windows.Forms.BindingSource nabavkaBindingSource;
        private JatDataSetTableAdapters.NabavkaTableAdapter nabavkaTableAdapter;
        private System.Windows.Forms.BindingSource odrzavanjeBindingSource;
        private JatDataSetTableAdapters.OdrzavanjeTableAdapter odrzavanjeTableAdapter;
        private System.Windows.Forms.BindingSource radnikBindingSource;
        private JatDataSetTableAdapters.RadnikTableAdapter radnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn avionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeAvionaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojPopravkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn radnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn hangarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn nabavkaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn odrzavanjeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unesiNoviAvionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbrisiAvionToolStripMenuItem;
    }
}

