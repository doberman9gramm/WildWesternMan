using System;
using UnityEngine;

namespace HealthSpace
{
    public class Health : MonoBehaviour
    {
        public Action<uint> healthAdded;
        public Action<uint> healthReduced;
        public Action Dead;

        [SerializeField, Min(0)] private uint _value;

        private void Start() { } 

        public void Add(uint value)
        {
            if (_value + value <= _value)
                return;

            _value += value;
            healthAdded?.Invoke(_value);
        }

        public void Reduce(uint value)
        {
            if (_value <= value)
            {
                Die();
            }

            _value -= value;
            healthReduced?.Invoke(_value);
        }

        private void Die()
        {
            _value = 0;
            Dead?.Invoke();
        }
    }
}