using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4.Classes
{
    public class Cat
    {
        private static Cat _singleCat;

        private Cat()
        {
        }

        public static Cat GetCat
        {
            get
            {
                if (_singleCat == null)
                {
                    _singleCat = new Cat();
                }

                return _singleCat;
            }
        }

        public event Action WakeUpEvent;

        public void CatIsVisible()
        {
            
            WakeUpEvent?.Invoke();
        }
    }
}
