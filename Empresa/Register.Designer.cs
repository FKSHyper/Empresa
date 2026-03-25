using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Empresa
{
    partial class Register
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
            labelName = new Label();
            TypeContact = new Label();
            nameTxt = new TextBox();
            typeContractBox = new ComboBox();
            label1 = new Label();
            salaryTxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            hoursTxt = new TextBox();
            valueHourTxt = new TextBox();
            btnAdd = new Button();
            panelFree = new Panel();
            labelAlim = new Label();
            AlimTxt = new TextBox();
            panelEfe = new Panel();
            panelFree.SuspendLayout();
            panelEfe.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(79, 78);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Nome";
            // 
            // TypeContact
            // 
            TypeContact.AutoSize = true;
            TypeContact.Location = new Point(24, 115);
            TypeContact.Name = "TypeContact";
            TypeContact.Size = new Size(95, 15);
            TypeContact.TabIndex = 1;
            TypeContact.Text = "Tipo de contrato";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(135, 75);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(194, 23);
            nameTxt.TabIndex = 2;
            // 
            // typeContractBox
            // 
            typeContractBox.FormattingEnabled = true;
            typeContractBox.Items.AddRange(new object[] { "Efetivo", "Freelancer" });
            typeContractBox.Location = new Point(135, 112);
            typeContractBox.Name = "typeContractBox";
            typeContractBox.Size = new Size(193, 23);
            typeContractBox.TabIndex = 3;
            typeContractBox.SelectedIndexChanged += typeContractBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 155);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Salário base";
            // 
            // salaryTxt
            // 
            salaryTxt.Location = new Point(134, 152);
            salaryTxt.Name = "salaryTxt";
            salaryTxt.Size = new Size(194, 23);
            salaryTxt.TabIndex = 5;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 45);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "Valor Hora";
            // 
            // hoursTxt
            // 
            hoursTxt.Location = new Point(101, 7);
            hoursTxt.Name = "hoursTxt";
            hoursTxt.Size = new Size(194, 23);
            hoursTxt.TabIndex = 10;
            // 
            // valueHourTxt
            // 
            valueHourTxt.Location = new Point(101, 45);
            valueHourTxt.Name = "valueHourTxt";
            valueHourTxt.Size = new Size(194, 23);
            valueHourTxt.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(319, 297);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 42);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelFree
            // 
            panelFree.Controls.Add(valueHourTxt);
            panelFree.Controls.Add(hoursTxt);
            panelFree.Controls.Add(label3);
            panelFree.Controls.Add(label2);
            panelFree.Location = new Point(34, 188);
            panelFree.Name = "panelFree";
            panelFree.Size = new Size(332, 80);
            panelFree.TabIndex = 15;
            // 
            // labelAlim
            // 
            labelAlim.AutoSize = true;
            labelAlim.Location = new Point(4, 11);
            labelAlim.Name = "labelAlim";
            labelAlim.Size = new Size(97, 15);
            labelAlim.TabIndex = 16;
            labelAlim.Text = "Sub Alimentação";
            // 
            // AlimTxt
            // 
            AlimTxt.Location = new Point(117, 9);
            AlimTxt.Name = "AlimTxt";
            AlimTxt.Size = new Size(194, 23);
            AlimTxt.TabIndex = 17;
            // 
            // panelEfe
            // 
            panelEfe.Controls.Add(AlimTxt);
            panelEfe.Controls.Add(labelAlim);
            panelEfe.Location = new Point(17, 185);
            panelEfe.Name = "panelEfe";
            panelEfe.Size = new Size(353, 36);
            panelEfe.TabIndex = 18;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 364);
            Controls.Add(panelEfe);
            Controls.Add(panelFree);
            Controls.Add(btnAdd);
            Controls.Add(salaryTxt);
            Controls.Add(label1);
            Controls.Add(typeContractBox);
            Controls.Add(nameTxt);
            Controls.Add(TypeContact);
            Controls.Add(labelName);
            Name = "Register";
            Text = "Form Registro";
            panelFree.ResumeLayout(false);
            panelFree.PerformLayout();
            panelEfe.ResumeLayout(false);
            panelEfe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label TypeContact;
        private TextBox nameTxt;
        private ComboBox typeContractBox;
        private Label label1;
        private TextBox salaryTxt;
        private Label label2;
        private Label label3;
        private TextBox idTxt;
        private Label idLabel;
        private TextBox hoursTxt;
        private TextBox valueHourTxt;
        private Button btnSearch;
        private Panel panelSearch;
        private Button btnAdd;
        private Panel panelFree;
        private Label labelAlim;
        private TextBox AlimTxt;
        private Panel panelEfe;
    }
}