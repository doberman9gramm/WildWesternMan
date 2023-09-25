using System;
using System.Collections.Generic;
using UnityEngine;

namespace TriggerSpace
{
    [RequireComponent(typeof(SphereCollider))]//ÒÚÓËÚ Â˘Â ‰Ó·‡‚ÎˇÚ¸ SphereColliderCONFIG Ë RigidBody Ë RigidbodyCONFIG
    public class Trigger : MonoBehaviour
    {
        public Action<Collider> ColliderAdded;
        public Action<Collider> ColliderRemoved;

        private List<Collider> _collidersInTrigger = new List<Collider>();

        private void OnTriggerEnter(Collider other) => AddCollider(other);

        private void OnTriggerExit(Collider other) => RemoveCollider(other);

        private void AddCollider(Collider other)
        {
            ColliderAdded?.Invoke(other);
            _collidersInTrigger.Add(other);
        }

        private bool RemoveCollider(Collider other)
        {
            ColliderRemoved?.Invoke(other);
            return _collidersInTrigger.Remove(other);
        }

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
}