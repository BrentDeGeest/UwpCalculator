using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realdolmen.Vdab.UwpApp.BooksApp
{
    public sealed class View : BaseViewModel<Boek>
    {
        // viewmodel(moet overerven van de baseviewmodel)
        // set properties

        public View(Boek boek) : base(boek) { }
        public string Naam
        {
            get => Model.Naam;
            set => SetProperty(Model.Naam, value, () => Model.Naam = value);
        }
        public string Auteur
        {
            get => Model.Auteur;
            set => SetProperty(Model.Auteur, value, () => Model.Auteur = value);
        }
        public string Nummer
        {
            get => Model.Nummer;
            set => SetProperty(Model.Nummer, value, () => Model.Nummer = value);
        }
    }
}
