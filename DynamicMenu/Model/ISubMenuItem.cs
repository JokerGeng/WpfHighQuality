using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicMenu.Model
{
    public interface ISubMenuItem
    {
        string Name { get;  set; }

        string Content { get; set; }

        int Index { get; set; } 

        MenuMode Mode { get; set; }

        ICommand Command { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        bool IsEnable { get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        bool IsVisible { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        string ImageURL { get; set; }

        ISubMenuItem Parent { get; set; }

        List<ISubMenuItem> Childrens { get; set; }

        object Parameter { get; set; }

        void Excute();
    }
}
