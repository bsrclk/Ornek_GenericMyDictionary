using System;
using System.Collections.Generic;
using System.Text;

namespace Ornek_GenericMyDictionary
{
    class MyDictionary<T>
    {
        T[] _MyList;
        T[] _TempMyList;
        public MyDictionary()
        {

            _MyList = new T[0];

        }






        public void Add(T BenimTipim)
        {
            _TempMyList = _MyList;
            _MyList = new T[_MyList.Length + 1];

            for (int i = 0; i < _TempMyList.Length; i++)
            {
                _MyList[i] = _TempMyList[i];
            }

            _MyList[_MyList.Length - 1] = BenimTipim;

        }
        
        
        
    
    
         public int Count
        {
            get { return _MyList.Length; }
       
        }
    
    
    
    
    }
}
