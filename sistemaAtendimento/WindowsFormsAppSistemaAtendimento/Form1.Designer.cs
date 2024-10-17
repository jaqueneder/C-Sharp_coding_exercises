namespace WindowsFormsAppSistemaAtendimento
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
            this.buttonGerarSenhaNormal = new System.Windows.Forms.Button();
            this.buttonGerarSenhaPrioritaria = new System.Windows.Forms.Button();
            this.buttonAtenderNormal = new System.Windows.Forms.Button();
            this.buttonAtenderPrioritaria = new System.Windows.Forms.Button();
            this.buttonLimparFila = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.listaFilaNormal = new System.Windows.Forms.ListBox();
            this.listaFilaPrioritaria = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonGerarSenhaNormal
            // 
            this.buttonGerarSenhaNormal.Location = new System.Drawing.Point(59, 30);
            this.buttonGerarSenhaNormal.Name = "buttonGerarSenhaNormal";
            this.buttonGerarSenhaNormal.Size = new System.Drawing.Size(151, 23);
            this.buttonGerarSenhaNormal.TabIndex = 0;
            this.buttonGerarSenhaNormal.Text = "Gerar senha normal";
            this.buttonGerarSenhaNormal.UseVisualStyleBackColor = true;
            this.buttonGerarSenhaNormal.Click += new System.EventHandler(this.buttonGerarSenhaNormal_Click);
            // 
            // buttonGerarSenhaPrioritaria
            // 
            this.buttonGerarSenhaPrioritaria.Location = new System.Drawing.Point(236, 30);
            this.buttonGerarSenhaPrioritaria.Name = "buttonGerarSenhaPrioritaria";
            this.buttonGerarSenhaPrioritaria.Size = new System.Drawing.Size(151, 23);
            this.buttonGerarSenhaPrioritaria.TabIndex = 1;
            this.buttonGerarSenhaPrioritaria.Text = "Gerar senha prioritária";
            this.buttonGerarSenhaPrioritaria.UseVisualStyleBackColor = true;
            this.buttonGerarSenhaPrioritaria.Click += new System.EventHandler(this.buttonGerarSenhaPrioritaria_Click);
            // 
            // buttonAtenderNormal
            // 
            this.buttonAtenderNormal.Location = new System.Drawing.Point(59, 65);
            this.buttonAtenderNormal.Name = "buttonAtenderNormal";
            this.buttonAtenderNormal.Size = new System.Drawing.Size(151, 23);
            this.buttonAtenderNormal.TabIndex = 2;
            this.buttonAtenderNormal.Text = "Atender senha normal";
            this.buttonAtenderNormal.UseVisualStyleBackColor = true;
            this.buttonAtenderNormal.Click += new System.EventHandler(this.buttonAtenderNormal_Click);
            // 
            // buttonAtenderPrioritaria
            // 
            this.buttonAtenderPrioritaria.Location = new System.Drawing.Point(236, 65);
            this.buttonAtenderPrioritaria.Name = "buttonAtenderPrioritaria";
            this.buttonAtenderPrioritaria.Size = new System.Drawing.Size(151, 23);
            this.buttonAtenderPrioritaria.TabIndex = 3;
            this.buttonAtenderPrioritaria.Text = "Atender senha prioritária";
            this.buttonAtenderPrioritaria.UseVisualStyleBackColor = true;
            this.buttonAtenderPrioritaria.Click += new System.EventHandler(this.buttonAtenderPrioritaria_Click);
            // 
            // buttonLimparFila
            // 
            this.buttonLimparFila.Location = new System.Drawing.Point(416, 121);
            this.buttonLimparFila.Name = "buttonLimparFila";
            this.buttonLimparFila.Size = new System.Drawing.Size(75, 23);
            this.buttonLimparFila.TabIndex = 5;
            this.buttonLimparFila.Text = "Limpar fila";
            this.buttonLimparFila.UseVisualStyleBackColor = true;
            this.buttonLimparFila.Click += new System.EventHandler(this.buttonLimparFila_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(416, 150);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // listaFilaNormal
            // 
            this.listaFilaNormal.FormattingEnabled = true;
            this.listaFilaNormal.Location = new System.Drawing.Point(59, 121);
            this.listaFilaNormal.Name = "listaFilaNormal";
            this.listaFilaNormal.Size = new System.Drawing.Size(151, 173);
            this.listaFilaNormal.TabIndex = 7;
            // 
            // listaFilaPrioritaria
            // 
            this.listaFilaPrioritaria.FormattingEnabled = true;
            this.listaFilaPrioritaria.Location = new System.Drawing.Point(236, 121);
            this.listaFilaPrioritaria.Name = "listaFilaPrioritaria";
            this.listaFilaPrioritaria.Size = new System.Drawing.Size(151, 173);
            this.listaFilaPrioritaria.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.listaFilaPrioritaria);
            this.Controls.Add(this.listaFilaNormal);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLimparFila);
            this.Controls.Add(this.buttonAtenderPrioritaria);
            this.Controls.Add(this.buttonAtenderNormal);
            this.Controls.Add(this.buttonGerarSenhaPrioritaria);
            this.Controls.Add(this.buttonGerarSenhaNormal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGerarSenhaNormal;
        private System.Windows.Forms.Button buttonGerarSenhaPrioritaria;
        private System.Windows.Forms.Button buttonAtenderNormal;
        private System.Windows.Forms.Button buttonAtenderPrioritaria;
        private System.Windows.Forms.Button buttonLimparFila;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ListBox listaFilaNormal;
        private System.Windows.Forms.ListBox listaFilaPrioritaria;
    }
}

