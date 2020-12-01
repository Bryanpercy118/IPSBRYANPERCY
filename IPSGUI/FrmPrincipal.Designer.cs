
namespace IPSGUI
{
    partial class FrmPrincipal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btoningresar = new FontAwesome.Sharp.IconButton();
            this.btonconsulta = new FontAwesome.Sharp.IconButton();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtonHome = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(80)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 53);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(151)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.BtonHome);
            this.panel1.Controls.Add(this.btonconsulta);
            this.panel1.Controls.Add(this.btoningresar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 417);
            this.panel1.TabIndex = 4;
            // 
            // btoningresar
            // 
            this.btoningresar.FlatAppearance.BorderSize = 0;
            this.btoningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btoningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoningresar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btoningresar.IconChar = FontAwesome.Sharp.IconChar.Male;
            this.btoningresar.IconColor = System.Drawing.Color.LightGray;
            this.btoningresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btoningresar.IconSize = 30;
            this.btoningresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoningresar.Location = new System.Drawing.Point(0, 121);
            this.btoningresar.Name = "btoningresar";
            this.btoningresar.Size = new System.Drawing.Size(153, 38);
            this.btoningresar.TabIndex = 0;
            this.btoningresar.Text = "Ingresar";
            this.btoningresar.UseVisualStyleBackColor = true;
            this.btoningresar.Click += new System.EventHandler(this.btoningresar_Click);
            // 
            // btonconsulta
            // 
            this.btonconsulta.FlatAppearance.BorderSize = 0;
            this.btonconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonconsulta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btonconsulta.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btonconsulta.IconColor = System.Drawing.Color.LightGray;
            this.btonconsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btonconsulta.IconSize = 30;
            this.btonconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btonconsulta.Location = new System.Drawing.Point(3, 196);
            this.btonconsulta.Name = "btonconsulta";
            this.btonconsulta.Size = new System.Drawing.Size(150, 38);
            this.btonconsulta.TabIndex = 1;
            this.btonconsulta.Text = "Consultar";
            this.btonconsulta.UseVisualStyleBackColor = true;
            this.btonconsulta.Click += new System.EventHandler(this.btonconsulta_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(151)))), ((int)(((byte)(164)))));
            this.panelcontenedor.Location = new System.Drawing.Point(155, 53);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(599, 417);
            this.panelcontenedor.TabIndex = 5;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontenedor_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPS MAS SALUD, MAS VIDA";
            // 
            // BtonHome
            // 
            this.BtonHome.FlatAppearance.BorderSize = 0;
            this.BtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtonHome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtonHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.BtonHome.IconColor = System.Drawing.Color.LightGray;
            this.BtonHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtonHome.Location = new System.Drawing.Point(0, 35);
            this.BtonHome.Name = "BtonHome";
            this.BtonHome.Size = new System.Drawing.Size(156, 45);
            this.BtonHome.TabIndex = 8;
            this.BtonHome.Text = "Casa";
            this.BtonHome.UseVisualStyleBackColor = true;
            this.BtonHome.Click += new System.EventHandler(this.BtonHome_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 470);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btonconsulta;
        private FontAwesome.Sharp.IconButton btoningresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelcontenedor;
        private FontAwesome.Sharp.IconButton BtonHome;
    }
}

