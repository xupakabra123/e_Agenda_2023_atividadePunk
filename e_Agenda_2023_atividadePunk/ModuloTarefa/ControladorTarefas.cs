using e_Agenda_2023_atividadePunk.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda_2023_atividadePunk.ModuloTarefa
{
    internal class ControladorTarefas : ControladorBase
    {
        public override string ToolTipInserir { get { return "inserir nova tarefa"; } }

        public override string ToolTipEditar { get { return "Editar tarefa existente"; } }
        public override string ToolTioExcluir { get { return "Excluir tarefa existente"; } }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            telaTarefa.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
           return new ListagemDeTarefaControl();
        }

        public override string ObterTipoDeCadastro()
        {
            return "Cadastro de tarefas";
        }
    }
}
