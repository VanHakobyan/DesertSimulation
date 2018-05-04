using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DesktopApp.Base_classes
{
    public class ViewModel<T> : INotifyPropertyChanged where T : FrameworkElement
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public T View { get; }

        protected ViewModel(T view = null)
        {
            View = view ?? ((T)Activator.CreateInstance(typeof(T)));
            View.DataContext = this;
        }

        protected void Notify([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
