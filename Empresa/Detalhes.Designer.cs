namespace Empresa
{
    partial class Detalhes
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
            panelFree = new Panel();
            valueHourTxtDet = new TextBox();
            hoursTxtDet = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnPesquisarDet = new Button();
            salaryTxtDet = new TextBox();
            label1 = new Label();
            typeContractBoxDet = new ComboBox();
            nameTxtDet = new TextBox();
            TypeContact = new Label();
            labelName = new Label();
            panelFree.SuspendLayout();
            SuspendLayout();
            // 
            // panelFree
            // 
            panelFree.Controls.Add(valueHourTxtDet);
            panelFree.Controls.Add(hoursTxtDet);
            panelFree.Controls.Add(label3);
            panelFree.Controls.Add(label2);
            panelFree.Location = new Point(15, 119);
            panelFree.Name = "panelFree";
            panelFree.Size = new Size(332, 80);
            panelFree.TabIndex = 23;
            // 
            // valueHourTxtDet
            // 
            valueHourTxtDet.Location = new Point(101, 45);
            valueHourTxtDet.Name = "valueHourTxtDet";
            valueHourTxtDet.Size = new Size(194, 23);
            valueHourTxtDet.TabIndex = 11;
            // 
            // hoursTxtDet
            // 
            hoursTxtDet.Location = new Point(101, 7);
            hoursTxtDet.Name = "hoursTxtDet";
            hoursTxtDet.Size = new Size(194, 23);
            hoursTxtDet.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 45);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Valor Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 10);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 6;
            label2.Text = "Horas extra";
            // 
            // btnPesquisarDet
            // 
            btnPesquisarDet.Location = new Point(300, 228);
            btnPesquisarDet.Name = "btnPesquisarDet";
            btnPesquisarDet.Size = new Size(109, 42);
            btnPesquisarDet.TabIndex = 22;
            btnPesquisarDet.Text = "Pesquisar";
            btnPesquisarDet.UseVisualStyleBackColor = true;
            btnPesquisarDet.Click += btnPesquisarDet_Click;
            // 
            // salaryTxtDet
            // 
            salaryTxtDet.Location = new Point(115, 85);
            salaryTxtDet.Name = "salaryTxtDet";
            salaryTxtDet.Size = new Size(194, 23);
            salaryTxtDet.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 88);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 20;
            label1.Text = "Salário base";
            // 
            // typeContractBoxDet
            // 
            typeContractBoxDet.FormattingEnabled = true;
            typeContractBoxDet.Items.AddRange(new object[] { "Efetivo", "Freelancer" });
            typeContractBoxDet.Location = new Point(116, 45);
            typeContractBoxDet.Name = "typeContractBoxDet";
            typeContractBoxDet.Size = new Size(193, 23);
            typeContractBoxDet.TabIndex = 19;
            // 
            // nameTxtDet
            // 
            nameTxtDet.Location = new Point(116, 8);
            nameTxtDet.Name = "nameTxtDet";
            nameTxtDet.Size = new Size(194, 23);
            nameTxtDet.TabIndex = 18;
            // 
            // TypeContact
            // 
            TypeContact.AutoSize = true;
            TypeContact.Location = new Point(5, 48);
            TypeContact.Name = "TypeContact";
            TypeContact.Size = new Size(95, 15);
            TypeContact.TabIndex = 17;
            TypeContact.Text = "Tipo de contrato";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(60, 11);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 16;
            labelName.Text = "Nome";
            // 
            // Detalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 282);
            Controls.Add(panelFree);
            Controls.Add(btnPesquisarDet);
            Controls.Add(salaryTxtDet);
            Controls.Add(label1);
            Controls.Add(typeContractBoxDet);
            Controls.Add(nameTxtDet);
            Controls.Add(TypeContact);
            Controls.Add(labelName);
            Name = "Detalhes";
            Text = "Detalhes";
            panelFree.ResumeLayout(false);
            panelFree.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFree;
        private TextBox valueHourTxtDet;
        private TextBox hoursTxtDet;
        private Label label3;
        private Label label2;
        private Button btnPesquisarDet;
        private TextBox salaryTxtDet;
        private Label label1;
        private ComboBox typeContractBoxDet;
        private TextBox nameTxtDet;
        private Label TypeContact;
        private Label labelName;
    }
}