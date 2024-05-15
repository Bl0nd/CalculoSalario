namespace CalculoSalario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtSalarioBruto = new TextBox();
            txtDependentes = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(99, 18);
            label2.TabIndex = 1;
            label2.Text = "Salário Bruto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(131, 18);
            label3.TabIndex = 2;
            label3.Text = "Nro Dependentes";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.PaleGreen;
            txtNome.Location = new Point(152, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(116, 23);
            txtNome.TabIndex = 3;
            // 
            // txtSalarioBruto
            // 
            txtSalarioBruto.BackColor = Color.PaleGreen;
            txtSalarioBruto.Location = new Point(152, 60);
            txtSalarioBruto.Name = "txtSalarioBruto";
            txtSalarioBruto.Size = new Size(116, 23);
            txtSalarioBruto.TabIndex = 4;
            // 
            // txtDependentes
            // 
            txtDependentes.BackColor = Color.PaleGreen;
            txtDependentes.Location = new Point(152, 96);
            txtDependentes.Name = "txtDependentes";
            txtDependentes.Size = new Size(116, 23);
            txtDependentes.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.Green;
            btnCalcular.Location = new Point(104, 153);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(306, 432);
            Controls.Add(btnCalcular);
            Controls.Add(txtDependentes);
            Controls.Add(txtSalarioBruto);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtSalarioBruto;
        private TextBox txtDependentes;
        private Button btnCalcular;
    }
}
