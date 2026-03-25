namespace Empresa
{
    partial class Estatisticas
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
            lbNcolab = new Label();
            lbValorGasto = new Label();
            lbMsB = new Label();
            lbImpostos = new Label();
            lbEMP = new Label();
            lbEGA = new Label();
            TxtNcolab = new RichTextBox();
            TxtValorGasto = new RichTextBox();
            TxtMsB = new RichTextBox();
            TxtImpostos = new RichTextBox();
            TxtEMP = new RichTextBox();
            TxtEGA = new RichTextBox();
            SuspendLayout();
            // 
            // lbNcolab
            // 
            lbNcolab.AutoSize = true;
            lbNcolab.Location = new Point(12, 9);
            lbNcolab.Name = "lbNcolab";
            lbNcolab.Size = new Size(90, 15);
            lbNcolab.TabIndex = 0;
            lbNcolab.Text = "Nº Colaborador";
            // 
            // lbValorGasto
            // 
            lbValorGasto.AutoSize = true;
            lbValorGasto.Location = new Point(12, 42);
            lbValorGasto.Name = "lbValorGasto";
            lbValorGasto.Size = new Size(66, 15);
            lbValorGasto.TabIndex = 1;
            lbValorGasto.Text = "Valor Gasto";
            // 
            // lbMsB
            // 
            lbMsB.AutoSize = true;
            lbMsB.Location = new Point(12, 78);
            lbMsB.Name = "lbMsB";
            lbMsB.Size = new Size(105, 15);
            lbMsB.TabIndex = 2;
            lbMsB.Text = "Media Salario Base";
            // 
            // lbImpostos
            // 
            lbImpostos.AutoSize = true;
            lbImpostos.Location = new Point(12, 115);
            lbImpostos.Name = "lbImpostos";
            lbImpostos.Size = new Size(98, 15);
            lbImpostos.TabIndex = 3;
            lbImpostos.Text = "Impostos a Pagar";
            // 
            // lbEMP
            // 
            lbEMP.AutoSize = true;
            lbEMP.Location = new Point(12, 152);
            lbEMP.Name = "lbEMP";
            lbEMP.Size = new Size(126, 15);
            lbEMP.TabIndex = 4;
            lbEMP.Text = "Empregado mais Pago";
            // 
            // lbEGA
            // 
            lbEGA.AutoSize = true;
            lbEGA.Location = new Point(12, 189);
            lbEGA.Name = "lbEGA";
            lbEGA.Size = new Size(154, 15);
            lbEGA.TabIndex = 5;
            lbEGA.Text = "Estimativa de Gastos Anuais";
            // 
            // TxtNcolab
            // 
            TxtNcolab.Location = new Point(184, 9);
            TxtNcolab.Name = "TxtNcolab";
            TxtNcolab.Size = new Size(172, 18);
            TxtNcolab.TabIndex = 6;
            TxtNcolab.Text = "";
            TxtNcolab.TextChanged += TxtNcolab_TextChanged;
            // 
            // TxtValorGasto
            // 
            TxtValorGasto.Location = new Point(184, 42);
            TxtValorGasto.Name = "TxtValorGasto";
            TxtValorGasto.Size = new Size(172, 18);
            TxtValorGasto.TabIndex = 7;
            TxtValorGasto.Text = "";
            // 
            // TxtMsB
            // 
            TxtMsB.Location = new Point(184, 78);
            TxtMsB.Name = "TxtMsB";
            TxtMsB.Size = new Size(172, 18);
            TxtMsB.TabIndex = 8;
            TxtMsB.Text = "";
            // 
            // TxtImpostos
            // 
            TxtImpostos.Location = new Point(184, 115);
            TxtImpostos.Name = "TxtImpostos";
            TxtImpostos.Size = new Size(172, 18);
            TxtImpostos.TabIndex = 9;
            TxtImpostos.Text = "";
            // 
            // TxtEMP
            // 
            TxtEMP.Location = new Point(184, 149);
            TxtEMP.Name = "TxtEMP";
            TxtEMP.Size = new Size(172, 18);
            TxtEMP.TabIndex = 10;
            TxtEMP.Text = "";
            // 
            // TxtEGA
            // 
            TxtEGA.Location = new Point(184, 186);
            TxtEGA.Name = "TxtEGA";
            TxtEGA.Size = new Size(172, 18);
            TxtEGA.TabIndex = 11;
            TxtEGA.Text = "";
            // 
            // Estatisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 230);
            Controls.Add(TxtEGA);
            Controls.Add(TxtEMP);
            Controls.Add(TxtImpostos);
            Controls.Add(TxtMsB);
            Controls.Add(TxtValorGasto);
            Controls.Add(TxtNcolab);
            Controls.Add(lbEGA);
            Controls.Add(lbEMP);
            Controls.Add(lbImpostos);
            Controls.Add(lbMsB);
            Controls.Add(lbValorGasto);
            Controls.Add(lbNcolab);
            Name = "Estatisticas";
            Text = "Estatisticas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNcolab;
        private Label lbValorGasto;
        private Label lbMsB;
        private Label lbImpostos;
        private Label lbEMP;
        private Label lbEGA;
        private RichTextBox TxtNcolab;
        private RichTextBox TxtValorGasto;
        private RichTextBox TxtMsB;
        private RichTextBox TxtImpostos;
        private RichTextBox TxtEMP;
        private RichTextBox TxtEGA;
    }
}