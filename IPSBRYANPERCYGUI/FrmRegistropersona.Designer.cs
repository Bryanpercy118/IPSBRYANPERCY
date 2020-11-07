namespace IPSBRYANPERCYGUI
{
    partial class FrmRegistropersona
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtnliquidacion = new System.Windows.Forms.TextBox();
            this.Txtidentificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtsalariopaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtvalorservicio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.combotipoafiliacion = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Afiliacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Liquidacion";
            // 
            // Txtnliquidacion
            // 
            this.Txtnliquidacion.Location = new System.Drawing.Point(144, 63);
            this.Txtnliquidacion.Name = "Txtnliquidacion";
            this.Txtnliquidacion.Size = new System.Drawing.Size(100, 20);
            this.Txtnliquidacion.TabIndex = 3;
            // 
            // Txtidentificacion
            // 
            this.Txtidentificacion.Location = new System.Drawing.Point(144, 103);
            this.Txtidentificacion.Name = "Txtidentificacion";
            this.Txtidentificacion.Size = new System.Drawing.Size(100, 20);
            this.Txtidentificacion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salario Paciente";
            // 
            // Txtsalariopaciente
            // 
            this.Txtsalariopaciente.Location = new System.Drawing.Point(144, 143);
            this.Txtsalariopaciente.Name = "Txtsalariopaciente";
            this.Txtsalariopaciente.Size = new System.Drawing.Size(100, 20);
            this.Txtsalariopaciente.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor del Servicio";
            // 
            // Txtvalorservicio
            // 
            this.Txtvalorservicio.Location = new System.Drawing.Point(144, 189);
            this.Txtvalorservicio.Name = "Txtvalorservicio";
            this.Txtvalorservicio.Size = new System.Drawing.Size(100, 20);
            this.Txtvalorservicio.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Salario Devengado";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // combotipoafiliacion
            // 
            this.combotipoafiliacion.FormattingEnabled = true;
            this.combotipoafiliacion.Items.AddRange(new object[] {
            "Seleccione",
            "Contributivo ",
            "Subsidiado"});
            this.combotipoafiliacion.Location = new System.Drawing.Point(144, 17);
            this.combotipoafiliacion.Name = "combotipoafiliacion";
            this.combotipoafiliacion.Size = new System.Drawing.Size(100, 21);
            this.combotipoafiliacion.TabIndex = 13;
            this.combotipoafiliacion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 37);
            this.button3.TabIndex = 15;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(360, 22);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(103, 20);
            this.txtsalario.TabIndex = 16;
            // 
            // FrmRegistropersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 310);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.combotipoafiliacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txtvalorservicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtsalariopaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtidentificacion);
            this.Controls.Add(this.Txtnliquidacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistropersona";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtnliquidacion;
        private System.Windows.Forms.TextBox Txtidentificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtsalariopaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtvalorservicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combotipoafiliacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtsalario;
    }
}