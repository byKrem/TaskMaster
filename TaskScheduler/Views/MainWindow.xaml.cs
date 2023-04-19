using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace TaskScheduler.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            List<int> test = new List<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            ListView.ItemsSource = test;
#endif
        }
    }
}
