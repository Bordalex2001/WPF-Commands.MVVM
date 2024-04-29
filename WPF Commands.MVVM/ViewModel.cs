using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_Commands.MVVM
{
    internal class ViewModel
    {
        public ObservableCollection<ColorItem> Colors { get; } = new ObservableCollection<ColorItem>();

        public RelayCommand AddCommand { get; }

        public RelayCommand DeleteCommand { get; }

        public ViewModel() 
        {
            AddCommand = new RelayCommand(Add, CanAdd);
            DeleteCommand = new RelayCommand(Delete);
        }

        private void Add(ColorItem item)
        {
            Colors.Add(item);
        }

        private void Delete(ColorItem item)
        {
            Colors.Remove(item);
        }

        private bool CanAdd(ColorItem item)
        {
            return Colors.Contains(item);
        }

        private bool CanDelete(ColorItem item) 
        { 
            return Colors.Contains(item); 
        }
    }
}
