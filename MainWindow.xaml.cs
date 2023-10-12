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

namespace znsdWPF
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

            Task.Run(() =>
            {
                //Application.Current.Dispatcher.Invoke(new Action(()
                this.aaa.Dispatcher.Invoke(new Action(() =>
                {
                    Task.Delay(1000).Wait();    
                    this.aaa.Content = "znsd btn 111";
                }));
            });
        }

       
    }
}
