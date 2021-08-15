using DynamicMenu.Model;
using MvvmLibary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml;
using System.Xml.Linq;

namespace DynamicMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Command = new DelegateCommand<string>(Excute);
            Initialize();
            this.list.ItemsSource = Menus;
        }

        public ObservableCollection<ISubMenuItem> Menus { get; set; } = new ObservableCollection<ISubMenuItem>();

        void Initialize()
        {
            XDocument document = XDocument.Load("./MenuConfig.xml");
            foreach (var menu in document.Descendants("SubMenuItem"))
            {
                ISubMenuItem sub = new SubMenuItem();
                sub.Name = menu.Attribute("Name").Value;
                sub.Parameter = menu.Attribute("Parameter").Value;
                sub.Mode = (MenuMode)Enum.Parse(typeof(MenuMode), menu.Attribute("Mode").Value);
                if (menu.Attribute("Parent") != null)
                {
                    string name = menu.Attribute("Parent").Value;
                    var parentMenu = Menus.ToList().Find(t => t.Name == name);
                    if(parentMenu!=null)
                    {
                        parentMenu.Childrens.Add(sub);
                        sub.Parent = parentMenu;
                    }
                }
                else
                {
                    Menus.Add(sub);
                }
                sub.Command = Command;
            }
        }

        public DelegateCommand<string> Command { get; set; }

        public void Excute(string parameter)
        {
            Console.WriteLine(parameter);
        }
    }
}
