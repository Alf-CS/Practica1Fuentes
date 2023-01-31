namespace Practica1Fuentes
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
            this.BtnNegrita = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCursiva = new System.Windows.Forms.Button();
            this.BtnSubrayada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNegrita
            // 
            this.BtnNegrita.Location = new System.Drawing.Point(67, 247);
            this.BtnNegrita.Name = "BtnNegrita";
            this.BtnNegrita.Size = new System.Drawing.Size(155, 43);
            this.BtnNegrita.TabIndex = 0;
            this.BtnNegrita.Text = "Negrita";
            this.BtnNegrita.UseVisualStyleBackColor = true;
            this.BtnNegrita.Click += new System.EventHandler(this.BtnNegrita_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "En un lugar de la Mancha";
            // 
            // BtnCursiva
            // 
            this.BtnCursiva.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.BtnCursiva.Location = new System.Drawing.Point(328, 247);
            this.BtnCursiva.Name = "BtnCursiva";
            this.BtnCursiva.Size = new System.Drawing.Size(159, 40);
            this.BtnCursiva.TabIndex = 2;
            this.BtnCursiva.Text = "Cursiva";
            this.BtnCursiva.UseVisualStyleBackColor = true;
            // 
            // BtnSubrayada
            // 
            this.BtnSubrayada.Location = new System.Drawing.Point(589, 247);
            this.BtnSubrayada.Name = "BtnSubrayada";
            this.BtnSubrayada.Size = new System.Drawing.Size(149, 43);
            this.BtnSubrayada.TabIndex = 3;
            this.BtnSubrayada.Text = "Subrayada";
            this.BtnSubrayada.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSubrayada);
            this.Controls.Add(this.BtnCursiva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnNegrita);
            this.Name = "Form1";
            this.Text = "Prueba de fuentes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnNegrita;
        private Label label1;
        private Button BtnCursiva;
        private Button BtnSubrayada;
    }
}