
namespace WinFormActDataEniax
{
    partial class Frm_Proceso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dT_fecFin = new System.Windows.Forms.DateTimePicker();
            this.dT_fecIni = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lbl_proceso = new System.Windows.Forms.Label();
            this.btn_Ejec = new System.Windows.Forms.Button();
            this.lbl_fecFin = new System.Windows.Forms.Label();
            this.lbl_fecInicio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_titulo);
            this.groupBox1.Controls.Add(this.dT_fecFin);
            this.groupBox1.Controls.Add(this.dT_fecIni);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.lbl_proceso);
            this.groupBox1.Controls.Add(this.btn_Ejec);
            this.groupBox1.Controls.Add(this.lbl_fecFin);
            this.groupBox1.Controls.Add(this.lbl_fecInicio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(87, 16);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(364, 24);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Reproceso Proceso Integración Eniax";
            // 
            // dT_fecFin
            // 
            this.dT_fecFin.CustomFormat = "dd/MM/yyyy  HH:mm";
            this.dT_fecFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dT_fecFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dT_fecFin.Location = new System.Drawing.Point(150, 118);
            this.dT_fecFin.Name = "dT_fecFin";
            this.dT_fecFin.Size = new System.Drawing.Size(232, 22);
            this.dT_fecFin.TabIndex = 6;
            // 
            // dT_fecIni
            // 
            this.dT_fecIni.CustomFormat = "dd/MM/yyyy   HH:mm";
            this.dT_fecIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dT_fecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dT_fecIni.Location = new System.Drawing.Point(150, 74);
            this.dT_fecIni.Name = "dT_fecIni";
            this.dT_fecIni.Size = new System.Drawing.Size(232, 22);
            this.dT_fecIni.TabIndex = 5;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(150, 158);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(232, 24);
            this.cmbEstado.TabIndex = 4;
            // 
            // lbl_proceso
            // 
            this.lbl_proceso.AutoSize = true;
            this.lbl_proceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proceso.Location = new System.Drawing.Point(36, 163);
            this.lbl_proceso.Name = "lbl_proceso";
            this.lbl_proceso.Size = new System.Drawing.Size(59, 16);
            this.lbl_proceso.TabIndex = 3;
            this.lbl_proceso.Text = "Proceso";
            // 
            // btn_Ejec
            // 
            this.btn_Ejec.Location = new System.Drawing.Point(160, 242);
            this.btn_Ejec.Name = "btn_Ejec";
            this.btn_Ejec.Size = new System.Drawing.Size(213, 34);
            this.btn_Ejec.TabIndex = 2;
            this.btn_Ejec.Text = "Ejecutar";
            this.btn_Ejec.UseVisualStyleBackColor = true;
            this.btn_Ejec.Click += new System.EventHandler(this.btn_Ejec_Click);
            // 
            // lbl_fecFin
            // 
            this.lbl_fecFin.AutoSize = true;
            this.lbl_fecFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecFin.Location = new System.Drawing.Point(36, 122);
            this.lbl_fecFin.Name = "lbl_fecFin";
            this.lbl_fecFin.Size = new System.Drawing.Size(85, 16);
            this.lbl_fecFin.TabIndex = 1;
            this.lbl_fecFin.Text = "Fecha Fin (<)";
            // 
            // lbl_fecInicio
            // 
            this.lbl_fecInicio.AutoSize = true;
            this.lbl_fecInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecInicio.Location = new System.Drawing.Point(36, 78);
            this.lbl_fecInicio.Name = "lbl_fecInicio";
            this.lbl_fecInicio.Size = new System.Drawing.Size(105, 16);
            this.lbl_fecInicio.TabIndex = 0;
            this.lbl_fecInicio.Text = "Fecha Inicio (>=)";
            // 
            // Frm_Proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 357);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Proceso";
            this.Text = "Ejecutar Proceso";
            this.Load += new System.EventHandler(this.Frm_Proceso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lbl_proceso;
        private System.Windows.Forms.Button btn_Ejec;
        private System.Windows.Forms.Label lbl_fecFin;
        private System.Windows.Forms.Label lbl_fecInicio;
        private System.Windows.Forms.DateTimePicker dT_fecFin;
        private System.Windows.Forms.DateTimePicker dT_fecIni;
        private System.Windows.Forms.Label lbl_titulo;
    }
}

