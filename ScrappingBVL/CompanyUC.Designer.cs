namespace ScrappingBVL
{
    partial class CompanyUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNemonico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCompany = new System.Windows.Forms.DataGridView();
            this.gbCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCompany
            // 
            this.gbCompany.BackColor = System.Drawing.Color.White;
            this.gbCompany.Controls.Add(this.btnCancel);
            this.gbCompany.Controls.Add(this.btnSave);
            this.gbCompany.Controls.Add(this.chkActive);
            this.gbCompany.Controls.Add(this.label4);
            this.gbCompany.Controls.Add(this.tbNemonico);
            this.gbCompany.Controls.Add(this.label3);
            this.gbCompany.Controls.Add(this.cbCategory);
            this.gbCompany.Controls.Add(this.label2);
            this.gbCompany.Controls.Add(this.tbName);
            this.gbCompany.Controls.Add(this.label1);
            this.gbCompany.Controls.Add(this.dgCompany);
            this.gbCompany.Location = new System.Drawing.Point(0, 3);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(830, 426);
            this.gbCompany.TabIndex = 0;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Company";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(735, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(637, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(637, 149);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(15, 14);
            this.chkActive.TabIndex = 8;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Activo:";
            // 
            // tbNemonico
            // 
            this.tbNemonico.Location = new System.Drawing.Point(637, 117);
            this.tbNemonico.Name = "tbNemonico";
            this.tbNemonico.Size = new System.Drawing.Size(173, 20);
            this.tbNemonico.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nemonico:";
            // 
            // cbCategory
            // 
            this.cbCategory.DisplayMember = "Name";
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(637, 46);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(173, 21);
            this.cbCategory.TabIndex = 4;
            this.cbCategory.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(637, 82);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(173, 20);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // dgCompany
            // 
            this.dgCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompany.Location = new System.Drawing.Point(21, 29);
            this.dgCompany.Name = "dgCompany";
            this.dgCompany.Size = new System.Drawing.Size(533, 383);
            this.dgCompany.TabIndex = 0;
            this.dgCompany.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompany_CellDoubleClick);
            // 
            // CompanyUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbCompany);
            this.Name = "CompanyUC";
            this.Size = new System.Drawing.Size(830, 432);
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCompany;
        private System.Windows.Forms.DataGridView dgCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNemonico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
