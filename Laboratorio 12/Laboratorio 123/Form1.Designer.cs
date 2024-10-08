namespace Laboratorio_12_3
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
            this.LongitudA = new System.Windows.Forms.Label();
            this.LongitudB = new System.Windows.Forms.Label();
            this.LongitudC = new System.Windows.Forms.Label();
            this.SemiPerimetro = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.Label();
            this.Calcular_SP = new System.Windows.Forms.Button();
            this.Calcular_Area = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.LA = new System.Windows.Forms.TextBox();
            this.SP = new System.Windows.Forms.TextBox();
            this.LC = new System.Windows.Forms.TextBox();
            this.LB = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LongitudA
            // 
            this.LongitudA.AutoSize = true;
            this.LongitudA.Location = new System.Drawing.Point(39, 46);
            this.LongitudA.Name = "LongitudA";
            this.LongitudA.Size = new System.Drawing.Size(180, 16);
            this.LongitudA.TabIndex = 0;
            this.LongitudA.Text = "Ingrese la longitud del lado A";
            // 
            // LongitudB
            // 
            this.LongitudB.AutoSize = true;
            this.LongitudB.Location = new System.Drawing.Point(39, 75);
            this.LongitudB.Name = "LongitudB";
            this.LongitudB.Size = new System.Drawing.Size(180, 16);
            this.LongitudB.TabIndex = 1;
            this.LongitudB.Text = "Ingrese la longitud del lado B";
            // 
            // LongitudC
            // 
            this.LongitudC.AutoSize = true;
            this.LongitudC.Location = new System.Drawing.Point(39, 103);
            this.LongitudC.Name = "LongitudC";
            this.LongitudC.Size = new System.Drawing.Size(180, 16);
            this.LongitudC.TabIndex = 2;
            this.LongitudC.Text = "Ingrese la longitud del lado C";
            // 
            // SemiPerimetro
            // 
            this.SemiPerimetro.AutoSize = true;
            this.SemiPerimetro.Location = new System.Drawing.Point(39, 324);
            this.SemiPerimetro.Name = "SemiPerimetro";
            this.SemiPerimetro.Size = new System.Drawing.Size(147, 16);
            this.SemiPerimetro.TabIndex = 3;
            this.SemiPerimetro.Text = "Calcular Semiperimetro";
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(39, 364);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(118, 16);
            this.Area.TabIndex = 4;
            this.Area.Text = "Area del Triangulo";
            // 
            // Calcular_SP
            // 
            this.Calcular_SP.Location = new System.Drawing.Point(42, 214);
            this.Calcular_SP.Name = "Calcular_SP";
            this.Calcular_SP.Size = new System.Drawing.Size(126, 23);
            this.Calcular_SP.TabIndex = 5;
            this.Calcular_SP.Text = "Semiperimetro";
            this.Calcular_SP.UseVisualStyleBackColor = true;
            this.Calcular_SP.Click += new System.EventHandler(this.Calcular_SP_Click);
            // 
            // Calcular_Area
            // 
            this.Calcular_Area.Location = new System.Drawing.Point(203, 214);
            this.Calcular_Area.Name = "Calcular_Area";
            this.Calcular_Area.Size = new System.Drawing.Size(75, 23);
            this.Calcular_Area.TabIndex = 6;
            this.Calcular_Area.Text = "Area";
            this.Calcular_Area.UseVisualStyleBackColor = true;
            this.Calcular_Area.Click += new System.EventHandler(this.Calcular_Area_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(304, 214);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(407, 214);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 23);
            this.Salir.TabIndex = 8;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // LA
            // 
            this.LA.Location = new System.Drawing.Point(257, 40);
            this.LA.Name = "LA";
            this.LA.Size = new System.Drawing.Size(100, 22);
            this.LA.TabIndex = 9;
            this.LA.TextChanged += new System.EventHandler(this.LA_TextChanged);
            // 
            // SP
            // 
            this.SP.Location = new System.Drawing.Point(194, 318);
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(100, 22);
            this.SP.TabIndex = 10;
            // 
            // LC
            // 
            this.LC.Location = new System.Drawing.Point(257, 100);
            this.LC.Name = "LC";
            this.LC.Size = new System.Drawing.Size(100, 22);
            this.LC.TabIndex = 11;
            // 
            // LB
            // 
            this.LB.Location = new System.Drawing.Point(257, 72);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(100, 22);
            this.LB.TabIndex = 12;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(194, 358);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 22);
            this.A.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.A);
            this.Controls.Add(this.LB);
            this.Controls.Add(this.LC);
            this.Controls.Add(this.SP);
            this.Controls.Add(this.LA);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Calcular_Area);
            this.Controls.Add(this.Calcular_SP);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.SemiPerimetro);
            this.Controls.Add(this.LongitudC);
            this.Controls.Add(this.LongitudB);
            this.Controls.Add(this.LongitudA);
            this.Name = "Form1";
            this.Text = "Laboratorio 12-3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LongitudA;
        private System.Windows.Forms.Label LongitudB;
        private System.Windows.Forms.Label LongitudC;
        private System.Windows.Forms.Label SemiPerimetro;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Button Calcular_SP;
        private System.Windows.Forms.Button Calcular_Area;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox LA;
        private System.Windows.Forms.TextBox SP;
        private System.Windows.Forms.TextBox LC;
        private System.Windows.Forms.TextBox LB;
        private System.Windows.Forms.TextBox A;
    }
}

