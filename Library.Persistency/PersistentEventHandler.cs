using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;

namespace Library.Persistency
{
    public class PersistentEventHandler<T>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<T> _List = new ObservableCollection<T>();
        public ObservableCollection<T> List
        {
            get => _List;
            set
            {
                List = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListObserveable"));
            }
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