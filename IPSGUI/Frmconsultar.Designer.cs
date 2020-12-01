
namespace IPSGUI
{
    partial class Frmconsultar
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
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtContributivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSubsidiado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.CmbTipoAfiliacion = new System.Windows.Forms.ComboBox();
            this.DgvLiquidacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLiquidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 47;
            this.label7.Text = "Tipo de afiliación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "L.Contributivo";
            // 
            // TxtContributivo
            // 
            this.TxtContributivo.Location = new System.Drawing.Point(258, 341);
            this.TxtContributivo.Name = "TxtContributivo";
            this.TxtContributivo.ReadOnly = true;
            this.TxtContributivo.Size = new System.Drawing.Size(49, 20);
            this.TxtContributivo.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "L. Subsidiado";
            // 
            // TxtSubsidiado
            // 
            this.TxtSubsidiado.Location = new System.Drawing.Point(401, 341);
            this.TxtSubsidiado.Name = "TxtSubsidiado";
            this.TxtSubsidiado.ReadOnly = true;
            this.TxtSubsidiado.Size = new System.Drawing.Size(49, 20);
            this.TxtSubsidiado.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Número total de liquidaciones";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(29, 341);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(49, 20);
            this.TxtTotal.TabIndex = 41;
            // 
            // CmbTipoAfiliacion
            // 
            this.CmbTipoAfiliacion.FormattingEnabled = true;
            this.CmbTipoAfiliacion.Items.AddRange(new object[] {
            "Todos",
            "Contributivo",
            "Subsidiado"});
            this.CmbTipoAfiliacion.Location = new System.Drawing.Point(29, 292);
            this.CmbTipoAfiliacion.Name = "CmbTipoAfiliacion";
            this.CmbTipoAfiliacion.Size = new System.Drawing.Size(143, 21);
            this.CmbTipoAfiliacion.TabIndex = 40;
            // 
            // DgvLiquidacion
            // 
            this.DgvLiquidacion.BackgroundColor = System.Drawing.Color.White;
            this.DgvLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLiquidacion.Location = new System.Drawing.Point(12, 12);
            this.DgvLiquidacion.Name = "DgvLiquidacion";
            this.DgvLiquidacion.Size = new System.Drawing.Size(575, 180);
            this.DgvLiquidacion.TabIndex = 39;
            // 
            // Frmconsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(151)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(599, 417);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtContributivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSubsidiado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.CmbTipoAfiliacion);
            this.Controls.Add(this.DgvLiquidacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmconsultar";
            this.Text = "Frmconsultar";
            ((System.ComponentModel.ISupportInitialize)(this.DgvLiquidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtContributivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSubsidiado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.ComboBox CmbTipoAfiliacion;
        private System.Windows.Forms.DataGridView DgvLiquidacion;
    }
}