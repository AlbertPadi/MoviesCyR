namespace MoviesCyR
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Estudiosbutton = new System.Windows.Forms.Button();
            this.Actoresbutton = new System.Windows.Forms.Button();
            this.Generosbutton = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.hacercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // hacercaDeToolStripMenuItem
            // 
            this.hacercaDeToolStripMenuItem.Name = "hacercaDeToolStripMenuItem";
            this.hacercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hacercaDeToolStripMenuItem.Text = "Acerca de";
            this.hacercaDeToolStripMenuItem.Click += new System.EventHandler(this.hacercaDeToolStripMenuItem_Click);
            // 
            // Estudiosbutton
            // 
            this.Estudiosbutton.Image = global::MoviesCyR.Properties.Resources.movies;
            this.Estudiosbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Estudiosbutton.Location = new System.Drawing.Point(17, 125);
            this.Estudiosbutton.Name = "Estudiosbutton";
            this.Estudiosbutton.Size = new System.Drawing.Size(94, 47);
            this.Estudiosbutton.TabIndex = 10;
            this.Estudiosbutton.Text = "Estudios";
            this.Estudiosbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Estudiosbutton.UseVisualStyleBackColor = true;
            this.Estudiosbutton.Click += new System.EventHandler(this.Estudiosbutton_Click);
            // 
            // Actoresbutton
            // 
            this.Actoresbutton.Image = global::MoviesCyR.Properties.Resources.Actor_Male_Light;
            this.Actoresbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Actoresbutton.Location = new System.Drawing.Point(144, 125);
            this.Actoresbutton.Name = "Actoresbutton";
            this.Actoresbutton.Size = new System.Drawing.Size(94, 47);
            this.Actoresbutton.TabIndex = 7;
            this.Actoresbutton.Text = "Actores";
            this.Actoresbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Actoresbutton.UseVisualStyleBackColor = true;
            this.Actoresbutton.Click += new System.EventHandler(this.Actoresbutton_Click);
            // 
            // Generosbutton
            // 
            this.Generosbutton.Image = global::MoviesCyR.Properties.Resources._1444503163_video;
            this.Generosbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Generosbutton.Location = new System.Drawing.Point(261, 125);
            this.Generosbutton.Name = "Generosbutton";
            this.Generosbutton.Size = new System.Drawing.Size(94, 47);
            this.Generosbutton.TabIndex = 6;
            this.Generosbutton.Text = "Generos";
            this.Generosbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Generosbutton.UseVisualStyleBackColor = true;
            this.Generosbutton.Click += new System.EventHandler(this.Generosbutton_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Image = global::MoviesCyR.Properties.Resources._1444067756_1_04;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(261, 178);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(94, 48);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = global::MoviesCyR.Properties.Resources._1443813953_cancel;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.Location = new System.Drawing.Point(374, 178);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 48);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Image = global::MoviesCyR.Properties.Resources._1443814210_fine_print;
            this.buttonConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonConsultar.Location = new System.Drawing.Point(139, 178);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(99, 48);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Image = global::MoviesCyR.Properties.Resources._1441773161_save;
            this.buttonRegistrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRegistrar.Location = new System.Drawing.Point(12, 178);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(99, 48);
            this.buttonRegistrar.TabIndex = 1;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MoviesCyR.Properties.Resources.cine1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 226);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::MoviesCyR.Properties.Resources._1443814210_fine_print;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(374, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reporte";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Estudiosbutton);
            this.Controls.Add(this.Actoresbutton);
            this.Controls.Add(this.Generosbutton);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacercaDeToolStripMenuItem;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button Generosbutton;
        private System.Windows.Forms.Button Actoresbutton;
        private System.Windows.Forms.Button Estudiosbutton;
        private System.Windows.Forms.Button button1;
    }
}