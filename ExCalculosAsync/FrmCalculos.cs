using System.Diagnostics;

namespace ExCalculosAsync
{
    public partial class FrmCalculos : Form
    {
        public FrmCalculos()
        {
            InitializeComponent();
            
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            lsbListaExibi��o.Items.Clear();
            Stopwatch stopwatch = new Stopwatch();
            List<string> list = new List<string>();
            btnCalcular.Enabled = false;
            lblAguardeCalculo.Text = "Calculando...Aguarde";
            lblAguardeCalculo.ForeColor = Color.Red;
            stopwatch.Start();
            string folha = await FolhaPagamento();
            lsbListaExibi��o.Items.Add(folha);
            string impostos = await Impostos();
            lsbListaExibi��o.Items.Add(impostos);
            string receita = await Receita();
            lsbListaExibi��o.Items.Add(receita);
            string despesas = await Despesas();
            lsbListaExibi��o.Items.Add(despesas);
            stopwatch.Stop();
            decimal tempo = stopwatch.ElapsedMilliseconds / 1000;
            string oTempo = $"O tempo gasto foi de {tempo.ToString()}s para concluir o c�lculo";
            lsbListaExibi��o.Items.Add(oTempo);
            btnCalcular.Enabled=true;
            lblAguardeCalculo.Text = "C�lculo conclu�do com sucesso";
            lblAguardeCalculo.ForeColor = Color.Green;




        }

        private async Task<string> FolhaPagamento()
        {
            int func1 = 20396;
            int func2 = 45158;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return $"O tatal que ser� pago aos funcionarios � {(func1+ func2).ToString("c2")}";
        }

        private async Task<string> Impostos()
        {
            int gastoFunc = 234000;
            int gastoContas = 89000;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return $"O tatal que ser� pago de impostos � {((gastoFunc + gastoContas)*0.15).ToString("c2")}";
        }
        private async Task<string> Receita()
        {
            int vendas = 780000;
            int assinaturas = 289000;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return $"O tatal gerado esse m�s � {(vendas+ assinaturas).ToString("c2")}";
        }
        private async Task<string> Despesas()
        {
            int gastoFunc = 234000;
            int gastoContas = 89000;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return $"O tatal gasto em despesas � {(gastoFunc + gastoContas).ToString("c2")}";
        }


    }
}