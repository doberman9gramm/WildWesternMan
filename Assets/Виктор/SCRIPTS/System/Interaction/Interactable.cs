using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InteractableSpace
{
    public class Interactable : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interact");
        }

    }
}