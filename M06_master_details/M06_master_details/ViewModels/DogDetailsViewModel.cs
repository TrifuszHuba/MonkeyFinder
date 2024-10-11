using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using M06_master_details.Models;

namespace M06_master_details.ViewModels
{
    public class DogDetailsViewModel : BindableObject, IQueryAttributable
    {
        public Dog selectedDog { get; set; }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            selectedDog = query["selectedDog"] as Dog;
           // Debug.WriteLine(selectedDog.Name);
            OnPropertyChanged(nameof(selectedDog));
        }
    }
}
