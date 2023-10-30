using InteractableSpace;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float _radiusOvelapSphere;

    private void Update()
    {
        foreach (Collider collider in Physics.OverlapSphere(transform.position, _radiusOvelapSphere))
            if (collider.TryGetComponent(out Interactable interactable))
                interactable.Interact();
    }
}
