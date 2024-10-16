using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Core;
using WpfApp1.Service;
using WpfApp1.Service.Interfaces;
//using WpfApp1.Service;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Func<Type, BaseViewModel> viewModelFactory = (type) =>
            {
                if (type == typeof(AboutViewModel))
                {
                    return new AboutViewModel();
                }
                else if (type == typeof(HomeViewModel))
                {
                    return new HomeViewModel();
                }

                // Add more view models as needed
                throw new ArgumentException("Unknown ViewModel type");
            };

            // Pass the factory function to NavigateService
            INavigateService navigateService = new NavigateService(viewModelFactory);

            DataContext = new MainViewModel(navigateService);
        }
    }
}