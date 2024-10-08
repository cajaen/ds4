namespace Laboratorio12_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Nota1 = new System.Windows.Forms.Label();
            this.Nota2 = new System.Windows.Forms.Label();
            this.Nota3 = new System.Windows.Forms.Label();
            this.Promedio = new System.Windows.Forms.Label();
            this.Valor1 = new System.Windows.Forms.TextBox();
            this.Valor2 = new System.Windows.Forms.TextBox();
            this.Valor3 = new System.Windows.Forms.TextBox();
            this.ValorFinal = new System.Windows.Forms.TextBox();
            this.Compilar = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora - Nota Promedio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nota1
            // 
            this.Nota1.AutoSize = true;
            this.Nota1.Location = new System.Drawing.Point(106, 138);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(70, 16);
            this.Nota1.TabIndex = 1;
            this.Nota1.Text = "Nota No. 1";
            // 
            // Nota2
            // 
            this.Nota2.AutoSize = true;
            this.Nota2.Location = new System.Drawing.Point(106, 169);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(70, 16);
            this.Nota2.TabIndex = 2;
            this.Nota2.Text = "Nota No. 2";
            // 
            // Nota3
            // 
            this.Nota3.AutoSize = true;
            this.Nota3.Location = new System.Drawing.Point(106, 207);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(70, 16);
            this.Nota3.TabIndex = 3;
            this.Nota3.Text = "Nota No. 3";
            // 
            // Promedio
            // 
            this.Promedio.AutoSize = true;
            this.Promedio.Location = new System.Drawing.Point(106, 352);
            this.Promedio.Name = "Promedio";
            this.Promedio.Size = new System.Drawing.Size(98, 16);
            this.Promedio.TabIndex = 4;
            this.Promedio.Text = "Nota Promedio";
            // 
            // Valor1
            // 
            this.Valor1.Location = new System.Drawing.Point(228, 138);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(122, 22);
            this.Valor1.TabIndex = 5;
            // 
            // Valor2
            // 
            this.Valor2.Location = new System.Drawing.Point(228, 166);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(122, 22);
            this.Valor2.TabIndex = 6;
            // 
            // Valor3
            // 
            this.Valor3.Location = new System.Drawing.Point(228, 201);
            this.Valor3.Name = "Valor3";
            this.Valor3.Size = new System.Drawing.Size(122, 22);
            this.Valor3.TabIndex = 7;
            // 
            // ValorFinal
            // 
            this.ValorFinal.Location = new System.Drawing.Point(228, 352);
            this.ValorFinal.Name = "ValorFinal";
            this.ValorFinal.Size = new System.Drawing.Size(122, 22);
            this.ValorFinal.TabIndex = 8;
            // 
            // Compilar
            // 
            this.Compilar.Location = new System.Drawing.Point(82, 269);
            this.Compilar.Name = "Compilar";
            this.Compilar.Size = new System.Drawing.Size(94, 23);
            this.Compilar.TabIndex = 9;
            this.Compilar.Text = "Promedio";
            this.Compilar.UseVisualStyleBackColor = true;
            this.Compilar.Click += new System.EventHandler(this.Compilar_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(182, 269);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(95, 23);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(283, 269);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(93, 23);
            this.Salir.TabIndex = 11;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Compilar);
            this.Controls.Add(this.ValorFinal);
            this.Controls.Add(this.Valor3);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Valor1);
            this.Controls.Add(this.Promedio);
            this.Controls.Add(this.Nota3);
            this.Controls.Add(this.Nota2);
            this.Controls.Add(this.Nota1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Laboratorio12-2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nota1;
        private System.Windows.Forms.Label Nota2;
        private System.Windows.Forms.Label Nota3;
        private System.Windows.Forms.Label Promedio;
        private System.Windows.Forms.TextBox Valor1;
        private System.Windows.Forms.TextBox Valor2;
        private System.Windows.Forms.TextBox Valor3;
        private System.Windows.Forms.TextBox ValorFinal;
        private System.Windows.Forms.Button Compilar;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Salir;
    }
}

