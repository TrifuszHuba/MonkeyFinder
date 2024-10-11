using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using M06_master_details.Data;
using M06_master_details.Models;


namespace M06_master_details.ViewModels
{
    public class DogsViewModel : BindableObject
    {
		private List<Dog> _dogs;

		public List<Dog> dogs
		{
			get { return _dogs; }
			set { _dogs = value; OnPropertyChanged(); }
		}

        public Dog selectedDog { get; set; }

        public string dogName { get; set; }

        public ICommand showDogDetails { get; private set; }

        public ICommand searchDog { get; set; }

        public DogsViewModel()
        {
            dogs = DogData.Dogs;

            showDogDetails = new Command( async () => {
                //Debug.WriteLine("OK");
                //Debug.WriteLine(selectedDog.Name);
                var navigationParameters = new Dictionary<string, object>
                {
                    {"selectedDog",selectedDog },
                    
                };
                await Shell.Current.GoToAsync("dogdetails",navigationParameters);
            });

            searchDog = new Command(() => {
                dogs = DogData.Dogs;
                dogs = dogs.Where(x => x.Name.ToLower().Contains(dogName.ToLower())).ToList();
            });
        }
    }
}
