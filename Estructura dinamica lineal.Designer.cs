
namespace Estructura_de_datos2
{
    partial class Estructura_dinamica_lineal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estructura_dinamica_lineal));
            this.Grb1 = new System.Windows.Forms.GroupBox();
            this.TxtTramite = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grb2 = new System.Windows.Forms.GroupBox();
            this.LblTramite = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Grb3 = new System.Windows.Forms.GroupBox();
            this.LstLista = new System.Windows.Forms.ListBox();
            this.DgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Grb1.SuspendLayout();
            this.Grb2.SuspendLayout();
            this.Grb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // Grb1
            // 
            this.Grb1.Controls.Add(this.TxtTramite);
            this.Grb1.Controls.Add(this.TxtNombre);
            this.Grb1.Controls.Add(this.TxtCodigo);
            this.Grb1.Controls.Add(this.BtnAgregar);
            this.Grb1.Controls.Add(this.label3);
            this.Grb1.Controls.Add(this.label2);
            this.Grb1.Controls.Add(this.label1);
            this.Grb1.Location = new System.Drawing.Point(222, 22);
            this.Grb1.Name = "Grb1";
            this.Grb1.Size = new System.Drawing.Size(259, 206);
            this.Grb1.TabIndex = 0;
            this.Grb1.TabStop = false;
            this.Grb1.Text = "Nuevo Elemento";
            // 
            // TxtTramite
            // 
            this.TxtTramite.Location = new System.Drawing.Point(111, 107);
            this.TxtTramite.Name = "TxtTramite";
            this.TxtTramite.Size = new System.Drawing.Size(121, 20);
            this.TxtTramite.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(111, 65);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(121, 20);
            this.TxtNombre.TabIndex = 5;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(111, 29);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(121, 20);
            this.TxtCodigo.TabIndex = 4;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(84, 147);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(99, 34);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tramite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // Grb2
            // 
            this.Grb2.Controls.Add(this.LblTramite);
            this.Grb2.Controls.Add(this.LblNombre);
            this.Grb2.Controls.Add(this.LblCodigo);
            this.Grb2.Controls.Add(this.BtnEliminar);
            this.Grb2.Controls.Add(this.label4);
            this.Grb2.Controls.Add(this.label5);
            this.Grb2.Controls.Add(this.label6);
            this.Grb2.Location = new System.Drawing.Point(487, 22);
            this.Grb2.Name = "Grb2";
            this.Grb2.Size = new System.Drawing.Size(259, 206);
            this.Grb2.TabIndex = 1;
            this.Grb2.TabStop = false;
            this.Grb2.Text = "Elemento Eliminado";
            // 
            // LblTramite
            // 
            this.LblTramite.AutoSize = true;
            this.LblTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTramite.Location = new System.Drawing.Point(144, 110);
            this.LblTramite.Name = "LblTramite";
            this.LblTramite.Size = new System.Drawing.Size(90, 19);
            this.LblTramite.TabIndex = 8;
            this.LblTramite.Text = "                    ";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(144, 68);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(90, 19);
            this.LblNombre.TabIndex = 7;
            this.LblNombre.Text = "                    ";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(144, 32);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(90, 19);
            this.LblCodigo.TabIndex = 6;
            this.LblCodigo.Text = "                    ";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(78, 147);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(99, 34);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tramite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Codigo";
            // 
            // Grb3
            // 
            this.Grb3.Controls.Add(this.LstLista);
            this.Grb3.Controls.Add(this.DgvGrilla);
            this.Grb3.Location = new System.Drawing.Point(12, 246);
            this.Grb3.Name = "Grb3";
            this.Grb3.Size = new System.Drawing.Size(734, 246);
            this.Grb3.TabIndex = 2;
            this.Grb3.TabStop = false;
            this.Grb3.Text = "Listado en una lista y una grilla";
            // 
            // LstLista
            // 
            this.LstLista.FormattingEnabled = true;
            this.LstLista.Location = new System.Drawing.Point(6, 29);
            this.LstLista.Name = "LstLista";
            this.LstLista.Size = new System.Drawing.Size(214, 199);
            this.LstLista.TabIndex = 1;
            // 
            // DgvGrilla
            // 
            this.DgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvGrilla.Location = new System.Drawing.Point(226, 33);
            this.DgvGrilla.Name = "DgvGrilla";
            this.DgvGrilla.Size = new System.Drawing.Size(502, 195);
            this.DgvGrilla.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "unage.jfif");
            this.imageList1.Images.SetKeyName(1, "unage.jfif");
            // 
            // Estructura_dinamica_lineal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 504);
            this.Controls.Add(this.Grb3);
            this.Controls.Add(this.Grb2);
            this.Controls.Add(this.Grb1);
            this.Name = "Estructura_dinamica_lineal";
            this.Text = "Estructura_dinamica_lineal";
            this.Grb1.ResumeLayout(false);
            this.Grb1.PerformLayout();
            this.Grb2.ResumeLayout(false);
            this.Grb2.PerformLayout();
            this.Grb3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grb1;
        private System.Windows.Forms.GroupBox Grb2;
        private System.Windows.Forms.GroupBox Grb3;
        private System.Windows.Forms.DataGridView DgvGrilla;
        private System.Windows.Forms.ListBox LstLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox TxtTramite;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTramite;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
    }
}