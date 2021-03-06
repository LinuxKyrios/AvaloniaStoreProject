using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaStoreProject.ViewModels;
using ReactiveUI;

namespace AvaloniaStoreProject.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.WhenActivated(d => d(ViewModel.ShowDialog.RegisterHandler(DoShowDialogAsync)));
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        /* This method creates the AvaloniaStoreWindow,
         * it sets its DataContext to interaction.Input,
         * which is the instance of the ViewModel */
        private async Task DoShowDialogAsync(InteractionContext<AvaloniaStoreViewModel, StackViewModel?> interaction)
        {
            var dialog = new AvaloniaStoreWindow();
            dialog.DataContext = interaction.Input;

            var result = await dialog.ShowDialog<StackViewModel?>(this);
            interaction.SetOutput(result);
        }
    }
}