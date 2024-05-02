using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo_API.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public bool Available { get; set; } 
        public decimal Valor { get; set; }
    }
}