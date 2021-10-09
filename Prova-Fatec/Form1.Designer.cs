
namespace Prova_Fatec
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
            this.adicao = new System.Windows.Forms.Button();
            this.subtracao = new System.Windows.Forms.Button();
            this.divisao = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adicao
            // 
            this.adicao.Location = new System.Drawing.Point(487, 150);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(97, 23);
            this.adicao.TabIndex = 0;
            this.adicao.Text = "Adição";
            this.adicao.UseVisualStyleBackColor = true;
            this.adicao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // subtracao
            // 
            this.subtracao.Location = new System.Drawing.Point(487, 179);
            this.subtracao.Name = "subtracao";
            this.subtracao.Size = new System.Drawing.Size(97, 23);
            this.subtracao.TabIndex = 1;
            this.subtracao.Text = "Subtração";
            this.subtracao.UseVisualStyleBackColor = true;
            this.subtracao.Click += new System.EventHandler(this.subtracao_Click);
            // 
            // divisao
            // 
            this.divisao.Location = new System.Drawing.Point(487, 208);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(97, 23);
            this.divisao.TabIndex = 2;
            this.divisao.Text = "Divisão";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.Location = new System.Drawing.Point(487, 237);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(97, 23);
            this.multiplicacao.TabIndex = 3;
            this.multiplicacao.Text = "Multiplicação";
            this.multiplicacao.UseVisualStyleBackColor = true;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número 2:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(212, 147);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(199, 23);
            this.num1.TabIndex = 6;
            this.num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(212, 186);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(199, 23);
            this.num2.TabIndex = 7;
            this.num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado:";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(261, 268);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(12, 15);
            this.resultado.TabIndex = 9;
            this.resultado.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.subtracao);
            this.Controls.Add(this.adicao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button subtracao;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultado;
    }
}

