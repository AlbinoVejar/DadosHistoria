namespace DadosDibujos
{
    partial class Form1
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
            this.pnlRol = new System.Windows.Forms.Panel();
            this.pnlSujeto = new System.Windows.Forms.Panel();
            this.pnlHerramienta = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlRol
            // 
            this.pnlRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRol.AutoSize = true;
            this.pnlRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRol.Location = new System.Drawing.Point(33, 34);
            this.pnlRol.Name = "pnlRol";
            this.pnlRol.Size = new System.Drawing.Size(200, 232);
            this.pnlRol.TabIndex = 0;
            // 
            // pnlSujeto
            // 
            this.pnlSujeto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSujeto.AutoSize = true;
            this.pnlSujeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlSujeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSujeto.Location = new System.Drawing.Point(306, 34);
            this.pnlSujeto.Name = "pnlSujeto";
            this.pnlSujeto.Size = new System.Drawing.Size(200, 232);
            this.pnlSujeto.TabIndex = 1;
            // 
            // pnlHerramienta
            // 
            this.pnlHerramienta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHerramienta.AutoSize = true;
            this.pnlHerramienta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlHerramienta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHerramienta.Location = new System.Drawing.Point(576, 34);
            this.pnlHerramienta.Name = "pnlHerramienta";
            this.pnlHerramienta.Size = new System.Drawing.Size(200, 232);
            this.pnlHerramienta.TabIndex = 2;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(336, 315);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(138, 31);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.GenerarHistoria);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(352, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 31);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.Salir);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Herramienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.pnlHerramienta);
            this.Controls.Add(this.pnlSujeto);
            this.Controls.Add(this.pnlRol);
            this.Name = "Form1";
            this.Text = "Dados de Dibujos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRol;
        private System.Windows.Forms.Panel pnlSujeto;
        private System.Windows.Forms.Panel pnlHerramienta;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

