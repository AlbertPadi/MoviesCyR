﻿namespace MoviesCyR
{
    partial class FormRegistro
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.textBoxCalificacion = new System.Windows.Forms.TextBox();
            this.textBoxIMDB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCategoriaId = new System.Windows.Forms.TextBox();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.OpenpictureBox = new System.Windows.Forms.PictureBox();
            this.OpenopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.OpenpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IMDB";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(99, 19);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(242, 20);
            this.textBoxTitulo.TabIndex = 5;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.textBoxTitulo_TextChanged);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(99, 60);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(242, 20);
            this.textBoxDescripcion.TabIndex = 6;
            // 
            // textBoxAno
            // 
            this.textBoxAno.Location = new System.Drawing.Point(99, 117);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(108, 20);
            this.textBoxAno.TabIndex = 7;
            // 
            // textBoxCalificacion
            // 
            this.textBoxCalificacion.Location = new System.Drawing.Point(99, 173);
            this.textBoxCalificacion.Name = "textBoxCalificacion";
            this.textBoxCalificacion.Size = new System.Drawing.Size(108, 20);
            this.textBoxCalificacion.TabIndex = 8;
            // 
            // textBoxIMDB
            // 
            this.textBoxIMDB.Location = new System.Drawing.Point(99, 226);
            this.textBoxIMDB.Name = "textBoxIMDB";
            this.textBoxIMDB.Size = new System.Drawing.Size(108, 20);
            this.textBoxIMDB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Categoria Id";
            // 
            // textBoxCategoriaId
            // 
            this.textBoxCategoriaId.Location = new System.Drawing.Point(99, 266);
            this.textBoxCategoriaId.Name = "textBoxCategoriaId";
            this.textBoxCategoriaId.Size = new System.Drawing.Size(108, 20);
            this.textBoxCategoriaId.TabIndex = 15;
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Image = global::MoviesCyR.Properties.Resources.Lapiz;
            this.Actualizarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Actualizarbutton.Location = new System.Drawing.Point(284, 306);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(75, 43);
            this.Actualizarbutton.TabIndex = 17;
            this.Actualizarbutton.Text = "Actualizar";
            this.Actualizarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // button1
            // 
            this.button1.Image = global::MoviesCyR.Properties.Resources._1444674093_folder_search;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(409, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "Abrir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Image = global::MoviesCyR.Properties.Resources._1444681843_Gnome_Edit_Clear_64;
            this.buttonLimpiar.Location = new System.Drawing.Point(154, 306);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 43);
            this.buttonLimpiar.TabIndex = 13;
            this.buttonLimpiar.Text = "Lompiar";
            this.buttonLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Image = global::MoviesCyR.Properties.Resources._1441773161_save;
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGuardar.Location = new System.Drawing.Point(13, 306);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 43);
            this.buttonGuardar.TabIndex = 11;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // OpenpictureBox
            // 
            this.OpenpictureBox.Location = new System.Drawing.Point(213, 87);
            this.OpenpictureBox.Name = "OpenpictureBox";
            this.OpenpictureBox.Size = new System.Drawing.Size(307, 199);
            this.OpenpictureBox.TabIndex = 18;
            this.OpenpictureBox.TabStop = false;
            // 
            // OpenopenFileDialog
            // 
            this.OpenopenFileDialog.FileName = "AbriropenFileDialog";
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 352);
            this.Controls.Add(this.OpenpictureBox);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCategoriaId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxIMDB);
            this.Controls.Add(this.textBoxCalificacion);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OpenpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.TextBox textBoxCalificacion;
        private System.Windows.Forms.TextBox textBoxIMDB;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCategoriaId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Actualizarbutton;
        private System.Windows.Forms.PictureBox OpenpictureBox;
        private System.Windows.Forms.OpenFileDialog OpenopenFileDialog;
    }
}

