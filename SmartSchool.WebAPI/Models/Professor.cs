namespace SmartSchool.WebAPI.Models
{
    public class Professor
    {
        public Professor() { }

        public Professor(int professorId, string nome, string sobrenome)
        {
            this.ProfessorId = professorId;
            this.Nome = nome;
            this.Sobrenome = sobrenome;

        }
        public int ProfessorId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}