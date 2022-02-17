using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;

namespace Sandbox
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.AttachDevTools();
        }

        protected override void OnDataContextEndUpdate()
        {
            base.OnDataContextEndUpdate();
            (DataContext as Class1).Items.CollectionChanged += Items_CollectionChanged;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            FocusManager.Instance?.Focus(this.Find<TreeView>("tr"));
            (DataContext as Class1).SelectedItem = (DataContext as Class1).Items.Last();
        }
    }
}
