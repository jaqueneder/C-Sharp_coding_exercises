namespace WindowsFormsAppExercicio1
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
            this.labelVetor = new System.Windows.Forms.Label();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonDividir = new System.Windows.Forms.Button();
            this.textBoxNumeros = new System.Windows.Forms.TextBox();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelVetor
            // 
            this.labelVetor.AutoSize = true;
            this.labelVetor.Location = new System.Drawing.Point(32, 31);
            this.labelVetor.Name = "labelVetor";
            this.labelVetor.Size = new System.Drawing.Size(94, 13);
            this.labelVetor.TabIndex = 0;
            this.labelVetor.Text = "Digite os números:";
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(35, 69);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 1;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonDividir
            // 
            this.buttonDividir.Location = new System.Drawing.Point(132, 69);
            this.buttonDividir.Name = "buttonDividir";
            this.buttonDividir.Size = new System.Drawing.Size(75, 23);
            this.buttonDividir.TabIndex = 2;
            this.buttonDividir.Text = "Dividir";
            this.buttonDividir.UseVisualStyleBackColor = true;
            this.buttonDividir.Click += new System.EventHandler(this.buttonDividir_Click);
            // 
            // textBoxNumeros
            // 
            this.textBoxNumeros.Location = new System.Drawing.Point(132, 28);
            this.textBoxNumeros.Name = "textBoxNumeros";
            this.textBoxNumeros.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeros.TabIndex = 3;
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(228, 69);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonReiniciar.TabIndex = 5;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.Location = new System.Drawing.Point(35, 128);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(164, 147);
            this.listBoxNumeros.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxNumeros);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.textBoxNumeros);
            this.Controls.Add(this.buttonDividir);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.labelVetor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVetor;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonDividir;
        private System.Windows.Forms.TextBox textBoxNumeros;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.ListBox listBoxNumeros;
    }
}

