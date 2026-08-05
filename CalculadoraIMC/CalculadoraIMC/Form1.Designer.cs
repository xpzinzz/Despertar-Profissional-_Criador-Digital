namespace CalculadoraIMC
{
    partial class lblCalculadoraImc
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
            pnlVisor = new Panel();
            txtResultado = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            lblSituação = new Label();
            lblSubtitulo = new Label();
            lblResultado1 = new Label();
            lblMetro = new Label();
            lblKg = new Label();
            lblAltura = new Label();
            lblPeso = new Label();
            lblTitulo = new Label();
            pctTrena = new PictureBox();
            pctBalanca = new PictureBox();
            pnlTeclado = new Panel();
            btnDel = new Button();
            btnNumero0 = new Button();
            btnVirgula = new Button();
            btnCalcular = new Button();
            btnNumero3 = new Button();
            btnNumero2 = new Button();
            btnNumero1 = new Button();
            btnNumero6 = new Button();
            btnNumero5 = new Button();
            btnNumero4 = new Button();
            btnNumero9 = new Button();
            btnNumero8 = new Button();
            btnNumero7 = new Button();
            pnlVisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctTrena).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBalanca).BeginInit();
            pnlTeclado.SuspendLayout();
            SuspendLayout();
            // 
            // pnlVisor
            // 
            pnlVisor.BackColor = Color.Transparent;
            pnlVisor.Controls.Add(txtResultado);
            pnlVisor.Controls.Add(txtAltura);
            pnlVisor.Controls.Add(txtPeso);
            pnlVisor.Controls.Add(lblSituação);
            pnlVisor.Controls.Add(lblSubtitulo);
            pnlVisor.Controls.Add(lblResultado1);
            pnlVisor.Controls.Add(lblMetro);
            pnlVisor.Controls.Add(lblKg);
            pnlVisor.Controls.Add(lblAltura);
            pnlVisor.Controls.Add(lblPeso);
            pnlVisor.Controls.Add(lblTitulo);
            pnlVisor.Controls.Add(pctTrena);
            pnlVisor.Controls.Add(pctBalanca);
            pnlVisor.Location = new Point(12, 12);
            pnlVisor.Name = "pnlVisor";
            pnlVisor.Size = new Size(245, 183);
            pnlVisor.TabIndex = 0;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.Location = new Point(100, 109);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(67, 23);
            txtResultado.TabIndex = 12;
            // 
            // txtAltura
            // 
            txtAltura.BackColor = Color.White;
            txtAltura.Location = new Point(100, 80);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(67, 23);
            txtAltura.TabIndex = 11;
            txtAltura.Enter += txtAltura_Enter;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.White;
            txtPeso.Location = new Point(100, 49);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(67, 23);
            txtPeso.TabIndex = 10;
            txtPeso.Enter += txtPeso_Enter;
            // 
            // lblSituação
            // 
            lblSituação.AutoSize = true;
            lblSituação.BackColor = Color.Transparent;
            lblSituação.FlatStyle = FlatStyle.Flat;
            lblSituação.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSituação.ForeColor = Color.DimGray;
            lblSituação.ImageAlign = ContentAlignment.BottomLeft;
            lblSituação.Location = new Point(12, 159);
            lblSituação.Name = "lblSituação";
            lblSituação.Size = new Size(89, 18);
            lblSituação.TabIndex = 9;
            lblSituação.Text = "Situação:";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.FlatStyle = FlatStyle.Flat;
            lblSubtitulo.Font = new Font("Verdana", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.DimGray;
            lblSubtitulo.ImageAlign = ContentAlignment.BottomLeft;
            lblSubtitulo.Location = new Point(38, 27);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(181, 13);
            lblSubtitulo.TabIndex = 8;
            lblSubtitulo.Text = "Informe seu Peso e sua Altura";
            lblSubtitulo.Click += label1_Click_2;
            // 
            // lblResultado1
            // 
            lblResultado1.AutoSize = true;
            lblResultado1.FlatStyle = FlatStyle.Flat;
            lblResultado1.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResultado1.ImageAlign = ContentAlignment.BottomLeft;
            lblResultado1.Location = new Point(65, 112);
            lblResultado1.Name = "lblResultado1";
            lblResultado1.Size = new Size(32, 16);
            lblResultado1.TabIndex = 7;
            lblResultado1.Text = "IMC";
            // 
            // lblMetro
            // 
            lblMetro.AutoSize = true;
            lblMetro.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMetro.Location = new Point(173, 85);
            lblMetro.Name = "lblMetro";
            lblMetro.Size = new Size(20, 16);
            lblMetro.TabIndex = 6;
            lblMetro.Text = "m";
            // 
            // lblKg
            // 
            lblKg.AutoSize = true;
            lblKg.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKg.Location = new Point(173, 56);
            lblKg.Name = "lblKg";
            lblKg.Size = new Size(22, 16);
            lblKg.TabIndex = 5;
            lblKg.Text = "kg";
            lblKg.Click += label1_Click_1;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.FlatStyle = FlatStyle.Flat;
            lblAltura.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAltura.ImageAlign = ContentAlignment.BottomLeft;
            lblAltura.Location = new Point(53, 82);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(46, 16);
            lblAltura.TabIndex = 4;
            lblAltura.Text = "Altura";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.FlatStyle = FlatStyle.Flat;
            lblPeso.Font = new Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPeso.ImageAlign = ContentAlignment.BottomLeft;
            lblPeso.Location = new Point(62, 54);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(37, 16);
            lblPeso.TabIndex = 3;
            lblPeso.Text = "Peso";
            lblPeso.Click += label1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(38, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(171, 23);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Cálculo de IMC";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // pctTrena
            // 
            pctTrena.Image = Properties.Resources.metro;
            pctTrena.Location = new Point(20, 81);
            pctTrena.Name = "pctTrena";
            pctTrena.Size = new Size(29, 30);
            pctTrena.SizeMode = PictureBoxSizeMode.StretchImage;
            pctTrena.TabIndex = 1;
            pctTrena.TabStop = false;
            // 
            // pctBalanca
            // 
            pctBalanca.Image = Properties.Resources.balanca;
            pctBalanca.Location = new Point(19, 45);
            pctBalanca.Name = "pctBalanca";
            pctBalanca.Size = new Size(29, 30);
            pctBalanca.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBalanca.TabIndex = 0;
            pctBalanca.TabStop = false;
            // 
            // pnlTeclado
            // 
            pnlTeclado.BackColor = Color.Black;
            pnlTeclado.Controls.Add(btnDel);
            pnlTeclado.Controls.Add(btnNumero0);
            pnlTeclado.Controls.Add(btnVirgula);
            pnlTeclado.Controls.Add(btnCalcular);
            pnlTeclado.Controls.Add(btnNumero3);
            pnlTeclado.Controls.Add(btnNumero2);
            pnlTeclado.Controls.Add(btnNumero1);
            pnlTeclado.Controls.Add(btnNumero6);
            pnlTeclado.Controls.Add(btnNumero5);
            pnlTeclado.Controls.Add(btnNumero4);
            pnlTeclado.Controls.Add(btnNumero9);
            pnlTeclado.Controls.Add(btnNumero8);
            pnlTeclado.Controls.Add(btnNumero7);
            pnlTeclado.Location = new Point(12, 201);
            pnlTeclado.Name = "pnlTeclado";
            pnlTeclado.Size = new Size(245, 301);
            pnlTeclado.TabIndex = 1;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Gold;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.ForeColor = Color.Black;
            btnDel.Location = new Point(163, 192);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(71, 54);
            btnDel.TabIndex = 12;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = false;
            // 
            // btnNumero0
            // 
            btnNumero0.BackColor = Color.Gold;
            btnNumero0.FlatStyle = FlatStyle.Flat;
            btnNumero0.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumero0.ForeColor = Color.Black;
            btnNumero0.Location = new Point(86, 192);
            btnNumero0.Name = "btnNumero0";
            btnNumero0.Size = new Size(71, 54);
            btnNumero0.TabIndex = 11;
            btnNumero0.Text = "0";
            btnNumero0.UseVisualStyleBackColor = false;
            btnNumero0.Click += inserirNumeros_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.Gold;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVirgula.ForeColor = Color.Black;
            btnVirgula.Location = new Point(9, 192);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(71, 54);
            btnVirgula.TabIndex = 10;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += inserirNumeros_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Gold;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(9, 258);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(225, 33);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular Índice de Massa Corporal";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnNumero3
            // 
            btnNumero3.BackColor = Color.Gold;
            btnNumero3.FlatStyle = FlatStyle.Flat;
            btnNumero3.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumero3.ForeColor = Color.Black;
            btnNumero3.Location = new Point(163, 132);
            btnNumero3.Name = "btnNumero3";
            btnNumero3.Size = new Size(71, 54);
            btnNumero3.TabIndex = 8;
            btnNumero3.Text = "3";
            btnNumero3.UseVisualStyleBackColor = false;
            btnNumero3.Click += inserirNumeros_Click;
            // 
            // btnNumero2
            // 
            btnNumero2.BackColor = Color.Gold;
            btnNumero2.FlatStyle = FlatStyle.Flat;
            btnNumero2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumero2.ForeColor = Color.Black;
            btnNumero2.Location = new Point(86, 132);
            btnNumero2.Name = "btnNumero2";
            btnNumero2.Size = new Size(71, 54);
            btnNumero2.TabIndex = 7;
            btnNumero2.Text = "2";
            btnNumero2.UseVisualStyleBackColor = false;
            btnNumero2.Click += inserirNumeros_Click;
            // 
            // btnNumero1
            // 
            btnNumero1.BackColor = Color.Gold;
            btnNumero1.FlatStyle = FlatStyle.Flat;
            btnNumero1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumero1.ForeColor = Color.Black;
            btnNumero1.Location = new Point(9, 132);
            btnNumero1.Name = "btnNumero1";
            btnNumero1.Size = new Size(71, 54);
            btnNumero1.TabIndex = 6;
            btnNumero1.Text = "1";
            btnNumero1.UseVisualStyleBackColor = false;
            btnNumero1.Click += inserirNumeros_Click;
            // 
            // btnNumero6
            // 
            btnNumero6.BackColor = Color.Gold;
            btnNumero6.FlatStyle = FlatStyle.Flat;
            btnNumero6.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumero6.ForeColor = Color.Black;
            btnNumero6.Location = new Point(163, 72);
            btnNumero6.Name = "btnNumero6";
            btnNumero6.Size = new Size(71, 54);
            btnNumero6.TabIndex = 5;
            btnNumero6.Text = "6";
            btnNumero6.UseVisualStyleBackColor = false;
            btnNumero6.Click += inserirNumeros_Click;
            // 
            // btnNumero5
            // 
            btnNumero5.BackColor = Color.Gold;
            btnNumero5.FlatStyle = FlatStyle.Flat;
            btnNumero5.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumero5.ForeColor = Color.Black;
            btnNumero5.Location = new Point(86, 72);
            btnNumero5.Name = "btnNumero5";
            btnNumero5.Size = new Size(71, 54);
            btnNumero5.TabIndex = 4;
            btnNumero5.Text = "5";
            btnNumero5.UseVisualStyleBackColor = false;
            btnNumero5.Click += inserirNumeros_Click;
            // 
            // btnNumero4
            // 
            btnNumero4.BackColor = Color.Gold;
            btnNumero4.FlatStyle = FlatStyle.Flat;
            btnNumero4.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumero4.ForeColor = Color.Black;
            btnNumero4.Location = new Point(9, 72);
            btnNumero4.Name = "btnNumero4";
            btnNumero4.Size = new Size(71, 54);
            btnNumero4.TabIndex = 3;
            btnNumero4.Text = "4";
            btnNumero4.UseVisualStyleBackColor = false;
            btnNumero4.Click += inserirNumeros_Click;
            // 
            // btnNumero9
            // 
            btnNumero9.BackColor = Color.Gold;
            btnNumero9.FlatStyle = FlatStyle.Flat;
            btnNumero9.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumero9.ForeColor = Color.Black;
            btnNumero9.Location = new Point(163, 12);
            btnNumero9.Name = "btnNumero9";
            btnNumero9.Size = new Size(71, 54);
            btnNumero9.TabIndex = 2;
            btnNumero9.Text = "9";
            btnNumero9.UseVisualStyleBackColor = false;
            btnNumero9.Click += inserirNumeros_Click;
            // 
            // btnNumero8
            // 
            btnNumero8.BackColor = Color.Gold;
            btnNumero8.FlatStyle = FlatStyle.Flat;
            btnNumero8.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumero8.ForeColor = Color.Black;
            btnNumero8.Location = new Point(86, 12);
            btnNumero8.Name = "btnNumero8";
            btnNumero8.Size = new Size(71, 54);
            btnNumero8.TabIndex = 1;
            btnNumero8.Text = "8";
            btnNumero8.UseVisualStyleBackColor = false;
            btnNumero8.Click += inserirNumeros_Click;
            // 
            // btnNumero7
            // 
            btnNumero7.BackColor = Color.Gold;
            btnNumero7.FlatStyle = FlatStyle.Flat;
            btnNumero7.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNumero7.ForeColor = Color.Black;
            btnNumero7.Location = new Point(9, 12);
            btnNumero7.Name = "btnNumero7";
            btnNumero7.Size = new Size(71, 54);
            btnNumero7.TabIndex = 0;
            btnNumero7.Text = "7";
            btnNumero7.UseVisualStyleBackColor = false;
            btnNumero7.Click += inserirNumeros_Click;
            // 
            // lblCalculadoraImc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(269, 514);
            Controls.Add(pnlTeclado);
            Controls.Add(pnlVisor);
            Name = "lblCalculadoraImc";
            Text = "Calculadora IMC";
            pnlVisor.ResumeLayout(false);
            pnlVisor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctTrena).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBalanca).EndInit();
            pnlTeclado.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlVisor;
        private Label lblTitulo;
        private PictureBox pctTrena;
        private PictureBox pctBalanca;
        private Panel pnlTeclado;
        private Label lblPeso;
        private Label lblKg;
        private Label lblAltura;
        private Label lblResultado1;
        private Label lblMetro;
        private Label lblSubtitulo;
        private TextBox txtPeso;
        private Label lblSituação;
        private TextBox txtResultado;
        private TextBox txtAltura;
        private Button btnNumero7;
        private Button btnCalcular;
        private Button btnNumero3;
        private Button btnNumero2;
        private Button btnNumero1;
        private Button btnNumero6;
        private Button btnNumero5;
        private Button btnNumero4;
        private Button btnNumero9;
        private Button btnNumero8;
        private Button btnDel;
        private Button btnNumero0;
        private Button btnVirgula;
    }
}
