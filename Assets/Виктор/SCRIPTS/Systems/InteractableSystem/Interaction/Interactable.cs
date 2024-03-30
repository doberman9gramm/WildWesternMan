using UnityEngine;

namespace InteractableSpace
{
    [RequireComponent(typeof(SphereCollider))]//��� ����������� Interactable ����� physics
    public class Interactable : MonoBehaviour, IInteractable
    {
        [SerializeField] private string _text = "interact text";
        public void Interact()
        {
            Debug.Log("Interact");
        }

        public string GetText => _text;
    }
}