using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms
{
    class Person
    {
        public string Name { get; private set; }
        public List<Person> Friends { get; private set; } 
        public Person(List<Person> friends, string name)
        {
            Friends = friends;
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    //Будем искать продавцов манго используя поиск в ширину :)
    class BFSearch
    {
        private Queue<Person> items;
        public BFSearch(List<Person> friends)
        {
            items = new Queue<Person>();
            Add(friends);          
        }
        public bool Search()
        {
            while(items.Count!=0)
            {             
                for (var i = 0; i < items.Count; i++)
                {
                    var element = items.Dequeue();//удаляем из очереди и проверяем его на "Продавца манго"

                    if (element.ToString().Equals("Продавец манго"))
                    {
                        return true;//Продавец манго найден
                    }
                    else
                    {
                        Add(element.Friends);//Добавляем всех друзей в очередь 
                    }
                }
            }
            return false;//Значит продавцов нету вообще
        }
        //Добавляем в основную очередь список друзей для проверки из на "Продавца манго"
        private void Add(List<Person> friends)
        {
            if (friends != null)
            {
                foreach (Person item in friends)
                {
                    items.Enqueue(item);
                }
            }
        }
    }
}
