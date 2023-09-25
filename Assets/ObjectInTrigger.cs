using System;
using UnityEngine;

[RequireComponent(typeof(Trigger))]
public class ObjectInTrigger : MonoBehaviour
{
    //���������� MonoBehaviour �� type
    public Action<Collider> ObjectEnter;
    public Action<Collider> ObjectExit;

    private Trigger _trigger;

    [SerializeField] private MonoBehaviour type;
    private bool _isInitEND = false;

    private void Awake()
    {
        _trigger = GetComponent<Trigger>();
    }

    private void OnEnable()
    {
        _trigger.ColliderAdded += OnColliderEnter;
        _trigger.ColliderRemoved += OnColliderExit;
    }

    private void OnDisable()
    {
        _trigger.ColliderAdded -= OnColliderEnter;
        _trigger.ColliderRemoved -= OnColliderExit;
    }

    public void Initialization(MonoBehaviour T)
    {
        if (_isInitEND)
            return;

        type = T;
        _isInitEND = true;
    }

    private void OnColliderEnter(Collider collider)
    {
        if (type == TryGetComponent(collider))
            ObjectEnter?.Invoke(collider);
    }

    private void OnColliderExit(Collider collider)
    {
        if (type == TryGetComponent(collider))
            ObjectExit?.Invoke(collider);
    }

    private MonoBehaviour TryGetComponent(Collider collider)
    {
        if (collider.TryGetComponent(out MonoBehaviour T))//������� ������ ������ �� ���� �� �������, ��� ����� ���������? ��� ���� ������ �� ������?
        {
            Debug.Log(T);
            return T;
        }

        return null;
    }
}