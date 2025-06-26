using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public string Text { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
