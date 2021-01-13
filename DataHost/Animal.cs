using Prism.Mvvm;

namespace DataHost
{
    public class Animal : BindableBase
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _breed;

        public string Breed
        {
            get => _breed;
            set => SetProperty(ref _breed, value);
        }
    }
}