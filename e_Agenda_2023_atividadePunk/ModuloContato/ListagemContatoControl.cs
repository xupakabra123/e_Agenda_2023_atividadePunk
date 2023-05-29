using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda_2023_atividadePunk.ModuloContato
{
    public partial class ListagemContatoControl : UserControl
    {
        List<Contato> contatos = new List<Contato>();
        public ListagemContatoControl()
        {
            InitializeComponent();
            contatos.Add(new Contato(1, "Carnerio man", "Uniplac"));
            contatos.Add(new Contato(2, "Pedro Escamoso man", "Uniplac"));
            foreach (Contato item in contatos)
            {
                listContato.Items.Add(item);
            }
        }

    }

}
