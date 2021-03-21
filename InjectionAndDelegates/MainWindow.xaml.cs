using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InjectionAndDelegates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CmdTest_Click(object sender, RoutedEventArgs e)
        {
            Injected injected1 = new Injected("Pippo");
            string s1 = injected1.YourNameAndDouble(1);

            string s2= execute("Pluto", (i => i.YourNameAndDouble(3)));
        }


        //Fa qualcosa con l'oggetto e poi esegue le lambda passata come parametro, il primo parametro può esserci o non esserci
        private static string execute (string name, Func<Injected,string> func)
        {
            Injected injected = new(name);
            return func(injected);
        }
    }
}
