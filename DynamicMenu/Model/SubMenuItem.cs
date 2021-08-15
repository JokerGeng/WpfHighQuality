using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicMenu.Model
{
    public class SubMenuItem : ISubMenuItem
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public int Index { get; set; }
        public MenuMode Mode { get; set; }
        public ICommand Command { get; set; }
        public bool IsEnable { get; set; }
        public bool IsVisible { get; set; }
        public string ImageURL { get; set; }
        public ISubMenuItem Parent { get; set; }
        public List<ISubMenuItem> Childrens { get; set; } = new List<ISubMenuItem>();
        public object Parameter { get; set; }

        public void Excute()
        {
            if(Command!=null)
            {
                Command.Execute(Parameter);
            }
        }
    }
}
