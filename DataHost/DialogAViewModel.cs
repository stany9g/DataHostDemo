using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace DataHost
{
    public class DialogAViewModel : BindableBase
    {
        private ObservableCollection<Person> _people;

        public ObservableCollection<Person> People
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }


        public DialogAViewModel()
        {
            People = new ObservableCollection<Person>(Generator.GetPeople());
        }

    }
}