namespace e_Agenda_2023_atividadePunk.ModuloContato
{
    public class Contato
    {
        public int id;
        public string name;
        public string empresa;

        public Contato(int id, string name, string empresa)
        {
            this.id = id;
            this.name = name;
            this.empresa = empresa;
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + name + ", Empresa: " + empresa;
        }

    }
    
}
