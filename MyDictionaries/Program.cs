using System;

namespace MyDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1,"Serdeha");
            myDictionary.Add(2,"Mehmet");
            myDictionary.Add(3,"Mutluay");
            myDictionary.Add(4,"Test");

            Console.WriteLine($"Kişi 1 : {myDictionary[0]}");
            Console.WriteLine($"My Dictionary Count : {myDictionary.Count}");
            Console.WriteLine("---------------------------");

            foreach (string dictionary in myDictionary.Items)
            {
                Console.WriteLine(dictionary);
            }
        }
    }

    class MyDictionary<TKey,TValue>
    {
        TKey[] _key;
        TValue[] _value;

        TKey[] _tempKey;
        TValue[] _tempValue;

        public MyDictionary()
        {
            _key = new TKey[0];
            _value = new TValue[0];
        }

        public void Add(TKey key,TValue value)
        {
            _tempKey = _key;
            _tempValue = _value;

            _key = new TKey[_key.Length + 1];
            _value = new TValue[_value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
                _value[i] = _tempValue[i];
            }

            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

        public int Count
        {
            get { return _key.Length; }
        }

        public TValue this[int index]
        {
            get { return _value[index]; }
        }

        public TValue[] Items
        {
            get { return _value; }
        }
    }
}
