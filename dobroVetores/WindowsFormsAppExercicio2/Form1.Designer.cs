namespace WindowsFormsAppExercicio2
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
            this.listBoxNumerosOriginal = new System.Windows.Forms.ListBox();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.textBoxNumeros = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.labelVetor = new System.Windows.Forms.Label();
            this.listBoxNumerosDobro = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxNumerosOriginal
            // 
            this.listBoxNumerosOriginal.FormattingEnabled = true;
            this.listBoxNumerosOriginal.Location = new System.Drawing.Point(41, 141);
            this.listBoxNumerosOriginal.Name = "listBoxNumerosOriginal";
            this.listBoxNumerosOriginal.Size = new System.Drawing.Size(164, 147);
            this.listBoxNumerosOriginal.TabIndex = 12;
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(234, 82);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonReiniciar.TabIndex = 11;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // textBoxNumeros
            // 
            this.textBoxNumeros.Location = new System.Drawing.Point(138, 41);
            this.textBoxNumeros.Name = "textBoxNumeros";
            this.textBoxNumeros.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeros.TabIndex = 10;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(138, 82);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 9;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(41, 82);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 8;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // labelVetor
            // 
            this.labelVetor.AutoSize = true;
            this.labelVetor.Location = new System.Drawing.Point(38, 44);
            this.labelVetor.Name = "labelVetor";
            this.labelVetor.Size = new System.Drawing.Size(94, 13);
            this.labelVetor.TabIndex = 7;
            this.labelVetor.Text = "Digite os números:";
            // 
            // listBoxNumerosDobro
            // 
            this.listBoxNumerosDobro.FormattingEnabled = true;
            this.listBoxNumerosDobro.Location = new System.Drawing.Point(234, 141);
            this.listBoxNumerosDobro.Name = "listBoxNumerosDobro";
            this.listBoxNumerosDobro.Size = new System.Drawing.Size(164, 147);
            this.listBoxNumerosDobro.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxNumerosDobro);
            this.Controls.Add(this.listBoxNumerosOriginal);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.textBoxNumeros);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.labelVetor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNumerosOriginal;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.TextBox textBoxNumeros;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Label labelVetor;
        private System.Windows.Forms.ListBox listBoxNumerosDobro;
    }
}

