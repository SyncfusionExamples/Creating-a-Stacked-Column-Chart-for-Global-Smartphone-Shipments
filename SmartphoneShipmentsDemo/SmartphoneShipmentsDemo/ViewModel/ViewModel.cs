using System.Collections.ObjectModel;

namespace SmartphoneShipmentsDemo
{
    public class ViewModel
    {
        public ObservableCollection<Model> ShipmentsData { get; set; }

        public ViewModel()
        {
            ShipmentsData = new ObservableCollection<Model>()
            {
                 new Model ("Oppo", 31.32, 26.55, 26.62, 20.61, 8.7),
                 new Model ("Vivo",28.71, 26.44, 26.83, 24, 8.8),
                 new Model ("Xiaomi", 38.5, 39.1, 40.2, 33, 12.5),
                 new Model ("Apple", 56.99,  44.93,  48.6, 71.24,  18.4),
                 new Model ("Samsung", 74, 62, 64, 58 , 21.4)
                
           };

        }
    }
}
