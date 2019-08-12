using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Realdolmen.Vdab.UwpApp.BooksApp
{
    public sealed class BibliotheekViewModel : BaseViewModel<BibliotheekModel>
    {
        // overerven van baseviewmodel, observable collection
        // relay commands
        // komen de methodes in

        private View _selectedBook;
        private ObservableCollection<View> _Boeken;
        public readonly ICommand AddBookCommand;
        public readonly ICommand RemoveBookCommand;

        public BibliotheekViewModel(BibliotheekModel model) : base(model)
        {
            _Boeken = new ObservableCollection<View>();

            foreach (Boek boek in model.Boeken)
            {
                var boekViewModel = new View(boek);
                _Boeken.Add(boekViewModel);
            }

            AddBookCommand = new RelayCommand(() => AddBoek());
            RemoveBookCommand = new RelayCommand(() => RemoveBoek());
        }

        public string BibliotheekNaam
        {
            get => Model.Naam;
            set => SetProperty(Model.Naam, value, () => Model.Naam = value);
        }
        public View SelectedBook
        {
            get => _selectedBook;
            set => SetProperty(ref _selectedBook, value);
        }
        public ObservableCollection<View> Boeken
        {
            get => _Boeken;
            set => SetProperty(ref _Boeken, value);
        }

        private void AddBoek()
        {
            Boeken.Add(new View(new Boek
            {
                Naam = "TestNaam",
                Auteur = "TestAuteur",
                Nummer = "TestNummer"
            }));
        }

        private void RemoveBoek()
        {
            Boeken.Remove(SelectedBook);
        }
    }
}
