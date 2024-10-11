using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MonkeyFinder.Models;
using MonkeyFinder.Services;

namespace MonkeyFinder.ViewModels
{
    public class MonkeysViewModel
    {
        public List<Monkey> monkeys { get; set; } = new List<Monkey>();

        public MonkeysViewModel()
        {
            loadData();
        }

        private async void loadData()
        {
            monkeys = await MonkeyService.getMonkeys();
        }
    }
}
