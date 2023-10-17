using System;
using UnityEngine;

namespace HealthSpace
{
    public class Health : MonoBehaviour
    {
        public Action<int> healthAdded;
        public Action<int> healthReduced;
        public Action Dead;

        [SerializeField, Min(0)] private int _currentValue;
        [SerializeField, Min(0)] private int _maxValue;

        private int _minValue;
        
        public void Increase(int value)
        {
            ChangeValue(value);
            healthAdded?.Invoke(value);
        }

        public void Decrease(int value)
        {
            ChangeValue(-value); 
            healthReduced?.Invoke(value);
        }

        private void ChangeValue(int value)
        {
            _currentValue += value;
            _currentValue = Math.Clamp(_currentValue, _minValue, _maxValue);

            if (_currentValue == _minValue)
                Dead?.Invoke();
        }
    }
}