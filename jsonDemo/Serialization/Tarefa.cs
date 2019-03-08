using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonDemo.Serialization
{
    public class Tarefa
    {

        public string titulo { get; set; }
        public string descricao { get; set; } 
        public string dtInicio { get; set; }
        public string dtPrevisto { get; set; }
        public int tempoEstimado { get; set; }

    }
}
