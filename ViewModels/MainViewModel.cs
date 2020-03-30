using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SettingMenuDemo.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<string> _fonts_;

        public MainViewModel()
        {
            this._fonts_ = new ObservableCollection<string>();
            this._fonts_.Add("黑体");
            this._fonts_.Add("宋体");
        }
    }
}
