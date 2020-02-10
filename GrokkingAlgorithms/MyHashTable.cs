using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    class Item<T>
    {
        public int Key { get; set; }
        public List<T> Nodes { get; set; }
        public Item(int key)
        {
            Key = key;
            Nodes = new List<T>();
        }
    }
    class MyHashTable<T>
    {
        private Item<T>[] items;
        public MyHashTable(int size)
        {
            items = new Item<T>[size];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item<T>(i);
            }
        }
        public void Add(T item)
        {
            var k = GetHash(item);
            items[k].Nodes.Add(item);
        }
        public bool Search(T item)
        {
            var k = GetHash(item);
            return items[k].Nodes.Contains(item);
        }
        public int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
    }
}
