﻿namespace AppRadioButton
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdOpcion1 = new System.Windows.Forms.RadioButton();
            this.rdOpcion2 = new System.Windows.Forms.RadioButton();
            this.rdOpcion3 = new System.Windows.Forms.RadioButton();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdOpcion1
            // 
            this.rdOpcion1.AutoSize = true;
            this.rdOpcion1.Location = new System.Drawing.Point(90, 13);
            this.rdOpcion1.Name = "rdOpcion1";
            this.rdOpcion1.Size = new System.Drawing.Size(72, 17);
            this.rdOpcion1.TabIndex = 0;
            this.rdOpcion1.TabStop = true;
            this.rdOpcion1.Text = "640 x 480";
            this.rdOpcion1.UseVisualStyleBackColor = true;
            // 
            // rdOpcion2
            // 
            this.rdOpcion2.AutoSize = true;
            this.rdOpcion2.Location = new System.Drawing.Point(90, 54);
            this.rdOpcion2.Name = "rdOpcion2";
            this.rdOpcion2.Size = new System.Drawing.Size(72, 17);
            this.rdOpcion2.TabIndex = 1;
            this.rdOpcion2.TabStop = true;
            this.rdOpcion2.Text = "800 x 600";
            this.rdOpcion2.UseVisualStyleBackColor = true;
            // 
            // rdOpcion3
            // 
            this.rdOpcion3.AutoSize = true;
            this.rdOpcion3.Location = new System.Drawing.Point(90, 102);
            this.rdOpcion3.Name = "rdOpcion3";
            this.rdOpcion3.Size = new System.Drawing.Size(78, 17);
            this.rdOpcion3.TabIndex = 2;
            this.rdOpcion3.TabStop = true;
            this.rdOpcion3.Text = "1024 x 768";
            this.rdOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(90, 159);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.rdOpcion3);
            this.Controls.Add(this.rdOpcion2);
            this.Controls.Add(this.rdOpcion1);
            this.Name = "Form1";
            this.Text = "Programa Resoluciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdOpcion1;
        private System.Windows.Forms.RadioButton rdOpcion2;
        private System.Windows.Forms.RadioButton rdOpcion3;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

