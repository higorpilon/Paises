using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paises.Modelos
{
  public  class Pais
    {
        public string Nome { get; set; }
        public List<string> DominioWeb { get; set; }
        public string AlphaDoisCode { get; set; }
        public string AlphaTresCode { get; set; }
        public List<string> Ddi { get; set; }
        public string Capital { get; set; }
        public List<object> altSpellings { get; set; }
        public string Regiao { get; set; }
        public string SubRegiao { get; set; }
        public int Populacao { get; set; }
        public List<object> LatLong { get; set; }
        public string Demonym { get; set; }
        public double Area { get; set; }
        public double? Gini { get; set; }
        public List<string> Timezones { get; set; }
        public List<object> Fronteiras { get; set; }
        public string NativeName { get; set; }
        public string NumericCode { get; set; }
        public List<Currency> Currencies { get; set; }
        public List<Language> Linguas { get; set; }
        public  Translation Traducoes { get; set; }
        public string Bandeira { get; set; }
        public List<object> RegionalBlocs { get; set; }
        public string Cioc { get; set; }
    }
}
