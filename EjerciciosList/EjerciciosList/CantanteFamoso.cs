using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosList
{
    class CantanteFamoso
    {
        private string name;
        private string discoConMasVentas;

        public CantanteFamoso(string name, string discoConMasVentas)
        {
            this.name = name;
            this.discoConMasVentas = discoConMasVentas;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string Getdiscos()
        {
            return discoConMasVentas;
        }
        public void Setdiscos(string discoConMasVentas)
        {
            this.discoConMasVentas = discoConMasVentas;
        }


    }
}
