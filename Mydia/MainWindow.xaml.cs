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

//Add
using MahApps.Metro.Controls;
using System.Diagnostics;

namespace Mydia {
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : MetroWindow {
		public MainWindow() {
			InitializeComponent();
		}

        private void VolBtn_Click(object sender, RoutedEventArgs e) {
            VolPopup.IsOpen = false;
            VolPopup.IsOpen = true;
        }

        private void STitle_MouseDoubleClick(object sender, MouseButtonEventArgs e) {

        }
    }
}
