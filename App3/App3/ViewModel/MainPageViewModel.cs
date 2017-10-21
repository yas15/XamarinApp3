using System;
using App3.Model;
using System.Collections.ObjectModel;
using static System.Math;

namespace App3.ViewModel
{
    class MainPageViewModel
    {
        // The ObservableCollection<T> is exactly the same as a list<T>, however the ObservableCollection<T> class, 
        // has a built-in implementation of the INotifyCollectionChanged interface. 
        // So that whenever we add, remove or update an item in the ObservableCollection, the ObservableCollection
        // will raise an event and the UI will automatically be updated.
        // With WPF, C# will automatically add a CollectionChanged event handler, to any WPF objects 
        // that are binded to the ObservableCollection. So that whenever the ObservableCollecion is updated, and the 
        // the ObservableCollecion raises a change event, the WPF object can handle the event.

        // define a new property of type ObservableCollection<Person> i.e. a collection containing <Person> elements called People
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        public MainPageViewModel()
        {
            Random rand = new Random();

            for (int i = 1; i < 8; i++)
            {
                Person person = new Person();

                person.FirstName = "Cristiano ";
                person.LastName = "Ronaldo" + i.ToString();
                person.Age = (decimal)(35 + rand.NextDouble());
                People.Add(person);
            }

        }

    }
}
