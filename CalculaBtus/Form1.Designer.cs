namespace CalculaBtus
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
            cboQuantidadeDePessoas = new ComboBox();
            txt_Largura = new TextBox();
            chkSolDaTarde = new CheckBox();
            txtAreaEmMetrosQuadrados = new TextBox();
            txt_Comprimento = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_calcularArea = new Button();
            btn_CalculaBtus = new Button();
            lblResultado = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cboQuantidadeDePessoas
            // 
            cboQuantidadeDePessoas.FormattingEnabled = true;
            cboQuantidadeDePessoas.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboQuantidadeDePessoas.Location = new Point(261, 86);
            cboQuantidadeDePessoas.Name = "cboQuantidadeDePessoas";
            cboQuantidadeDePessoas.Size = new Size(121, 23);
            cboQuantidadeDePessoas.TabIndex = 0;
            // 
            // txt_Largura
            // 
            txt_Largura.Location = new Point(77, 86);
            txt_Largura.Name = "txt_Largura";
            txt_Largura.Size = new Size(100, 23);
            txt_Largura.TabIndex = 1;
            // 
            // chkSolDaTarde
            // 
            chkSolDaTarde.AutoSize = true;
            chkSolDaTarde.Location = new Point(275, 140);
            chkSolDaTarde.Name = "chkSolDaTarde";
            chkSolDaTarde.Size = new Size(88, 19);
            chkSolDaTarde.TabIndex = 2;
            chkSolDaTarde.Text = "Sol da tarde";
            chkSolDaTarde.UseVisualStyleBackColor = true;
            // 
            // txtAreaEmMetrosQuadrados
            // 
            txtAreaEmMetrosQuadrados.Location = new Point(77, 215);
            txtAreaEmMetrosQuadrados.Name = "txtAreaEmMetrosQuadrados";
            txtAreaEmMetrosQuadrados.Size = new Size(100, 23);
            txtAreaEmMetrosQuadrados.TabIndex = 3;
            // 
            // txt_Comprimento
            // 
            txt_Comprimento.Location = new Point(77, 135);
            txt_Comprimento.Name = "txt_Comprimento";
            txt_Comprimento.Size = new Size(100, 23);
            txt_Comprimento.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(95, 62);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 5;
            label1.Text = "Largura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(77, 112);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 6;
            label2.Text = "Comprimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 194);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 7;
            label3.Text = "Área";
            // 
            // btn_calcularArea
            // 
            btn_calcularArea.Location = new Point(88, 165);
            btn_calcularArea.Name = "btn_calcularArea";
            btn_calcularArea.Size = new Size(75, 23);
            btn_calcularArea.TabIndex = 8;
            btn_calcularArea.Text = "Calcular";
            btn_calcularArea.UseVisualStyleBackColor = true;
            btn_calcularArea.Click += btn_calcularArea_Click;
            // 
            // btn_CalculaBtus
            // 
            btn_CalculaBtus.Location = new Point(275, 177);
            btn_CalculaBtus.Name = "btn_CalculaBtus";
            btn_CalculaBtus.Size = new Size(75, 23);
            btn_CalculaBtus.TabIndex = 9;
            btn_CalculaBtus.Text = "Calcular";
            btn_CalculaBtus.UseVisualStyleBackColor = true;
            btn_CalculaBtus.Click += btn_CalculaBtus_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(63, 368);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 27);
            label4.Name = "label4";
            label4.Size = new Size(203, 21);
            label4.TabIndex = 11;
            label4.Text = "Descubra a Área Primeiro";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 425);
            Controls.Add(label4);
            Controls.Add(lblResultado);
            Controls.Add(btn_CalculaBtus);
            Controls.Add(btn_calcularArea);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Comprimento);
            Controls.Add(txtAreaEmMetrosQuadrados);
            Controls.Add(chkSolDaTarde);
            Controls.Add(txt_Largura);
            Controls.Add(cboQuantidadeDePessoas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboQuantidadeDePessoas;
        private TextBox txt_Largura;
        private CheckBox chkSolDaTarde;
        private TextBox txtAreaEmMetrosQuadrados;
        private TextBox txt_Comprimento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_calcularArea;
        private Button btn_CalculaBtus;
        private Label lblResultado;
        private Label label4;
    }
}