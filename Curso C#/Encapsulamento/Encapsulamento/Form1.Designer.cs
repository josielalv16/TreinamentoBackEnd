﻿namespace Encapsulamento
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
            if (disposing && (components != null)) {
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
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.caixa_preco = new System.Windows.Forms.TextBox();
            this.cmd_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Checked = true;
            this.rd1.Location = new System.Drawing.Point(132, 24);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(87, 17);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "Copo de leite";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(132, 47);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(60, 17);
            this.rd2.TabIndex = 1;
            this.rd2.Text = "Martelo";
            this.rd2.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(132, 70);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(64, 17);
            this.rd3.TabIndex = 2;
            this.rd3.Text = "Perfume";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // caixa_preco
            // 
            this.caixa_preco.Location = new System.Drawing.Point(132, 109);
            this.caixa_preco.Name = "caixa_preco";
            this.caixa_preco.Size = new System.Drawing.Size(100, 20);
            this.caixa_preco.TabIndex = 3;
            // 
            // cmd_executar
            // 
            this.cmd_executar.Location = new System.Drawing.Point(144, 157);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar.TabIndex = 4;
            this.cmd_executar.Text = "Executar";
            this.cmd_executar.UseVisualStyleBackColor = true;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 302);
            this.Controls.Add(this.cmd_executar);
            this.Controls.Add(this.caixa_preco);
            this.Controls.Add(this.rd3);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.TextBox caixa_preco;
        private System.Windows.Forms.Button cmd_executar;
    }
}

