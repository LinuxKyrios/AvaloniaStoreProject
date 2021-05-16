using System.Collections.ObjectModel;
using System.IO;
using System.Reactive;
using ReactiveUI;

namespace AvaloniaStoreProject.ViewModels
{
    public class AvaloniaStoreViewModel : ViewModelBase
    {
        public AvaloniaStoreViewModel()
        {
            BuyTechCommand = ReactiveCommand.CreateFromTask(async () =>
            {
                
            });
        }
        
        private string? _searchText;
        private bool _isBusy;
        private StackViewModel? _selectedStack;


        public StackViewModel? SelectedStack
        {
            get => _selectedStack;
            set => this.RaiseAndSetIfChanged(ref _selectedStack, value);
        }

        public string? SearchText
        {
            get => _searchText;
            set => this.RaiseAndSetIfChanged(ref _searchText, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            set => this.RaiseAndSetIfChanged(ref _isBusy, value);
        }
        
        public ReactiveCommand<Unit, StackViewModel?> BuyTechCommand { get; }
        
        public ObservableCollection<StackViewModel> SearachResults { get; }
    }
}