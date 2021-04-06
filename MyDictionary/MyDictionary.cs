using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<K, V>
    {
        K[] _key;
        V[] _value;

        K[] _tempKey;
        V[] _tempValue;
        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }
        public void Add(K key, V value)
        {
            _tempKey = _key;
            _tempValue = _value;
            _key = new K[_key.Length + 1];
            _value = new V[_value.Length + 1];


            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }

            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }


            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }
    }
}
