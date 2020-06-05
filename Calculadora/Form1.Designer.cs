namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.cmdDivisao = new System.Windows.Forms.Button();
            this.cmdMultiplicacao = new System.Windows.Forms.Button();
            this.cmdSubtracao = new System.Windows.Forms.Button();
            this.cmdAdicao = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.cmdInverte = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.cmdResultado = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.cmdDecimal = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btn1Div = new System.Windows.Forms.Button();
            this.btnFat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 70);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(218, 38);
            this.txtValor.TabIndex = 0;
            this.txtValor.Tag = "0";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(67, 123);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(50, 50);
            this.cmdLimpar.TabIndex = 1;
            this.cmdLimpar.Text = "C";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // cmdDivisao
            // 
            this.cmdDivisao.Location = new System.Drawing.Point(179, 179);
            this.cmdDivisao.Name = "cmdDivisao";
            this.cmdDivisao.Size = new System.Drawing.Size(50, 50);
            this.cmdDivisao.TabIndex = 2;
            this.cmdDivisao.Text = "/";
            this.cmdDivisao.UseVisualStyleBackColor = true;
            this.cmdDivisao.Click += new System.EventHandler(this.fnOperacao);
            // 
            // cmdMultiplicacao
            // 
            this.cmdMultiplicacao.Location = new System.Drawing.Point(179, 235);
            this.cmdMultiplicacao.Name = "cmdMultiplicacao";
            this.cmdMultiplicacao.Size = new System.Drawing.Size(50, 50);
            this.cmdMultiplicacao.TabIndex = 3;
            this.cmdMultiplicacao.Text = "*";
            this.cmdMultiplicacao.UseVisualStyleBackColor = true;
            this.cmdMultiplicacao.Click += new System.EventHandler(this.fnOperacao);
            // 
            // cmdSubtracao
            // 
            this.cmdSubtracao.Location = new System.Drawing.Point(179, 291);
            this.cmdSubtracao.Name = "cmdSubtracao";
            this.cmdSubtracao.Size = new System.Drawing.Size(50, 50);
            this.cmdSubtracao.TabIndex = 4;
            this.cmdSubtracao.Text = "-";
            this.cmdSubtracao.UseVisualStyleBackColor = true;
            this.cmdSubtracao.Click += new System.EventHandler(this.fnOperacao);
            // 
            // cmdAdicao
            // 
            this.cmdAdicao.Location = new System.Drawing.Point(179, 347);
            this.cmdAdicao.Name = "cmdAdicao";
            this.cmdAdicao.Size = new System.Drawing.Size(50, 50);
            this.cmdAdicao.TabIndex = 8;
            this.cmdAdicao.Text = "+";
            this.cmdAdicao.UseVisualStyleBackColor = true;
            this.cmdAdicao.Click += new System.EventHandler(this.fnOperacao);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(123, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 7;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.fnPreencherValor);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(67, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 6;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.fnPreencherValor);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(11, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 5;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.fnPreencherValor);
            // 
            // cmdInverte
            // 
            this.cmdInverte.Location = new System.Drawing.Point(11, 403);
            this.cmdInverte.Name = "cmdInverte";
            this.cmdInverte.Size = new System.Drawing.Size(50, 50);
            this.cmdInverte.TabIndex = 12;
            this.cmdInverte.Text = "+/-";
            this.cmdInverte.UseVisualStyleBackColor = true;
            this.cmdInverte.Click += new System.EventHandler(this.cmdInverte_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(123, 291);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 11;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.fnPreencherValor);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(67, 291);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 10;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.fnPreencherValor);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(11, 291);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 50);
            this.button12.TabIndex = 9;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.fnPreencherValor);
            // 
            // cmdResultado
            // 
            this.cmdResultado.Location = new System.Drawing.Point(179, 403);
            this.cmdResultado.Name = "cmdResultado";
            this.cmdResultado.Size = new System.Drawing.Size(50, 50);
            this.cmdResultado.TabIndex = 16;
            this.cmdResultado.Text = "=";
            this.cmdResultado.UseVisualStyleBackColor = true;
            this.cmdResultado.Click += new System.EventHandler(this.cmdResultado_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(123, 347);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 50);
            this.button14.TabIndex = 15;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.fnPreencherValor);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(67, 347);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 50);
            this.button15.TabIndex = 14;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.fnPreencherValor);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(11, 347);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 50);
            this.button16.TabIndex = 13;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.fnPreencherValor);
            // 
            // cmdDecimal
            // 
            this.cmdDecimal.Location = new System.Drawing.Point(123, 403);
            this.cmdDecimal.Name = "cmdDecimal";
            this.cmdDecimal.Size = new System.Drawing.Size(50, 50);
            this.cmdDecimal.TabIndex = 18;
            this.cmdDecimal.Text = ",";
            this.cmdDecimal.UseVisualStyleBackColor = true;
            this.cmdDecimal.Click += new System.EventHandler(this.cmdDecimal_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(67, 403);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 50);
            this.button18.TabIndex = 17;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.fnPreencherValor);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(179, 123);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 50);
            this.btnDel.TabIndex = 19;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(123, 123);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(50, 50);
            this.btnCE.TabIndex = 20;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(123, 179);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(50, 50);
            this.btnRaiz.TabIndex = 21;
            this.btnRaiz.Text = "²√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuadrado.Location = new System.Drawing.Point(67, 181);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(50, 50);
            this.btnQuadrado.TabIndex = 22;
            this.btnQuadrado.Text = "x²";
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
            // 
            // btn1Div
            // 
            this.btn1Div.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Div.Location = new System.Drawing.Point(11, 181);
            this.btn1Div.Name = "btn1Div";
            this.btn1Div.Size = new System.Drawing.Size(50, 50);
            this.btn1Div.TabIndex = 23;
            this.btn1Div.Text = "1/x";
            this.btn1Div.UseVisualStyleBackColor = true;
            this.btn1Div.Click += new System.EventHandler(this.btn1Div_Click);
            // 
            // btnFat
            // 
            this.btnFat.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFat.Location = new System.Drawing.Point(11, 125);
            this.btnFat.Name = "btnFat";
            this.btnFat.Size = new System.Drawing.Size(50, 50);
            this.btnFat.TabIndex = 24;
            this.btnFat.Text = "x!";
            this.btnFat.UseVisualStyleBackColor = true;
            this.btnFat.Click += new System.EventHandler(this.btnFat_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(242, 476);
            this.Controls.Add(this.btnFat);
            this.Controls.Add(this.btn1Div);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.cmdDecimal);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.cmdResultado);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.cmdInverte);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.cmdAdicao);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.cmdSubtracao);
            this.Controls.Add(this.cmdMultiplicacao);
            this.Controls.Add(this.cmdDivisao);
            this.Controls.Add(this.cmdLimpar);
            this.Controls.Add(this.txtValor);
            this.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fnPressionaTecla);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Button cmdDivisao;
        private System.Windows.Forms.Button cmdMultiplicacao;
        private System.Windows.Forms.Button cmdSubtracao;
        private System.Windows.Forms.Button cmdAdicao;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button cmdInverte;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button cmdResultado;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button cmdDecimal;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btn1Div;
        private System.Windows.Forms.Button btnFat;
    }
}

