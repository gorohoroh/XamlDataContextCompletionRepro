using System.Collections.Generic;

namespace XamlDataContextCompletionRepro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            MyItemsControl.ItemsSource = new List<MyType>
            {
                new MyType {Text = "A"},
                new MyType {Text = "B"},
                new MyType {Text = "C"}
            };
        }
    }

    public class MyType
    {
        public string Text { get; set; }
    }
}