using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;

namespace Library.Persistency
{
    public class PersistentEventHandler<T, T2> where T2 : IPersistMethod
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<T> _List = new ObservableCollection<T>();
        public ObservableCollection<T> List { get => _List; set => _List = value; }

        private IPersistMethod PersistMethod;
        public PersistentEventHandler(T2 persistMethod)
        {
            PersistMethod = persistMethod;
            List.CollectionChanged += List_CollectionChanged;
        }

        private void List_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Debug.WriteLine("Change type: " + e.Action);
            if (e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    PersistMethod.Create(item);
                }
            }

            if (e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                {
                    PersistMethod.Delete(item);
                }
            }
        }
    }
}