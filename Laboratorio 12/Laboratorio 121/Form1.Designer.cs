namespace Laboratorio12_1
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
            this.Tiempo = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Valor1 = new System.Windows.Forms.TextBox();
            this.Velocidad = new System.Windows.Forms.Label();
            this.Compilar = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.Valor2 = new System.Windows.Forms.TextBox();
            this.Valor3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora - Distancia";
            // 
            // Tiempo
            // 
            this.Tiempo.AutoSize = true;
            this.Tiempo.Location = new System.Drawing.Point(117, 112);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(54, 16);
            this.Tiempo.TabIndex = 1;
            this.Tiempo.Text = "Tiempo";
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(221, 232);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(328, 232);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Valor1
            // 
            this.Valor1.Location = new System.Drawing.Point(238, 109);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(100, 22);
            this.Valor1.TabIndex = 9;
            // 
            // Velocidad
            // 
            this.Velocidad.AutoSize = true;
            this.Velocidad.Location = new System.Drawing.Point(117, 75);
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.Size = new System.Drawing.Size(69, 16);
            this.Velocidad.TabIndex = 10;
            this.Velocidad.Text = "Velocidad";
            // 
            // Compilar
            // 
            this.Compilar.Location = new System.Drawing.Point(111, 232);
            this.Compilar.Name = "Compilar";
            this.Compilar.Size = new System.Drawing.Size(75, 23);
            this.Compilar.TabIndex = 11;
            this.Compilar.Text = "Compilar";
            this.Compilar.UseVisualStyleBackColor = true;
            this.Compilar.Click += new System.EventHandler(this.Compilar_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(125, 346);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(69, 16);
            this.Resultado.TabIndex = 12;
            this.Resultado.Text = "Resultado";
            // 
            // Valor2
            // 
            this.Valor2.Location = new System.Drawing.Point(238, 75);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(100, 22);
            this.Valor2.TabIndex = 13;
            // 
            // Valor3
            // 
            this.Valor3.Location = new System.Drawing.Point(238, 346);
            this.Valor3.Name = "Valor3";
            this.Valor3.Size = new System.Drawing.Size(100, 22);
            this.Valor3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.Valor3);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Compilar);
            this.Controls.Add(this.Velocidad);
            this.Controls.Add(this.Valor1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Tiempo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Laboratorio 12-1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox Valor1;
        private System.Windows.Forms.Label Velocidad;
        private System.Windows.Forms.Button Compilar;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.TextBox Valor2;
        private System.Windows.Forms.TextBox Valor3;
    }
}

