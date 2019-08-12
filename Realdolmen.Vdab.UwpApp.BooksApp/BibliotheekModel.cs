using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realdolmen.Vdab.UwpApp.BooksApp
{
    public sealed class BibliotheekModel
    {
        // naam
        // lijst van de boeken
        // constructor met naam

        public string Naam { get; set; }
        public List<Boek> Boeken { get; set; } = new List<Boek>();

        public BibliotheekModel(string name)
        {
            Naam = name;
        }
    }
}
