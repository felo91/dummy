namespace prueba2_dummy
{
    partial class Preguntas
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnOp3 = new System.Windows.Forms.Button();
            this.btnOp4 = new System.Windows.Forms.Button();
            this.btnOp2 = new System.Windows.Forms.Button();
            this.btnOp1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(29, 25);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(49, 13);
            this.lblPregunta.TabIndex = 6;
            this.lblPregunta.Text = "pregunta";
            // 
            // btnOp3
            // 
            this.btnOp3.Location = new System.Drawing.Point(34, 257);
            this.btnOp3.Name = "btnOp3";
            this.btnOp3.Size = new System.Drawing.Size(66, 23);
            this.btnOp3.TabIndex = 2;
            this.btnOp3.Text = "opcion3";
            this.btnOp3.UseVisualStyleBackColor = true;
            // 
            // btnOp4
            // 
            this.btnOp4.Location = new System.Drawing.Point(174, 257);
            this.btnOp4.Name = "btnOp4";
            this.btnOp4.Size = new System.Drawing.Size(66, 23);
            this.btnOp4.TabIndex = 3;
            this.btnOp4.Text = "opcion4";
            this.btnOp4.UseVisualStyleBackColor = true;
            // 
            // btnOp2
            // 
            this.btnOp2.Location = new System.Drawing.Point(174, 192);
            this.btnOp2.Name = "btnOp2";
            this.btnOp2.Size = new System.Drawing.Size(66, 23);
            this.btnOp2.TabIndex = 4;
            this.btnOp2.Text = "opcion2";
            this.btnOp2.UseVisualStyleBackColor = true;
            // 
            // btnOp1
            // 
            this.btnOp1.Location = new System.Drawing.Point(34, 192);
            this.btnOp1.Name = "btnOp1";
            this.btnOp1.Size = new System.Drawing.Size(66, 23);
            this.btnOp1.TabIndex = 5;
            this.btnOp1.Text = "opcion1";
            this.btnOp1.UseVisualStyleBackColor = true;
            this.btnOp1.Click += new System.EventHandler(this.BtnOp1_Click);
            // 
            // Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 325);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.btnOp3);
            this.Controls.Add(this.btnOp4);
            this.Controls.Add(this.btnOp2);
            this.Controls.Add(this.btnOp1);
            this.Name = "Preguntas";
            this.Text = "Preguntas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnOp3;
        private System.Windows.Forms.Button btnOp4;
        private System.Windows.Forms.Button btnOp2;
        private System.Windows.Forms.Button btnOp1;
    }
}