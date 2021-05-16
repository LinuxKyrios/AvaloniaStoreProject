using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ReactiveUI;
using System.Reactive.Linq;

namespace AvaloniaStoreProject.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        //Created function for BuyTechCommand
        public MainWindowViewModel()
        {
            ShowDialog = new Interaction<AvaloniaStoreViewModel, StackViewModel?>();
            
            BuyTechCommand = ReactiveCommand.Create(async () =>
            {
                var store = new AvaloniaStoreViewModel();

                var result = await ShowDialog.Handle(store);
            });
        }
        
        public ICommand BuyTechCommand { get; }
        
        public Interaction<AvaloniaStoreViewModel, StackViewModel?> ShowDialog { get; }
    }

}