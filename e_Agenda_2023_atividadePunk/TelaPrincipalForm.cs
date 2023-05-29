using e_Agenda_2023_atividadePunk.Compartilhado;
using e_Agenda_2023_atividadePunk.ModuloCompromissos;
using e_Agenda_2023_atividadePunk.ModuloContato;
using e_Agenda_2023_atividadePunk.ModuloDespesas;
using e_Agenda_2023_atividadePunk.ModuloTarefa;

namespace e_Agenda_2023_atividadePunk
{
    public partial class e_Agenda : Form
    {
        private ControladorBase controlador;
        public e_Agenda()
        {
            InitializeComponent();
        }
        private void contadosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato();
            
            ConfigurarTelaPrincipal(controlador);
        }
        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            ListagemDeCompromissosControl listagemDeCompromisso = new ListagemDeCompromissosControl();
            labelTipoCaadastro.Text = "Cadastro de  compromissos";         
            listagemDeCompromisso.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagemDeCompromisso);
        }
        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            
            controlador = new ControladorTarefas();
            ConfigurarTelaPrincipal(controlador);
        }
        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            labelTipoCaadastro.Text = controladorBase.ObterTipoDeCadastro();
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }
        private void despesasMenuItem_Click(object sender, EventArgs e)
        {
            ListagemDeDespesasControl listatagemDeDespesas = new ListagemDeDespesasControl();
            listatagemDeDespesas.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listatagemDeDespesas);
        }
        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTioExcluir;
        }
      
        private void btnInserir_Click(object sender, EventArgs e)
        {
           controlador.Inserir();

        }
    }
}