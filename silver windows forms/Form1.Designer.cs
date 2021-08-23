
namespace silver_windows_forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.janelona = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.janelinha = new System.Windows.Forms.PictureBox();
            this.botaoFechar = new System.Windows.Forms.PictureBox();
            this.MenuVartical = new System.Windows.Forms.Panel();
            this.PainelControlador = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.janelona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelinha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.janelona);
            this.BarraTitulo.Controls.Add(this.minimizar);
            this.BarraTitulo.Controls.Add(this.janelinha);
            this.BarraTitulo.Controls.Add(this.botaoFechar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            // 
            // janelona
            // 
            this.janelona.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.janelona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.janelona.Image = ((System.Drawing.Image)(resources.GetObject("janelona.Image")));
            this.janelona.Location = new System.Drawing.Point(1187, -8);
            this.janelona.Name = "janelona";
            this.janelona.Size = new System.Drawing.Size(49, 56);
            this.janelona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.janelona.TabIndex = 3;
            this.janelona.TabStop = false;
            this.janelona.Click += new System.EventHandler(this.janelona_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1139, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(34, 32);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 2;
            this.minimizar.TabStop = false;
            // 
            // janelinha
            // 
            this.janelinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.janelinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.janelinha.Image = ((System.Drawing.Image)(resources.GetObject("janelinha.Image")));
            this.janelinha.Location = new System.Drawing.Point(1179, 0);
            this.janelinha.Name = "janelinha";
            this.janelinha.Size = new System.Drawing.Size(57, 38);
            this.janelinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.janelinha.TabIndex = 1;
            this.janelinha.TabStop = false;
            this.janelinha.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // botaoFechar
            // 
            this.botaoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoFechar.Image = ((System.Drawing.Image)(resources.GetObject("botaoFechar.Image")));
            this.botaoFechar.Location = new System.Drawing.Point(1233, -8);
            this.botaoFechar.Name = "botaoFechar";
            this.botaoFechar.Size = new System.Drawing.Size(55, 54);
            this.botaoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botaoFechar.TabIndex = 0;
            this.botaoFechar.TabStop = false;
            this.botaoFechar.Click += new System.EventHandler(this.botaoFechar_Click);
            // 
            // MenuVartical
            // 
            this.MenuVartical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVartical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVartical.Location = new System.Drawing.Point(0, 38);
            this.MenuVartical.Name = "MenuVartical";
            this.MenuVartical.Size = new System.Drawing.Size(220, 612);
            this.MenuVartical.TabIndex = 1;
            // 
            // PainelControlador
            // 
            this.PainelControlador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PainelControlador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelControlador.Location = new System.Drawing.Point(220, 38);
            this.PainelControlador.Name = "PainelControlador";
            this.PainelControlador.Size = new System.Drawing.Size(1080, 612);
            this.PainelControlador.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PainelControlador);
            this.Controls.Add(this.MenuVartical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.janelona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.janelinha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botaoFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox botaoFechar;
        private System.Windows.Forms.Panel MenuVartical;
        private System.Windows.Forms.Panel PainelControlador;
        private System.Windows.Forms.PictureBox janelinha;
        private System.Windows.Forms.PictureBox janelona;
        private System.Windows.Forms.PictureBox minimizar;
    }
}

