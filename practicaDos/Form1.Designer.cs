namespace practicaDos
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lstBoxImage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(558, 374);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 53);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(305, 374);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(129, 53);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver Imagen";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(78, 374);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(129, 53);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Imagenes";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lstBoxImage
            // 
            this.lstBoxImage.FormattingEnabled = true;
            this.lstBoxImage.ItemHeight = 16;
            this.lstBoxImage.Location = new System.Drawing.Point(10, 7);
            this.lstBoxImage.Name = "lstBoxImage";
            this.lstBoxImage.Size = new System.Drawing.Size(725, 340);
            this.lstBoxImage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.lstBoxImage);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox lstBoxImage;
    }
}

