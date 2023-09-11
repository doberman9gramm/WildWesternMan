using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class Trigger : MonoBehaviour
{
    private List<Collider> _collidersInTrigger = new List<Collider>();
    private void OnTriggerEnter(Collider other) => _collidersInTrigger.Add(other);
    private void OnTriggerExit(Collider other) => _collidersInTrigger.Remove(other);

    public bool IsGameobjectInTrigger(GameObject _gameObject)
    {
        foreach (Collider _collider in _collidersInTrigger)
            if (_collider.gameObject == _gameObject)
                return true;
        return false;
    }

    public bool Is—olliderInTrigger(Collider collider)
    {
        foreach (Collider colliderInTrigger in _collidersInTrigger)
            if (colliderInTrigger == collider)
                return true;
        return false;
    }
}