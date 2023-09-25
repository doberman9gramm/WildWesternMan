using UnityEngine;

public class Iteraction : MonoBehaviour
{
    [SerializeField] private float _radius;

    [SerializeField] private Trigger _trigger;

    private void Awake()
    {
        if (TryGetComponent(out _trigger) == false)
            _trigger = gameObject.AddComponent<Trigger>();//сделать посадку налошадь через взаимодествие от этого класса
    }
}