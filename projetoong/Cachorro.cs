using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoong {
    class Cachorro {


        public string nome { get; set; }
        public string? doenca { get; set; }


        public void Checkup() {
            Console.WriteLine("Foi encontrando doenças no cachorro ?");
            bool decision = bool.Parse(Console.ReadLine());
            if (decision) this.doenca = Console.ReadLine();

        }
    }
}
