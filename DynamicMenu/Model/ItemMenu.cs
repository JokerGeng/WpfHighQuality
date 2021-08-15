using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicMenu.Model
{
    class ItemMenu : IItemMenu
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public MenuMode Mode { get; set; }
        public ICommand Command { get; set; }
        public bool IsEnable { get; set; }
        public bool IsVisible { get; set; }
        public string ImageURL { get; set; }
        public IItemMenu Parent { get; set; }
        public List<ISubMenuItem> Childrens { get; set; }
    }
}
