
using M06_master_details.Views;

namespace M06_master_details
{
    public partial class AppShell : Shell
    {
        public Dictionary<string, Type> routes { get; private set; } = new Dictionary<string, Type>();

        public AppShell()
        {
            InitializeComponent();
            registerRoutes();
        }

        private void registerRoutes()
        {
            routes.Add("dogdetails", typeof(DogDetailsView));

            foreach (var route in routes) { 
                Routing.RegisterRoute(route.Key, route.Value);
            }
        }
    }
}
