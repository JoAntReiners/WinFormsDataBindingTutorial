using System.ComponentModel;

namespace InventoryManager.Data
{
    public class Item :INotifyPropertyChanged
    {
       public string Name { get; set; }

       public event PropertyChangedEventHandler PropertyChanged;
    }
}
