namespace Empresa
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
            btnRegisto = new Button();
            btnDetalhes = new Button();
            btnEstat = new Button();
            SuspendLayout();
            // 
            // btnRegisto
            // 
            btnRegisto.Location = new Point(12, 12);
            btnRegisto.Name = "btnRegisto";
            btnRegisto.Size = new Size(112, 73);
            btnRegisto.TabIndex = 0;
            btnRegisto.Text = "Registo";
            btnRegisto.UseVisualStyleBackColor = true;
            btnRegisto.Click += btnRegisto_Click;
            // 
            // btnDetalhes
            // 
            btnDetalhes.Location = new Point(130, 12);
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.Size = new Size(112, 73);
            btnDetalhes.TabIndex = 1;
            btnDetalhes.Text = "Detalhes";
            btnDetalhes.UseVisualStyleBackColor = true;
            btnDetalhes.Click += btnDetalhes_Click;
            // 
            // btnEstat
            // 
            btnEstat.Location = new Point(248, 12);
            btnEstat.Name = "btnEstat";
            btnEstat.Size = new Size(112, 73);
            btnEstat.TabIndex = 2;
            btnEstat.Text = "Estatisticas";
            btnEstat.UseVisualStyleBackColor = true;
            btnEstat.Click += btnEstat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 450);
            Controls.Add(btnEstat);
            Controls.Add(btnDetalhes);
            Controls.Add(btnRegisto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegisto;
        private Button btnDetalhes;
        private Button btnEstat;
    }
}
