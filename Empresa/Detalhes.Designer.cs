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
            panelEfe = new Panel();
            txt_SubAlimentação = new TextBox();
            label5 = new Label();
            label1 = new Label();
            salaryTxtDet = new TextBox();
            btnPesquisarDet = new Button();
            typeContractBoxDet = new ComboBox();
            nameTxtDet = new TextBox();
            TypeContact = new Label();
            labelName = new Label();
            label4 = new Label();
            txt_ID = new TextBox();
            panelFree.SuspendLayout();
            panelEfe.SuspendLayout();
            SuspendLayout();
            // 
            // panelFree
            // 
            panelFree.Controls.Add(valueHourTxtDet);
            panelFree.Controls.Add(hoursTxtDet);
            panelFree.Controls.Add(label3);
            panelFree.Controls.Add(label2);
            panelFree.Location = new Point(10, 106);
            panelFree.Name = "panelFree";
            panelFree.Size = new Size(329, 80);
            panelFree.TabIndex = 23;
            panelFree.Visible = false;
            // 
            // valueHourTxtDet
            // 
            valueHourTxtDet.Location = new Point(99, 43);
            valueHourTxtDet.Name = "valueHourTxtDet";
            valueHourTxtDet.Size = new Size(194, 23);
            valueHourTxtDet.TabIndex = 11;
            // 
            // hoursTxtDet
            // 
            hoursTxtDet.Location = new Point(99, 8);
            hoursTxtDet.Name = "hoursTxtDet";
            hoursTxtDet.Size = new Size(194, 23);
            hoursTxtDet.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 45);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Valor Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 10);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Horas extra";
            // 
            // panelEfe
            // 
            panelEfe.Controls.Add(txt_SubAlimentação);
            panelEfe.Controls.Add(label5);
            panelEfe.Controls.Add(label1);
            panelEfe.Controls.Add(salaryTxtDet);
            panelEfe.Location = new Point(10, 191);
            panelEfe.Margin = new Padding(3, 2, 3, 2);
            panelEfe.Name = "panelEfe";
            panelEfe.Size = new Size(307, 92);
            panelEfe.TabIndex = 26;
            panelEfe.Visible = false;
            // 
            // txt_SubAlimentação
            // 
            txt_SubAlimentação.Location = new Point(119, 40);
            txt_SubAlimentação.Margin = new Padding(3, 2, 3, 2);
            txt_SubAlimentação.Name = "txt_SubAlimentação";
            txt_SubAlimentação.Size = new Size(170, 23);
            txt_SubAlimentação.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 43);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 22;
            label5.Text = "Sub Alimentação";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 20;
            label1.Text = "Salário base";
            // 
            // salaryTxtDet
            // 
            salaryTxtDet.Location = new Point(96, 10);
            salaryTxtDet.Name = "salaryTxtDet";
            salaryTxtDet.Size = new Size(194, 23);
            salaryTxtDet.TabIndex = 21;
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
            // typeContractBoxDet
            // 
            typeContractBoxDet.FormattingEnabled = true;
            typeContractBoxDet.Items.AddRange(new object[] { "Efetivo", "Freelancer" });
            typeContractBoxDet.Location = new Point(109, 82);
            typeContractBoxDet.Name = "typeContractBoxDet";
            typeContractBoxDet.Size = new Size(193, 23);
            typeContractBoxDet.TabIndex = 19;
            // 
            // nameTxtDet
            // 
            nameTxtDet.Location = new Point(109, 48);
            nameTxtDet.Name = "nameTxtDet";
            nameTxtDet.Size = new Size(194, 23);
            nameTxtDet.TabIndex = 18;
            // 
            // TypeContact
            // 
            TypeContact.AutoSize = true;
            TypeContact.Location = new Point(-1, 84);
            TypeContact.Name = "TypeContact";
            TypeContact.Size = new Size(94, 15);
            TypeContact.TabIndex = 17;
            TypeContact.Text = "Tipo de contrato";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(55, 50);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 16;
            labelName.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 22);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 24;
            label4.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(109, 22);
            txt_ID.Margin = new Padding(3, 2, 3, 2);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(193, 23);
            txt_ID.TabIndex = 25;
            txt_ID.TextChanged += txt_ID_TextChanged;
            // 
            // Detalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 282);
            Controls.Add(panelEfe);
            Controls.Add(txt_ID);
            Controls.Add(label4);
            Controls.Add(panelFree);
            Controls.Add(btnPesquisarDet);
            Controls.Add(typeContractBoxDet);
            Controls.Add(nameTxtDet);
            Controls.Add(TypeContact);
            Controls.Add(labelName);
            Name = "Detalhes";
            Text = "Detalhes";
            panelFree.ResumeLayout(false);
            panelFree.PerformLayout();
            panelEfe.ResumeLayout(false);
            panelEfe.PerformLayout();
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
        private Label label4;
        private TextBox txt_ID;
        private Panel panelEfe;
        private TextBox txt_SubAlimentação;
        private Label label5;
    }
}