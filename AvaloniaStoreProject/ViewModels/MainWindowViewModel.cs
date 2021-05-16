using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ReactiveUI;

namespace AvaloniaStoreProject.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        //Created function for BuyTechCommand
        public MainWindowViewModel()
        {
            BuyTechCommand = ReactiveCommand.Create(() =>
            {

            });
        }
        
        public ICommand BuyTechCommand { get; }
    }

}