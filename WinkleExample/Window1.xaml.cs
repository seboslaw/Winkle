using System;
using System.Collections.Generic;
using System.Linq;
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


namespace WinkleExample
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

           // string pathToExampleFile = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "winkleExample.xml";

            Winkle.VersionCheck myUpdateChecker = new Winkle.VersionCheck("Desktop Google Reader", "file:///Q:/Dev/GitHub/Winkle/WinkleExample/winkleExample.xml");
            Winkle.UpdateInfo myUpdateResponse = myUpdateChecker.checkForUpdate(System.Reflection.Assembly.GetExecutingAssembly(), false);
            Console.WriteLine("bla");
        }
    }
}
