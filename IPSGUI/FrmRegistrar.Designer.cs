
namespace IPSGUI
{
    partial class FrmRegistrar
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
            this.TxtValorHospitalizacion = new System.Windows.Forms.TextBox();
            this.TxtSalarioDevengado = new System.Windows.Forms.TextBox();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.DtpFechaLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.CmbTipoAfiliacion = new System.Windows.Forms.ComboBox();
            this.TxtNumeroLiquidacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btonguardar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // TxtValorHospitalizacion
            // 
            this.TxtValorHospitalizacion.Location = new System.Drawing.Point(222, 251);
            this.TxtValorHospitalizacion.Name = "TxtValorHospitalizacion";
            this.TxtValorHospitalizacion.Size = new System.Drawing.Size(138, 20);
            this.TxtValorHospitalizacion.TabIndex = 47;
            // 
            // TxtSalarioDevengado
            // 
            this.TxtSalarioDevengado.Location = new System.Drawing.Point(222, 205);
            this.TxtSalarioDevengado.Name = "TxtSalarioDevengado";
            this.TxtSalarioDevengado.Size = new System.Drawing.Size(138, 20);
            this.TxtSalarioDevengado.TabIndex = 46;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(222, 21);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(138, 20);
            this.TxtIdentificacion.TabIndex = 45;
            this.TxtIdentificacion.TextChanged += new System.EventHandler(this.TxtIdentificacion_TextChanged);
            // 
            // DtpFechaLiquidacion
            // 
            this.DtpFechaLiquidacion.Location = new System.Drawing.Point(178, 114);
            this.DtpFechaLiquidacion.Name = "DtpFechaLiquidacion";
            this.DtpFechaLiquidacion.Size = new System.Drawing.Size(209, 20);
            this.DtpFechaLiquidacion.TabIndex = 44;
            // 
            // CmbTipoAfiliacion
            // 
            this.CmbTipoAfiliacion.FormattingEnabled = true;
            this.CmbTipoAfiliacion.Items.AddRange(new object[] {
            "Contributivo",
            "Subsidiado"});
            this.CmbTipoAfiliacion.Location = new System.Drawing.Point(222, 158);
            this.CmbTipoAfiliacion.Name = "CmbTipoAfiliacion";
            this.CmbTipoAfiliacion.Size = new System.Drawing.Size(138, 21);
            this.CmbTipoAfiliacion.TabIndex = 43;
            // 
            // TxtNumeroLiquidacion
            // 
            this.TxtNumeroLiquidacion.Location = new System.Drawing.Point(222, 67);
            this.TxtNumeroLiquidacion.Name = "TxtNumeroLiquidacion";
            this.TxtNumeroLiquidacion.Size = new System.Drawing.Size(138, 20);
            this.TxtNumeroLiquidacion.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Valor Servicio Hospitalización";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Fecha Liquidación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Idetificación Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tipo de afiliación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Salario devengado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Número Liquidación";
            // 
            // btonguardar
            // 
            this.btonguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btonguardar.FlatAppearance.BorderSize = 0;
            this.btonguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btonguardar.IconColor = System.Drawing.Color.Black;
            this.btonguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btonguardar.IconSize = 25;
            this.btonguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btonguardar.Location = new System.Drawing.Point(421, 25);
            this.btonguardar.Name = "btonguardar";
            this.btonguardar.Size = new System.Drawing.Size(166, 31);
            this.btonguardar.TabIndex = 49;
            this.btonguardar.Text = "Guardar";
            this.btonguardar.UseVisualStyleBackColor = false;
            this.btonguardar.Click += new System.EventHandler(this.btonguardar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(421, 120);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(166, 34);
            this.iconButton1.TabIndex = 50;
            this.iconButton1.Text = "Eliminar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(421, 74);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(166, 34);
            this.iconButton2.TabIndex = 51;
            this.iconButton2.Text = "Modificar";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(27, 302);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(166, 34);
            this.iconButton3.TabIndex = 52;
            this.iconButton3.Text = "Limpiar";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(151)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(599, 417);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btonguardar);
            this.Controls.Add(this.TxtValorHospitalizacion);
            this.Controls.Add(this.TxtSalarioDevengado);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.DtpFechaLiquidacion);
            this.Controls.Add(this.CmbTipoAfiliacion);
            this.Controls.Add(this.TxtNumeroLiquidacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrar";
            this.Text = "FrmRegistrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtValorHospitalizacion;
        private System.Windows.Forms.TextBox TxtSalarioDevengado;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.DateTimePicker DtpFechaLiquidacion;
        private System.Windows.Forms.ComboBox CmbTipoAfiliacion;
        private System.Windows.Forms.TextBox TxtNumeroLiquidacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btonguardar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}