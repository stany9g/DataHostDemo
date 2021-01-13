using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace DataHost
{
    public class DialogBViewModel : BindableBase
    {
        private ObservableCollection<Animal> _animals;

        public ObservableCollection<Animal> Animals
        {
            get => _animals;
            set => SetProperty(ref _animals, value);
        }

        public DialogBViewModel()
        {
            Animals = new ObservableCollection<Animal>(Generator.GetAnimals());
        }
    }
}