namespace _1Act_Area_Perimetro
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.texto_1 = new System.Windows.Forms.Label();
            this.texto_3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total_numero = new System.Windows.Forms.Label();
            this.triangulo = new System.Windows.Forms.Button();
            this.rectangulo = new System.Windows.Forms.Button();
            this.circulo = new System.Windows.Forms.Button();
            this.cuadrado = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.Button();
            this.perimetro = new System.Windows.Forms.Button();
            this.texto_2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.volver = new System.Windows.Forms.Button();
            this.volver_Operacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(110, 265);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.valor_text);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Location = new System.Drawing.Point(438, 265);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.valor_text2);
            // 
            // texto_1
            // 
            this.texto_1.AutoSize = true;
            this.texto_1.Location = new System.Drawing.Point(138, 249);
            this.texto_1.Name = "texto_1";
            this.texto_1.Size = new System.Drawing.Size(40, 13);
            this.texto_1.TabIndex = 9;
            this.texto_1.Text = "Lado 1";
            this.texto_1.Click += new System.EventHandler(this.text);
            // 
            // texto_3
            // 
            this.texto_3.AutoSize = true;
            this.texto_3.Location = new System.Drawing.Point(473, 249);
            this.texto_3.Name = "texto_3";
            this.texto_3.Size = new System.Drawing.Size(40, 13);
            this.texto_3.TabIndex = 10;
            this.texto_3.Text = "Lado 3";
            this.texto_3.Click += new System.EventHandler(this.text2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Figura :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Operación : ";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total :";
            this.label5.Click += new System.EventHandler(this.text_total);
            // 
            // total_numero
            // 
            this.total_numero.AutoSize = true;
            this.total_numero.Location = new System.Drawing.Point(352, 325);
            this.total_numero.Name = "total_numero";
            this.total_numero.Size = new System.Drawing.Size(13, 13);
            this.total_numero.TabIndex = 15;
            this.total_numero.Text = "0";
            this.total_numero.Click += new System.EventHandler(this.respuesta_numero);
            // 
            // triangulo
            // 
            this.triangulo.Location = new System.Drawing.Point(110, 56);
            this.triangulo.Name = "triangulo";
            this.triangulo.Size = new System.Drawing.Size(75, 23);
            this.triangulo.TabIndex = 18;
            this.triangulo.Text = "Triángulo";
            this.triangulo.UseVisualStyleBackColor = true;
            this.triangulo.Click += new System.EventHandler(this.triangulo_figura);
            // 
            // rectangulo
            // 
            this.rectangulo.Location = new System.Drawing.Point(341, 56);
            this.rectangulo.Name = "rectangulo";
            this.rectangulo.Size = new System.Drawing.Size(75, 23);
            this.rectangulo.TabIndex = 20;
            this.rectangulo.Text = "Rectángulo";
            this.rectangulo.UseVisualStyleBackColor = true;
            this.rectangulo.Click += new System.EventHandler(this.button4_Click);
            // 
            // circulo
            // 
            this.circulo.Location = new System.Drawing.Point(224, 56);
            this.circulo.Name = "circulo";
            this.circulo.Size = new System.Drawing.Size(75, 23);
            this.circulo.TabIndex = 21;
            this.circulo.Text = " Círculo";
            this.circulo.UseVisualStyleBackColor = true;
            this.circulo.Click += new System.EventHandler(this.button5_Click);
            // 
            // cuadrado
            // 
            this.cuadrado.Location = new System.Drawing.Point(463, 56);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(75, 23);
            this.cuadrado.TabIndex = 22;
            this.cuadrado.Text = "Cuadrado";
            this.cuadrado.UseVisualStyleBackColor = true;
            this.cuadrado.Click += new System.EventHandler(this.button6_Click);
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(141, 162);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(75, 23);
            this.area.TabIndex = 23;
            this.area.Text = "Área";
            this.area.UseVisualStyleBackColor = true;
            this.area.Click += new System.EventHandler(this.button1_Click);
            // 
            // perimetro
            // 
            this.perimetro.Location = new System.Drawing.Point(429, 162);
            this.perimetro.Name = "perimetro";
            this.perimetro.Size = new System.Drawing.Size(75, 23);
            this.perimetro.TabIndex = 24;
            this.perimetro.Text = "Perímetro";
            this.perimetro.UseVisualStyleBackColor = true;
            this.perimetro.Click += new System.EventHandler(this.button3_Click);
            // 
            // texto_2
            // 
            this.texto_2.AutoSize = true;
            this.texto_2.Location = new System.Drawing.Point(311, 249);
            this.texto_2.Name = "texto_2";
            this.texto_2.Size = new System.Drawing.Size(40, 13);
            this.texto_2.TabIndex = 26;
            this.texto_2.Text = "Lado 2";
            this.texto_2.Click += new System.EventHandler(this.texto_2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(276, 265);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(12, 56);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 27;
            this.volver.Text = "volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Visible = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // volver_Operacion
            // 
            this.volver_Operacion.Location = new System.Drawing.Point(12, 162);
            this.volver_Operacion.Name = "volver_Operacion";
            this.volver_Operacion.Size = new System.Drawing.Size(75, 23);
            this.volver_Operacion.TabIndex = 28;
            this.volver_Operacion.Text = "volver";
            this.volver_Operacion.UseVisualStyleBackColor = true;
            this.volver_Operacion.Visible = false;
            this.volver_Operacion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 347);
            this.Controls.Add(this.volver_Operacion);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.texto_2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.perimetro);
            this.Controls.Add(this.area);
            this.Controls.Add(this.cuadrado);
            this.Controls.Add(this.circulo);
            this.Controls.Add(this.rectangulo);
            this.Controls.Add(this.triangulo);
            this.Controls.Add(this.total_numero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texto_3);
            this.Controls.Add(this.texto_1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Name = "Form1";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label texto_1;
        private System.Windows.Forms.Label texto_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total_numero;
        private System.Windows.Forms.Button triangulo;
        private System.Windows.Forms.Button rectangulo;
        private System.Windows.Forms.Button circulo;
        private System.Windows.Forms.Button cuadrado;
        private System.Windows.Forms.Button area;
        private System.Windows.Forms.Button perimetro;
        private System.Windows.Forms.Label texto_2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button volver_Operacion;
    }
}

