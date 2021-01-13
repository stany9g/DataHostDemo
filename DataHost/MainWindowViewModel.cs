using System.Security.Cryptography;
using System.Threading.Tasks;
using MaterialDesignThemes.Wpf;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace DataHost
{
    public class MainWindowViewModel : BindableBase
    {
        private DialogA _cachedViewA;
        private DialogB _cachedViewB;
        public DelegateCommand DialogA { get; set; }
        public DelegateCommand DialogB { get; set; }


        public MainWindowViewModel()
        {
            DialogA = new DelegateCommand(async () => await ShowA());
            DialogB = new DelegateCommand(async () => await ShowB());
        }


        private async Task ShowA()
        {
            //show the dialog

            _cachedViewA ??= new DialogA() { DataContext = new DialogAViewModel() };

            await DialogHost.Show(_cachedViewA);
        }

        private async Task ShowB()
        {
            //show the dialog

            _cachedViewB ??= new DialogB() { DataContext = new DialogBViewModel() };

            await DialogHost.Show(_cachedViewB);
        }
    }
}