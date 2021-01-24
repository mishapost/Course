using HomeWork2.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;

namespace HomeWork2.UserCollection
{
    public class MyCollection<T> : IEnumerable where T : IMyClass
    {
        public List<T> Collection { get; set; }

        public MyCollection()
        {
            Collection = new List<T>();
        }

        public IEnumerator GetEnumerator()
        {
            //  return Collection.GetEnumerator();
            return new MyIterator<T>(Collection); //Смысла в реализации Iterator-a нет, т.к. он уже реализован в List
        }

        /// <summary>Добавление элемента в коллекцию </summary>
        /// <param name="col"></param>
        public void Add(T col)
        {
            Collection.Add(col);
        }


        /// <summary> Удаление элемента из коллекции. По условию задачи удаление возможно если в коллекции больше 5 элементов </summary>
        /// <param name="col"></param>
        public void Delete(T col)
        {
            if (Collection.Count > 5)
            {
                Collection.Remove(col);
            }
            else
            {
                throw new Exception(
                    "Удаление из коллекции элементов, в случае их количества 5 и менее запрещено условиями задачи");
            }

        }

        /// <summary>К-во записей в коллекции </summary>
        /// <returns></returns>
        public int Count() 
        {
            return Collection.Count;
        }
    
    }
   



}
