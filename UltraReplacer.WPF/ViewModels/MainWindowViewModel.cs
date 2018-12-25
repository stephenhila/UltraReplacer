using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraReplacer.WPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value; OnPropertyChanged("Text");
            }
        }

        public MainWindowViewModel()
        {
            _text = string.Empty;
        }
    }
}
