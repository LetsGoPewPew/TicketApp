using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistency
{
    public class Persistent<T>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<T> _List;
        public ObservableCollection<T> List
        {
            get => _List;
            set
            {
                List = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListObserveable"));
            }
        }

        public Persistent()
        {
            List = new ObservableCollection<T>();
        }

        private void List_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Debug.WriteLine("Change type: " + e.Action);
            if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                Debug.WriteLine("removed");
            }
            if (e.NewItems != null)
            {
                Debug.WriteLine("Items added: ");
                foreach (var item in e.NewItems)
                {
                    Debug.WriteLine(item);
                }
            }

            if (e.OldItems != null)
            {
                Debug.WriteLine("Items removed: ");
                foreach (var item in e.OldItems)
                {
                    Debug.WriteLine(item);
                }
            }

            throw new NotImplementedException();
        }
    }
}