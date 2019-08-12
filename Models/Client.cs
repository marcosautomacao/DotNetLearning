using System;

namespace DotNetLearning.Models
{
    public class Client 
    {
        public Client()
        {
            userId = Guid.NewGuid();
        }
        public Guid userId { get; }
        public string Nome { get; set; }
        public int? Idade { get; set; }
        public string Cidade { get; set; }
        public DateTime Criação { get; set; }
    }
}