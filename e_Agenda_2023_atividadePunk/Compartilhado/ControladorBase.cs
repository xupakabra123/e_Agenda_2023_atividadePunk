using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda_2023_atividadePunk.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTioExcluir { get; }
        public abstract void Inserir();
        public abstract UserControl ObterListagem();
        public abstract string ObterTipoDeCadastro();
    }
   
}


