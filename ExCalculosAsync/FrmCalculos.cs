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
            lsbListaExibição.Items.Clear();
            Stopwatch stopwatch = new Stopwatch();
            List<string> list = new List<string>();
            btnCalcular.Enabled = false;
            lblAguardeCalculo.Text = "Calculando...Aguarde";
            lblAguardeCalculo.ForeColor = Color.Red;
            stopwatch.Start();
            string folha = await FolhaPagamento();
            lsbListaExibição.Items.Add(folha);
            string impostos = await Impostos();
            lsbListaExibição.Items.Add(impostos);
            string receita = await Receita();
            lsbListaExibição.Items.Add(receita);
            string despesas = await Despesas();
            lsbListaExibição.Items.Add(despesas);
            stopwatch.Stop();
            decimal tempo = stopwatch.ElapsedMilliseconds / 1000;
            string oTempo = $"O tempo gasto foi de {tempo.ToString()}s para concluir o cálculo";
            lsbListaExibição.Items.Add(oTempo);
            btnCalcular.Enabled=true;
            lblAguardeCalculo.Text = "Cálculo concluído com sucesso";
            lblAguardeCalculo.ForeColor = Color.Green;




        }

        private async Task<string> FolhaPagamento()
        {
            int func1 = 20396;
            int func2 = 45158;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return $"O tatal que será pago aos funcionarios é {(func1+ func2).ToString("c2")}";
        }

        private async Task<string> Impostos()
        {
            int gastoFunc = 234000;
            int gastoContas = 89000;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return $"O tatal que será pago de impostos é {((gastoFunc + gastoContas)*0.15).ToString("c2")}";
        }
        private async Task<string> Receita()
        {
            int vendas = 780000;
            int assinaturas = 289000;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return $"O tatal gerado esse mês é {(vendas+ assinaturas).ToString("c2")}";
        }
        private async Task<string> Despesas()
        {
            int gastoFunc = 234000;
            int gastoContas = 89000;
            await Task.Delay(TimeSpan.FromSeconds(2));
            return $"O tatal gasto em despesas é {(gastoFunc + gastoContas).ToString("c2")}";
        }


    }
}