using UnityEngine;
using TMPro;
using System.Collections.Generic;

namespace InteractableSpace
{
    //doc https://www.youtube.com/watch?v=LdoImzaY6M4&t=1287s
    public class AgentInteraction : MonoBehaviour
    {
        [SerializeField] private float _interactRange = 2f;
        [SerializeField] private LayerMask _layer;
        [SerializeField] private AgentInteractionGUI _agentInteractionGUI;


        private List<Interactable> _interactables = new List<Interactable>();

        private void Update()
        {
            string text = GetInteractableObject()?.GetText;
            _agentInteractionGUI.ShowIntecrationGUi(text, text == null ? AgentInteractionGUI.Visibility.hide : AgentInteractionGUI.Visibility.show);
        }

        public List<Interactable> GetInteractableObject()
        {
            _interactables.Clear();
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, _interactRange, _layer);
            foreach (Collider collider in colliderArray)
                if (collider.TryGetComponent(out Interactable interactable))
                    _interactables.Add(interactable);
            return _interactables;
        }
    }
}