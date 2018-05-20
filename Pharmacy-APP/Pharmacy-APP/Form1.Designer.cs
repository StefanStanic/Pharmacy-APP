namespace Pharmacy_APP
{
    partial class Apoteka
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
            this.ime_leka_label = new MaterialSkin.Controls.MaterialLabel();
            this.ime_leka = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new Pharmacy_APP.AppData();
            this.datum_isteka = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.datum_isteka_label = new MaterialSkin.Controls.MaterialLabel();
            this.kolicina = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.search_label = new MaterialSkin.Controls.MaterialLabel();
            this.Kolicina_label = new MaterialSkin.Controls.MaterialLabel();
            this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imelekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumistekaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_edit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_new = new MaterialSkin.Controls.MaterialFlatButton();
            this.pharmacyTableAdapter = new Pharmacy_APP.AppDataTableAdapters.PharmacyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ime_leka_label
            // 
            this.ime_leka_label.AutoSize = true;
            this.ime_leka_label.Depth = 0;
            this.ime_leka_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.ime_leka_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ime_leka_label.Location = new System.Drawing.Point(30, 78);
            this.ime_leka_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.ime_leka_label.Name = "ime_leka_label";
            this.ime_leka_label.Size = new System.Drawing.Size(66, 19);
            this.ime_leka_label.TabIndex = 0;
            this.ime_leka_label.Text = "Ime leka";
            // 
            // ime_leka
            // 
            this.ime_leka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "ime_leka", true));
            this.ime_leka.Depth = 0;
            this.ime_leka.Hint = "";
            this.ime_leka.Location = new System.Drawing.Point(153, 74);
            this.ime_leka.MouseState = MaterialSkin.MouseState.HOVER;
            this.ime_leka.Name = "ime_leka";
            this.ime_leka.PasswordChar = '\0';
            this.ime_leka.SelectedText = "";
            this.ime_leka.SelectionLength = 0;
            this.ime_leka.SelectionStart = 0;
            this.ime_leka.Size = new System.Drawing.Size(348, 23);
            this.ime_leka.TabIndex = 0;
            this.ime_leka.UseSystemPasswordChar = false;
            // 
            // pharmacyBindingSource
            // 
            this.pharmacyBindingSource.DataMember = "Pharmacy";
            this.pharmacyBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datum_isteka
            // 
            this.datum_isteka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "datum_isteka", true));
            this.datum_isteka.Depth = 0;
            this.datum_isteka.Hint = "";
            this.datum_isteka.Location = new System.Drawing.Point(153, 103);
            this.datum_isteka.MouseState = MaterialSkin.MouseState.HOVER;
            this.datum_isteka.Name = "datum_isteka";
            this.datum_isteka.PasswordChar = '\0';
            this.datum_isteka.SelectedText = "";
            this.datum_isteka.SelectionLength = 0;
            this.datum_isteka.SelectionStart = 0;
            this.datum_isteka.Size = new System.Drawing.Size(348, 23);
            this.datum_isteka.TabIndex = 1;
            this.datum_isteka.UseSystemPasswordChar = false;
            // 
            // datum_isteka_label
            // 
            this.datum_isteka_label.AutoSize = true;
            this.datum_isteka_label.Depth = 0;
            this.datum_isteka_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.datum_isteka_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.datum_isteka_label.Location = new System.Drawing.Point(30, 107);
            this.datum_isteka_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.datum_isteka_label.Name = "datum_isteka_label";
            this.datum_isteka_label.Size = new System.Drawing.Size(98, 19);
            this.datum_isteka_label.TabIndex = 2;
            this.datum_isteka_label.Text = "Datum isteka";
            // 
            // kolicina
            // 
            this.kolicina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource, "kolicina", true));
            this.kolicina.Depth = 0;
            this.kolicina.Hint = "";
            this.kolicina.Location = new System.Drawing.Point(153, 136);
            this.kolicina.MouseState = MaterialSkin.MouseState.HOVER;
            this.kolicina.Name = "kolicina";
            this.kolicina.PasswordChar = '\0';
            this.kolicina.SelectedText = "";
            this.kolicina.SelectionLength = 0;
            this.kolicina.SelectionStart = 0;
            this.kolicina.Size = new System.Drawing.Size(348, 23);
            this.kolicina.TabIndex = 2;
            this.kolicina.UseSystemPasswordChar = false;
            // 
            // search
            // 
            this.search.Depth = 0;
            this.search.Hint = "";
            this.search.Location = new System.Drawing.Point(153, 167);
            this.search.MouseState = MaterialSkin.MouseState.HOVER;
            this.search.Name = "search";
            this.search.PasswordChar = '\0';
            this.search.SelectedText = "";
            this.search.SelectionLength = 0;
            this.search.SelectionStart = 0;
            this.search.Size = new System.Drawing.Size(635, 23);
            this.search.TabIndex = 3;
            this.search.UseSystemPasswordChar = false;
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Depth = 0;
            this.search_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.search_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search_label.Location = new System.Drawing.Point(30, 171);
            this.search_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(55, 19);
            this.search_label.TabIndex = 6;
            this.search_label.Text = "Search";
            this.search_label.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // Kolicina_label
            // 
            this.Kolicina_label.AutoSize = true;
            this.Kolicina_label.Depth = 0;
            this.Kolicina_label.Font = new System.Drawing.Font("Roboto", 11F);
            this.Kolicina_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Kolicina_label.Location = new System.Drawing.Point(30, 140);
            this.Kolicina_label.MouseState = MaterialSkin.MouseState.HOVER;
            this.Kolicina_label.Name = "Kolicina_label";
            this.Kolicina_label.Size = new System.Drawing.Size(63, 19);
            this.Kolicina_label.TabIndex = 4;
            this.Kolicina_label.Text = "Kolicina";
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Depth = 0;
            this.btn_save.Location = new System.Drawing.Point(742, 399);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = false;
            this.btn_save.Size = new System.Drawing.Size(46, 36);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imelekaDataGridViewTextBoxColumn,
            this.datumistekaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pharmacyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 194);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // imelekaDataGridViewTextBoxColumn
            // 
            this.imelekaDataGridViewTextBoxColumn.DataPropertyName = "ime_leka";
            this.imelekaDataGridViewTextBoxColumn.HeaderText = "ime_leka";
            this.imelekaDataGridViewTextBoxColumn.Name = "imelekaDataGridViewTextBoxColumn";
            // 
            // datumistekaDataGridViewTextBoxColumn
            // 
            this.datumistekaDataGridViewTextBoxColumn.DataPropertyName = "datum_isteka";
            this.datumistekaDataGridViewTextBoxColumn.HeaderText = "datum_isteka";
            this.datumistekaDataGridViewTextBoxColumn.Name = "datumistekaDataGridViewTextBoxColumn";
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Location = new System.Drawing.Point(670, 399);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = false;
            this.btn_cancel.Size = new System.Drawing.Size(64, 36);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AutoSize = true;
            this.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_edit.Depth = 0;
            this.btn_edit.Location = new System.Drawing.Point(616, 399);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Primary = false;
            this.btn_edit.Size = new System.Drawing.Size(41, 36);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.AutoSize = true;
            this.btn_new.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_new.Depth = 0;
            this.btn_new.Location = new System.Drawing.Point(562, 399);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_new.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_new.Name = "btn_new";
            this.btn_new.Primary = false;
            this.btn_new.Size = new System.Drawing.Size(42, 36);
            this.btn_new.TabIndex = 4;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // pharmacyTableAdapter
            // 
            this.pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // Apoteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.search);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.kolicina);
            this.Controls.Add(this.Kolicina_label);
            this.Controls.Add(this.datum_isteka);
            this.Controls.Add(this.datum_isteka_label);
            this.Controls.Add(this.ime_leka);
            this.Controls.Add(this.ime_leka_label);
            this.Name = "Apoteka";
            this.Text = "Apoteka";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel ime_leka_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField ime_leka;
        private MaterialSkin.Controls.MaterialSingleLineTextField datum_isteka;
        private MaterialSkin.Controls.MaterialLabel datum_isteka_label;
        private MaterialSkin.Controls.MaterialSingleLineTextField kolicina;
        private MaterialSkin.Controls.MaterialSingleLineTextField search;
        private MaterialSkin.Controls.MaterialLabel search_label;
        private MaterialSkin.Controls.MaterialLabel Kolicina_label;
        private MaterialSkin.Controls.MaterialFlatButton btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
        private MaterialSkin.Controls.MaterialFlatButton btn_edit;
        private MaterialSkin.Controls.MaterialFlatButton btn_new;
        private AppData appData;
        private System.Windows.Forms.BindingSource pharmacyBindingSource;
        private AppDataTableAdapters.PharmacyTableAdapter pharmacyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imelekaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumistekaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}

