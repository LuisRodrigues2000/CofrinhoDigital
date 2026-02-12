namespace CofrinhoDigital.UI
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
            components = new System.ComponentModel.Container();
            Valor = new Label();
            btnSaldo = new Button();
            btnDepositar = new Button();
            btnSacar = new Button();
            lblSaldo = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtValor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Valor
            // 
            Valor.AutoSize = true;
            Valor.Location = new Point(17, 111);
            Valor.Name = "Valor";
            Valor.Size = new Size(36, 15);
            Valor.TabIndex = 2;
            Valor.Text = "Valor:";
            // 
            // btnSaldo
            // 
            btnSaldo.Location = new Point(240, 174);
            btnSaldo.Name = "btnSaldo";
            btnSaldo.Size = new Size(75, 23);
            btnSaldo.TabIndex = 4;
            btnSaldo.Text = "Saldo";
            btnSaldo.UseVisualStyleBackColor = true;
            btnSaldo.Click += btnSaldo_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(134, 174);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(75, 23);
            btnDepositar.TabIndex = 4;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(26, 174);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(75, 23);
            btnSacar.TabIndex = 4;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(210, 111);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(0, 15);
            lblSaldo.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtValor
            // 
            txtValor.Location = new Point(59, 108);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(59, 27);
            label2.Name = "label2";
            label2.Size = new Size(216, 30);
            label2.TabIndex = 9;
            label2.Text = "COFRINHO DIGITAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 228);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValor);
            Controls.Add(lblSaldo);
            Controls.Add(btnSacar);
            Controls.Add(btnDepositar);
            Controls.Add(btnSaldo);
            Controls.Add(Valor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label Valor;
        private Button btnSaldo;
        private Button btnDepositar;
        private Button btnSacar;
        private Label lblSaldo;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtValor;
        private Label label1;
    }
}
