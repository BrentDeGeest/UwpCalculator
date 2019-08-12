using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Realdolmen.Vdab.UwpApp.BooksApp
{
    public sealed class RelayCommand : ICommand
    {
        private Action _execute;
        private Predicate<object> _canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action execute) : this(execute, null) { }

        public RelayCommand(Action execute, Predicate<object> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameer)
        {
            _execute.Invoke();
        }
    }
}
