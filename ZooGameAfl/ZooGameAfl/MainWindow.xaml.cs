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

namespace ZooGameAfl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Animal> animals = new();
        public MainWindow()
        {
            InitializeComponent();
            LoadAnimals();
        }
        private void LoadAnimals()
        {
            animals.Add(new Lion("Simba"));
            animals.Add(new Monkey("George"));
            animals.Add(new Elephant("Dumbo"));

            AnimalList.ItemsSource = animals;
            AnimalList.DisplayMemberPath = "Name";
        }
    }
}