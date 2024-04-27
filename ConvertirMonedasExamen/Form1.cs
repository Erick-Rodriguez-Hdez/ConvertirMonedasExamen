namespace ConvertirMonedasExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbMoneda.Items.Add("MXN - Peso mexicano");
            cmbMoneda.Items.Add("USD - Dólar estadounidense");
            cmbMoneda.Items.Add("CAD - Dólar canadiense");
            cmbMoneda.Items.Add("EUR - Euro");
            cmbMoneda.Items.Add("JPY - Yen japonés");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("Ingresa un monto válido.");
                return;
            }

            string monedaSeleccionada = cmbMoneda.SelectedItem as string;

            if (monedaSeleccionada != null)
            {
                MessageBox.Show($"Has seleccionado {monedaSeleccionada}. El monto convertido es: {monto}");
            }
            else
            {
                MessageBox.Show("Selecciona una moneda.");
            }
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("Ingresa un monto válido.");
                return;
            }

            string monedaSeleccionada = cmbMoneda.SelectedItem as string;

            if (monedaSeleccionada != null)
            {
                switch (monedaSeleccionada)
                {
                    case "MXN - Peso mexicano":
                        lblDolar.Visible = true;
                        txtDolar.Visible = true;
                        lblDolar.Text = "USD:";
                        txtDolar.Text = (monto * 0.06m).ToString();
                        lblDolarCad.Visible = true;
                        txtDolarCad.Visible = true;
                        lblDolarCad.Text = "CAD:";
                        txtDolarCad.Text = (monto * 0.08m).ToString();
                        lblEuro.Visible = true;
                        txtEuro.Visible = true;
                        lblEuro.Text = "EUR:";
                        txtEuro.Text = (monto * 0.06m).ToString();
                        lblYen.Visible = true;
                        txtYen.Visible = true;
                        lblYen.Text = "JPY:";
                        txtYen.Text = (monto * 9.05m).ToString();
                        break;

                    case "USD - Dólar estadounidense":
                        lblPeso.Visible = true;
                        txtPeso.Visible = true;
                        lblPeso.Text = "MXN:";
                        txtPeso.Text = (monto * 17.08m).ToString();
                        lblDolar.Visible = true;
                        txtDolar.Visible = true;
                        lblDolar.Text = "CAD:";
                        txtDolar.Text = (monto * 1.38m).ToString();
                        lblEuro.Visible = true;
                        txtEuro.Visible = true;
                        lblEuro.Text = "EUR:";
                        txtEuro.Text = (monto * 0.94m).ToString();
                        lblYen.Visible = true;
                        txtYen.Visible = true;
                        lblYen.Text = "JPY:";
                        txtYen.Text = (monto * 154.60m).ToString();
                        break;

                    case "CAD - Dólar canadiense":
                        lblPeso.Visible = true;
                        txtPeso.Visible = true;
                        lblPeso.Text = "MXN:";
                        txtPeso.Text = (monto * 12.40m).ToString();
                        lblDolar.Visible = true;
                        txtDolar.Visible = true;
                        lblDolar.Text = "USD:";
                        txtDolar.Text = (monto * 0.73m).ToString();
                        lblEuro.Visible = true;
                        txtEuro.Visible = true;
                        lblEuro.Text = "EUR:";
                        txtEuro.Text = (monto * 0.68m).ToString();
                        lblYen.Visible = true;
                        txtYen.Visible = true;
                        lblYen.Text = "JPY:";
                        txtYen.Text = (monto * 112.26m).ToString();
                        break;

                    case "EUR - Euro":
                        lblPeso.Visible = true;
                        txtPeso.Visible = true;
                        lblPeso.Text = "MXN:";
                        txtPeso.Text = (monto * 18.17m).ToString();
                        lblDolar.Visible = true;
                        txtDolar.Visible = true;
                        lblDolar.Text = "USD:";
                        txtDolar.Text = (monto * 1.47m).ToString();
                        lblDolarCad.Visible = true;
                        txtDolarCad.Visible = true;
                        lblDolarCad.Text = "CAD:";
                        txtDolarCad.Text = (monto * 1.06m).ToString();
                        lblYen.Visible = true;
                        txtYen.Visible = true;
                        lblYen.Text = "JPY:";
                        txtYen.Text = (monto * 164.55m).ToString();
                        break;

                    case "JPY - Yen japonés":
                        lblPeso.Visible = true;
                        txtPeso.Visible = true;
                        lblPeso.Text = "MXN:";
                        txtPeso.Text = (monto * 0.1104m).ToString();
                        lblDolar.Visible = true;
                        txtDolar.Visible = true;
                        lblDolar.Text = "USD:";
                        txtDolar.Text = (monto * 0.0065m).ToString();
                        lblDolarCad.Visible = true;
                        txtDolarCad.Visible = true;
                        lblDolarCad.Text = "CAD:";
                        txtDolarCad.Text = (monto * 0.0089m).ToString();
                        lblEuro.Visible = true;
                        txtEuro.Visible = true;
                        lblEuro.Text = "EUR:";
                        txtEuro.Text = (monto * 0.0061m).ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Selecciona una moneda.");
            }
        }
    }
}

