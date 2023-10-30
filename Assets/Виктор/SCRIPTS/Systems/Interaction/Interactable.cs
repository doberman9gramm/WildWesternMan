using UnityEngine;

namespace InteractableSpace
{
    public class Interactable : MonoBehaviour, IInteractable
    {
        [SerializeField] private string _text = "interact text";
        public void Interact()
        {

        }

        public string GetText => _text;
    }
}