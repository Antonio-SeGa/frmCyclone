
namespace frmCyclone
{
    partial class frmExploiter
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodExploiter = new System.Windows.Forms.TextBox();
            this.txtCodEmpleado = new System.Windows.Forms.TextBox();
            this.cbxNivelAcceso = new System.Windows.Forms.ComboBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtPassUsuario = new System.Windows.Forms.TextBox();
            this.cbxEstatus = new System.Windows.Forms.ComboBox();
            this.btnAgregaExploiter = new System.Windows.Forms.Button();
            this.btnActualizaExploiter = new System.Windows.Forms.Button();
            this.btnEliminaExploiter = new System.Windows.Forms.Button();
            this.btnReporteExploiter = new System.Windows.Forms.Button();
            this.dgvExploiter = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExploiter)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.83333F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCodExploiter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCodEmpleado, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxNivelAcceso, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNomUsuario, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPassUsuario, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxEstatus, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregaExploiter, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnActualizaExploiter, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEliminaExploiter, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReporteExploiter, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.12644F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.87356F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 277);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Exploiter";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo del Empleado";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel del Exploiter";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre del Exploiter";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña del Exploiter";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Activo";
            // 
            // txtCodExploiter
            // 
            this.txtCodExploiter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodExploiter.Location = new System.Drawing.Point(109, 11);
            this.txtCodExploiter.Name = "txtCodExploiter";
            this.txtCodExploiter.Size = new System.Drawing.Size(121, 20);
            this.txtCodExploiter.TabIndex = 6;
            // 
            // txtCodEmpleado
            // 
            this.txtCodEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodEmpleado.Location = new System.Drawing.Point(109, 57);
            this.txtCodEmpleado.Name = "txtCodEmpleado";
            this.txtCodEmpleado.Size = new System.Drawing.Size(121, 20);
            this.txtCodEmpleado.TabIndex = 7;
            // 
            // cbxNivelAcceso
            // 
            this.cbxNivelAcceso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxNivelAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNivelAcceso.FormattingEnabled = true;
            this.cbxNivelAcceso.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.cbxNivelAcceso.Location = new System.Drawing.Point(109, 107);
            this.cbxNivelAcceso.Name = "cbxNivelAcceso";
            this.cbxNivelAcceso.Size = new System.Drawing.Size(121, 21);
            this.cbxNivelAcceso.TabIndex = 8;
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNomUsuario.Location = new System.Drawing.Point(109, 156);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtNomUsuario.TabIndex = 9;
            // 
            // txtPassUsuario
            // 
            this.txtPassUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassUsuario.Location = new System.Drawing.Point(109, 201);
            this.txtPassUsuario.Name = "txtPassUsuario";
            this.txtPassUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtPassUsuario.TabIndex = 10;
            // 
            // cbxEstatus
            // 
            this.cbxEstatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstatus.FormattingEnabled = true;
            this.cbxEstatus.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbxEstatus.Location = new System.Drawing.Point(109, 245);
            this.cbxEstatus.Name = "cbxEstatus";
            this.cbxEstatus.Size = new System.Drawing.Size(121, 21);
            this.cbxEstatus.TabIndex = 11;
            // 
            // btnAgregaExploiter
            // 
            this.btnAgregaExploiter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregaExploiter.Location = new System.Drawing.Point(241, 10);
            this.btnAgregaExploiter.Name = "btnAgregaExploiter";
            this.btnAgregaExploiter.Size = new System.Drawing.Size(75, 23);
            this.btnAgregaExploiter.TabIndex = 12;
            this.btnAgregaExploiter.Text = "Agregar";
            this.btnAgregaExploiter.UseVisualStyleBackColor = true;
            this.btnAgregaExploiter.Click += new System.EventHandler(this.btnAgregaExploiter_Click);
            // 
            // btnActualizaExploiter
            // 
            this.btnActualizaExploiter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizaExploiter.Location = new System.Drawing.Point(241, 55);
            this.btnActualizaExploiter.Name = "btnActualizaExploiter";
            this.btnActualizaExploiter.Size = new System.Drawing.Size(75, 23);
            this.btnActualizaExploiter.TabIndex = 13;
            this.btnActualizaExploiter.Text = "Actualizar";
            this.btnActualizaExploiter.UseVisualStyleBackColor = true;
            this.btnActualizaExploiter.Click += new System.EventHandler(this.btnActualizaExploiter_Click);
            // 
            // btnEliminaExploiter
            // 
            this.btnEliminaExploiter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminaExploiter.Location = new System.Drawing.Point(241, 106);
            this.btnEliminaExploiter.Name = "btnEliminaExploiter";
            this.btnEliminaExploiter.Size = new System.Drawing.Size(75, 23);
            this.btnEliminaExploiter.TabIndex = 14;
            this.btnEliminaExploiter.Text = "Eliminar";
            this.btnEliminaExploiter.UseVisualStyleBackColor = true;
            this.btnEliminaExploiter.Click += new System.EventHandler(this.btnEliminaExploiter_Click);
            // 
            // btnReporteExploiter
            // 
            this.btnReporteExploiter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReporteExploiter.Location = new System.Drawing.Point(241, 244);
            this.btnReporteExploiter.Name = "btnReporteExploiter";
            this.btnReporteExploiter.Size = new System.Drawing.Size(75, 23);
            this.btnReporteExploiter.TabIndex = 15;
            this.btnReporteExploiter.Text = "Reporte";
            this.btnReporteExploiter.UseVisualStyleBackColor = true;
            this.btnReporteExploiter.Click += new System.EventHandler(this.btnReporteExploiter_Click);
            // 
            // dgvExploiter
            // 
            this.dgvExploiter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvExploiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExploiter.Location = new System.Drawing.Point(361, 26);
            this.dgvExploiter.Name = "dgvExploiter";
            this.dgvExploiter.Size = new System.Drawing.Size(472, 303);
            this.dgvExploiter.TabIndex = 1;
            this.dgvExploiter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExploiter_CellClick);
            // 
            // frmExploiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 341);
            this.Controls.Add(this.dgvExploiter);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmExploiter";
            this.Text = "Registro de Explotadores de Datos";
            this.Load += new System.EventHandler(this.frmExploiter_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExploiter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvExploiter;
        private System.Windows.Forms.TextBox txtCodExploiter;
        private System.Windows.Forms.TextBox txtCodEmpleado;
        private System.Windows.Forms.ComboBox cbxNivelAcceso;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtPassUsuario;
        private System.Windows.Forms.ComboBox cbxEstatus;
        private System.Windows.Forms.Button btnAgregaExploiter;
        private System.Windows.Forms.Button btnActualizaExploiter;
        private System.Windows.Forms.Button btnEliminaExploiter;
        private System.Windows.Forms.Button btnReporteExploiter;
    }
}

