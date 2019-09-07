namespace SaberSiEsMayorDeEdad
{
    partial class Form1
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
            this.lblmayorono = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIr = new System.Windows.Forms.Button();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblmayorono
            // 
            this.lblmayorono.AutoSize = true;
            this.lblmayorono.Location = new System.Drawing.Point(381, 203);
            this.lblmayorono.Name = "lblmayorono";
            this.lblmayorono.Size = new System.Drawing.Size(35, 13);
            this.lblmayorono.TabIndex = 1;
            this.lblmayorono.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite su edad:";
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(462, 155);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 23);
            this.btnIr.TabIndex = 3;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(356, 160);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmayorono);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblmayorono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.TextBox txtedad;
    }
}

