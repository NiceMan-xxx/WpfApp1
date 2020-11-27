using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NUnit.Framework.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WpfApp2.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        public int ID { get; set; }
        List<tt> tts = new List<tt>();
        public MainViewModel()
        {
            RelayCommand = new RelayCommand<int>(r=>test(r)) ;
            
        }
        public RelayCommand<int>  RelayCommand { get; set; }
        public void test(int r)
        {
            tts.Where<tt>(q => q.name == 1);
        }
        public int ii { get; set; }
    }
    public class tt
    {
        public int name { get; set; }
    }
    
}