namespace Aula15_1
{
    partial class form1
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
            this.txtArquivo1 = new System.Windows.Forms.TextBox();
            this.txtArquivo2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPastaOrigem = new System.Windows.Forms.TextBox();
            this.txtPastaDestino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMover = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtArquivo1
            // 
            this.txtArquivo1.Location = new System.Drawing.Point(57, 62);
            this.txtArquivo1.Name = "txtArquivo1";
            this.txtArquivo1.Size = new System.Drawing.Size(100, 20);
            this.txtArquivo1.TabIndex = 0;
            // 
            // txtArquivo2
            // 
            this.txtArquivo2.Location = new System.Drawing.Point(57, 108);
            this.txtArquivo2.Name = "txtArquivo2";
            this.txtArquivo2.Size = new System.Drawing.Size(100, 20);
            this.txtArquivo2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasta a ser criada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pasta a ser deletada";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(186, 60);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 3;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(186, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPastaOrigem
            // 
            this.txtPastaOrigem.Location = new System.Drawing.Point(57, 275);
            this.txtPastaOrigem.Name = "txtPastaOrigem";
            this.txtPastaOrigem.Size = new System.Drawing.Size(100, 20);
            this.txtPastaOrigem.TabIndex = 0;
            // 
            // txtPastaDestino
            // 
            this.txtPastaDestino.Location = new System.Drawing.Point(57, 320);
            this.txtPastaDestino.Name = "txtPastaDestino";
            this.txtPastaDestino.Size = new System.Drawing.Size(100, 20);
            this.txtPastaDestino.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pasta Origem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pasta Destino";
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(186, 275);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 4;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(57, 227);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(100, 20);
            this.txtArquivo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Arquivo para mover";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.txtPastaDestino);
            this.Controls.Add(this.txtArquivo2);
            this.Controls.Add(this.txtPastaOrigem);
            this.Controls.Add(this.txtArquivo1);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArquivo1;
        private System.Windows.Forms.TextBox txtArquivo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPastaOrigem;
        private System.Windows.Forms.TextBox txtPastaDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label label5;
    }
}

