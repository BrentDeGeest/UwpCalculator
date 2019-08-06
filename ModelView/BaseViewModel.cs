using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public abstract class BaseViewModel<TModel> : INotifyPropertyChanged
    {
        public TModel Model { get; }
        public event PropertyChangedEventHandler PropertyChanged;
        
        public BaseViewModel(TModel model)
        {
            Model = model; 
        }

        protected bool SetProperty<T>(T currentvalue, T newValue, Action setValue,
            [CallerMemberName]string propertyName = null)
        {
            if(!EqualityComparer<T>.Default.Equals(currentvalue, newValue))
            {
                setValue();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        protected bool SetProperty<T>(ref T field, T value,
            [CallerMemberName]string propertyName = null)
        {
            if(!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }
    }
}
