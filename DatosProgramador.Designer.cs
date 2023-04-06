
namespace Estructura_de_datos2
{
    partial class DatosProgramador
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
            this.label4 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblMateria = new System.Windows.Forms.Label();
            this.LblProfesor = new System.Windows.Forms.Label();
            this.LblDivision = new System.Windows.Forms.Label();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profesor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Division";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNombre.Location = new System.Drawing.Point(156, 26);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(90, 15);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "                           ";
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMateria.Location = new System.Drawing.Point(156, 57);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(90, 15);
            this.LblMateria.TabIndex = 5;
            this.LblMateria.Text = "                           ";
            // 
            // LblProfesor
            // 
            this.LblProfesor.AutoSize = true;
            this.LblProfesor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblProfesor.Location = new System.Drawing.Point(156, 86);
            this.LblProfesor.Name = "LblProfesor";
            this.LblProfesor.Size = new System.Drawing.Size(90, 15);
            this.LblProfesor.TabIndex = 6;
            this.LblProfesor.Text = "                           ";
            // 
            // LblDivision
            // 
            this.LblDivision.AutoSize = true;
            this.LblDivision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDivision.Location = new System.Drawing.Point(156, 118);
            this.LblDivision.Name = "LblDivision";
            this.LblDivision.Size = new System.Drawing.Size(90, 15);
            this.LblDivision.TabIndex = 7;
            this.LblDivision.Text = "                           ";
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(49, 169);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(197, 23);
            this.BtnCargar.TabIndex = 8;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // DatosProgramador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 204);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.LblDivision);
            this.Controls.Add(this.LblProfesor);
            this.Controls.Add(this.LblMateria);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatosProgramador";
            this.Text = "DatosProgramador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblMateria;
        private System.Windows.Forms.Label LblProfesor;
        private System.Windows.Forms.Label LblDivision;
        private System.Windows.Forms.Button BtnCargar;
    }
}