using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLoca.Entity

{
    public class Veiculo
    {
        public int IdVeiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string Renavam { get; set; }
        public int Hodometro { get; set; }
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
    }

}
