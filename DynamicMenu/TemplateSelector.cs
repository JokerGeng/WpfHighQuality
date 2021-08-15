using DynamicMenu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DynamicMenu
{
    public class TemplateSelector:DataTemplateSelector
    {
        public DataTemplate One { get; set; }
        public DataTemplate Two { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            ISubMenuItem sub = (ISubMenuItem)item;

            if(sub.Mode==MenuMode.Button)
            {
                return One;
            }
            return Two;
        }
    }
}
