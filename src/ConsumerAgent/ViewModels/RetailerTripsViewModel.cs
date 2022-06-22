using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ConsumerAgent.ViewModels
{
    public class RetailerTripsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand AddTransactionsCommand { get; private set; }

        public RetailerTripsViewModel()
        {
            AddTransactionsCommand = new Command(async () => await Shell.Current.GoToAsync("addtransactions"));
        }
    }
}
