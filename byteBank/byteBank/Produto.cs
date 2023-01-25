using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    public class Produto
    {
        public string? Nome { get; set; }
        public string? Fabricante { get; set; }
        public int CodigoBarras { get; set; }
        public double Valor { get; set; }
        public double ValorCompra { get; set; }
        public int Quantidade { get; set; }
    }
}
