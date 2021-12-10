namespace WFA_Triangulos
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
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClassificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTipo2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEquilatero = new System.Windows.Forms.RadioButton();
            this.radIsosceles = new System.Windows.Forms.RadioButton();
            this.radEscaleno = new System.Windows.Forms.RadioButton();
            this.picTriangulo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTriangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLado1
            // 
            this.txtLado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado1.Location = new System.Drawing.Point(104, 53);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 30);
            this.txtLado1.TabIndex = 0;
            // 
            // txtLado2
            // 
            this.txtLado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado2.Location = new System.Drawing.Point(104, 106);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 30);
            this.txtLado2.TabIndex = 1;
            // 
            // txtLado3
            // 
            this.txtLado3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado3.Location = new System.Drawing.Point(104, 160);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 30);
            this.txtLado3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lado 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lado 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lado 3";
            // 
            // btnClassificar
            // 
            this.btnClassificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassificar.Location = new System.Drawing.Point(42, 228);
            this.btnClassificar.Name = "btnClassificar";
            this.btnClassificar.Size = new System.Drawing.Size(145, 47);
            this.btnClassificar.TabIndex = 6;
            this.btnClassificar.Text = "Classificar";
            this.btnClassificar.UseVisualStyleBackColor = true;
            this.btnClassificar.Click += new System.EventHandler(this.btnClassificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo do triângulo:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(192, 306);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 25);
            this.lblTipo.TabIndex = 8;
            // 
            // lblTipo2
            // 
            this.lblTipo2.AutoSize = true;
            this.lblTipo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo2.Location = new System.Drawing.Point(211, 306);
            this.lblTipo2.Name = "lblTipo2";
            this.lblTipo2.Size = new System.Drawing.Size(0, 25);
            this.lblTipo2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEscaleno);
            this.groupBox1.Controls.Add(this.radIsosceles);
            this.groupBox1.Controls.Add(this.radEquilatero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(263, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 202);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo do triângulo";
            // 
            // radEquilatero
            // 
            this.radEquilatero.AutoSize = true;
            this.radEquilatero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEquilatero.Location = new System.Drawing.Point(38, 52);
            this.radEquilatero.Name = "radEquilatero";
            this.radEquilatero.Size = new System.Drawing.Size(120, 29);
            this.radEquilatero.TabIndex = 0;
            this.radEquilatero.TabStop = true;
            this.radEquilatero.Text = "Equilátero";
            this.radEquilatero.UseVisualStyleBackColor = true;
            // 
            // radIsosceles
            // 
            this.radIsosceles.AutoSize = true;
            this.radIsosceles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIsosceles.Location = new System.Drawing.Point(38, 95);
            this.radIsosceles.Name = "radIsosceles";
            this.radIsosceles.Size = new System.Drawing.Size(115, 29);
            this.radIsosceles.TabIndex = 1;
            this.radIsosceles.TabStop = true;
            this.radIsosceles.Text = "Isósceles";
            this.radIsosceles.UseVisualStyleBackColor = true;
            // 
            // radEscaleno
            // 
            this.radEscaleno.AutoSize = true;
            this.radEscaleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEscaleno.Location = new System.Drawing.Point(38, 140);
            this.radEscaleno.Name = "radEscaleno";
            this.radEscaleno.Size = new System.Drawing.Size(114, 29);
            this.radEscaleno.TabIndex = 2;
            this.radEscaleno.TabStop = true;
            this.radEscaleno.Text = "Escaleno";
            this.radEscaleno.UseVisualStyleBackColor = true;
            // 
            // picTriangulo
            // 
            this.picTriangulo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picTriangulo.Location = new System.Drawing.Point(478, 44);
            this.picTriangulo.Name = "picTriangulo";
            this.picTriangulo.Size = new System.Drawing.Size(542, 447);
            this.picTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picTriangulo.TabIndex = 11;
            this.picTriangulo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 529);
            this.Controls.Add(this.picTriangulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTipo2);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClassificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTriangulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClassificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTipo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEscaleno;
        private System.Windows.Forms.RadioButton radIsosceles;
        private System.Windows.Forms.RadioButton radEquilatero;
        private System.Windows.Forms.PictureBox picTriangulo;
    }
}

