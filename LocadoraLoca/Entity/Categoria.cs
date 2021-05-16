using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraLoca.Entity   
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public bool DirecaoHidraulica { get; set; }
        public int QuantidadeAssentos { get; set; }
        public bool Airbag { get; set; }
        public string PotenciaMotor { get; set; }
        public bool OffRoad { get; set; }
        public bool ArCondicionado { get; set; }
        public List<Veiculo> Veiculos { get; internal set; }
    }
}
