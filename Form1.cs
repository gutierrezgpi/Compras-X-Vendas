using System.Diagnostics;

namespace Compras_X_Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtCalcularClick(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxCompras.Text, out _))
            {
                double compras = Double.Parse(textBoxCompras.Text);
                if (double.TryParse(textBoxVendas.Text, out _))
                {
                    double vendas = Double.Parse(textBoxVendas.Text);

                    if (double.TryParse(tbPorcentagem.Text, out _))
                    {
                        double porcentagem = Double.Parse(tbPorcentagem.Text);

                        double meta_venda = compras + (compras * (porcentagem / 100));
                        meta_venda = Math.Round(meta_venda, 2);
                        double diferenca = vendas - meta_venda;
                        diferenca = Math.Round(diferenca, 2);

                        // Mostra os campos de objetivo e diferença formatados
                        textBoxMeta.Text = meta_venda.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
                        textBoxDiferenca.Text = diferenca.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

                        // Atualiza os campos compra e venda com valores formatados
                        textBoxCompras.Text = compras.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));
                        textBoxVendas.Text = vendas.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

                        if (diferenca >= 0)
                        {
                            textBoxDiferenca.BackColor = Color.FromArgb(240, 240, 240);
                            textBoxDiferenca.ForeColor = Color.FromArgb(0, 128, 0);
                        }
                        else
                        {
                            textBoxDiferenca.BackColor = Color.FromArgb(240, 240, 240);
                            textBoxDiferenca.ForeColor = Color.FromArgb(128, 0, 0);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            this,
                            "Porcentagem não pode ficar em branco!",
                            "Erro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                            );
                    }
                }
                else
                {
                    MessageBox.Show(
                        this,
                        "Digite o valor de vendas",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );

                    if (!textBoxCompras.Focused)
                    {
                        textBoxVendas.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    this,
                    "Digite o valor de compras",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                textBoxCompras.Focus();
            }
        }

        private void AlteraTbPorcentagem(object sender, EventArgs e)
        {
            tbPorcentagem.Value = slidePorcentagem.Value;
        }

        private void AlteraSlidePorcentagem(object sender, EventArgs e)
        {
            slidePorcentagem.Value = (int)tbPorcentagem.Value;
        }

        private void ProximoIndice(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void Fechar(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuSobre(object sender, EventArgs e)
        {
            MessageBox.Show(
                this,
                "Calcula a meta do valor de venda e compara com o valor de venda informado\n\n" +
                "Ícone de DesignContest, disponível em https://icon-icons.com/icon/piggy-bank/20688, usado sob a licença Creative Commons Atribuição 4.0 Internacional (CC BY 4.0). Para mais informações, visite https://www.designcontest.com/. Para ver a licença completa, acesse https://creativecommons.org/licenses/by/4.0/.\n\n" +
                "Além disso, esta aplicação utiliza ícones gerados a partir da fonte Segoe MDL2 Assets fornecida pela Microsoft. Para mais informações, consulte https://learn.microsoft.com/pt-br/windows/apps/design/style/segoe-ui-symbol-font.",
                "Compras X Vendas"
                );
        }

        private void CalcMenuClick(object sender, EventArgs e)
        {
            string calcPath = @"C:\Windows\System32\calc.exe";

            Process calcProcess = new();
            calcProcess.StartInfo.FileName = calcPath;

            calcProcess.Start();
        }

        private void PrintMenuClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new()
            {
                Title = "Salvar como",
                Filter = "PNG (*.png)|*.png|Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*",
                InitialDirectory = Application.StartupPath,
                FileName = "Captura.png"
            };


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filename = saveFileDialog.FileName;

                Thread.Sleep(500);

                Bitmap bmp = CapturarTela(this);

                bmp.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private static Bitmap CapturarTela(Control control)
        {

            Size clientSize = control.ClientSize;

            Point clientLocation = control.PointToScreen(Point.Empty);

            int titleBarHeight = SystemInformation.CaptionHeight + 7;

            clientLocation.Y -= titleBarHeight;

            Bitmap bmp = new(clientSize.Width, clientSize.Height + titleBarHeight);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(clientLocation, Point.Empty, new Size(clientSize.Width, clientSize.Height + titleBarHeight));
            }

            return bmp;
        }
    }
}