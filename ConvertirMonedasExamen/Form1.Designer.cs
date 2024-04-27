namespace ConvertirMonedasExamen
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
            cmbMoneda = new ComboBox();
            txtMonto = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            lblPeso = new Label();
            lblDolar = new Label();
            lblDolarCad = new Label();
            lblEuro = new Label();
            lblYen = new Label();
            txtPeso = new TextBox();
            txtDolar = new TextBox();
            txtDolarCad = new TextBox();
            txtEuro = new TextBox();
            txtYen = new TextBox();
            SuspendLayout();
            // 
            // cmbMoneda
            // 
            cmbMoneda.FormattingEnabled = true;
            cmbMoneda.Location = new Point(12, 38);
            cmbMoneda.Name = "cmbMoneda";
            cmbMoneda.Size = new Size(121, 23);
            cmbMoneda.TabIndex = 0;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(160, 38);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(160, 67);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Moneda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 11);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Monto";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(31, 105);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(70, 15);
            lblPeso.TabIndex = 5;
            lblPeso.Text = "MXN - Peso";
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Location = new Point(31, 134);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(68, 15);
            lblDolar.TabIndex = 6;
            lblDolar.Text = "USD - Dólar";
            // 
            // lblDolarCad
            // 
            lblDolarCad.AutoSize = true;
            lblDolarCad.Location = new Point(31, 162);
            lblDolarCad.Name = "lblDolarCad";
            lblDolarCad.Size = new Size(70, 15);
            lblDolarCad.TabIndex = 7;
            lblDolarCad.Text = "CAD - Dólar";
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Location = new Point(31, 190);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(63, 15);
            lblEuro.TabIndex = 8;
            lblEuro.Text = "EUR - Euro";
            // 
            // lblYen
            // 
            lblYen.AutoSize = true;
            lblYen.Location = new Point(31, 219);
            lblYen.Name = "lblYen";
            lblYen.Size = new Size(99, 15);
            lblYen.TabIndex = 9;
            lblYen.Text = "JPY - Yen japonés";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(135, 105);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 10;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(135, 134);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 10;
            // 
            // txtDolarCad
            // 
            txtDolarCad.Location = new Point(135, 162);
            txtDolarCad.Name = "txtDolarCad";
            txtDolarCad.Size = new Size(100, 23);
            txtDolarCad.TabIndex = 10;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(135, 190);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 10;
            // 
            // txtYen
            // 
            txtYen.Location = new Point(135, 219);
            txtYen.Name = "txtYen";
            txtYen.Size = new Size(100, 23);
            txtYen.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 279);
            Controls.Add(txtYen);
            Controls.Add(txtEuro);
            Controls.Add(txtDolarCad);
            Controls.Add(txtDolar);
            Controls.Add(txtPeso);
            Controls.Add(lblYen);
            Controls.Add(lblEuro);
            Controls.Add(lblDolarCad);
            Controls.Add(lblDolar);
            Controls.Add(lblPeso);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtMonto);
            Controls.Add(cmbMoneda);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMoneda;
        private TextBox txtMonto;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label lblPeso;
        private Label lblDolar;
        private Label lblDolarCad;
        private Label lblEuro;
        private Label lblYen;
        private TextBox txtPeso;
        private TextBox txtDolar;
        private TextBox txtDolarCad;
        private TextBox txtEuro;
        private TextBox txtYen;
    }
}
