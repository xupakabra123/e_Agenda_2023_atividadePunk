using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace e_Agenda_2023_atividadePunk.ModuloTarefa
{
    public partial class ListagemDeTarefaControl : UserControl
    {
        List<Tarefas> tarefas = new List<Tarefas>();
        public ListagemDeTarefaControl()
        {
            InitializeComponent();
            tarefas.Add(new Tarefas(1, "Lavar o carro ", "alta"));
            tarefas.Add(new Tarefas(2, "Lavar o cachorro ", "alta"));
            foreach (Tarefas tarefa in tarefas)
            {
                listTarefa.Items.Add(tarefa);
            }
        }
    }
}
