using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3.Fiap.Models
{
    class Casa
    {

        //Propriedades
        public int Comodos { get; set; }
        public bool Piscina { get; set; }
        public double AreaTotal { get; set; }

        //Contrutores

        public Casa(int comodos, bool piscina, double areaTotal)
        {
            Comodos = comodos;
            Piscina = piscina;
            AreaTotal = areaTotal;
        }

        //Construtor que recebe apenas a àrea
        public Casa(double areaTotal)
        {
            AreaTotal = areaTotal;  
        }

        //Construtor sem parâmetros
        public Casa() { }
        
    }
}
