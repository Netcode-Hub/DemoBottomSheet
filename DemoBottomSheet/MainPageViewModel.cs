using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBottomSheet
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        void Show()
        {
            MySheet sheet = new MySheet();
            sheet.ShowAsync();
        }
    }
}
