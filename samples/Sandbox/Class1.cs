using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reactive;
using System.Runtime.CompilerServices;
using ReactiveUI;

namespace Sandbox
{

    public class Class1 : INotifyPropertyChanged
    {
        private string _selectedItem;

        public Class1()
        {
            CreateTreeItemCommand = ReactiveCommand.Create(MyMethod);
            Items.CollectionChanged+=
        }
        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>
        {
            "deerd",
            "drtgyyg",
            "vyuii",
            "ururur",
            "rcrccrybu",
            "8r8r8r8"
        };
        public string SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                NotifyPropertyChanged();
            }
        }
        public ReactiveCommand<Unit, Unit> CreateTreeItemCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void MyMethod()
        {
            Items.Remove(SelectedItem);
        }
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
