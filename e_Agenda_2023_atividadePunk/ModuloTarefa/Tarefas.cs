namespace e_Agenda_2023_atividadePunk.ModuloTarefa
{
    public class Tarefas //model // entidade
    {
        public int id;
        public string titulo;
        public string prioridade;

        public Tarefas(int id, string titulo, string prioridade)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + titulo + ", Prioridade: " + prioridade;
        }
    }
}
