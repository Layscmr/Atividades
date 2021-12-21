using System;

namespace projetoong {
    class Program {
        static void Main(string[] args) {

            Cachorro[] x = new Cachorro[10];

          for(int i = 0; i < 10; i+= 1) {
                x[i] = new Cachorro();
                x[i].nome = Console.ReadLine();
                x[i].doenca = null;
            }

          foreach(Cachorro y in x) {
                y.Checkup();
            }
        }
    }
}
