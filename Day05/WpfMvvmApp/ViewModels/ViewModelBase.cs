using System.ComponentModel;

namespace WpfMvvmApp.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //위에 11,12번째 줄하고 똑같은 의미이다.
        }
    }
}
