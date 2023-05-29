using e_Agenda_2023_atividadePunk.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda_2023_atividadePunk.ModuloContato
{
    internal class ControladorContato : ControladorBase
    {
        public override string ToolTipInserir { get { return "inserir novo contato"; } }

        public override string ToolTipEditar { get { return "Editar contato existente"; } }
        public override string ToolTioExcluir { get { return "Excluir contato existente"; } }

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();
            telaContato.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
            return new ListagemContatoControl();
        }

        public override string ObterTipoDeCadastro()
        {
            return "Cadastro de contatos";
        }
    }
}
