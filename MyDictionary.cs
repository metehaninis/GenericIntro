using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyDictionary<K, V>
    {
        K[] _keys;
        V[] _values;

        public MyDictionary()
        {
            _keys = new K[0];
            _values = new V[0];
        }
        public void Add(K key, V value)
        {
            K[] tempKey = _keys;
            V[] tempValues = _values;

            _keys = new K[_keys.Length + 1];
            _values = new V[_values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _keys[i] = tempKey[i];
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                _values[i] = tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

            Console.WriteLine(value + " eklendi");
        }
    }
}
