using UnityEngine;
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
            Interactable interactable = GetNearestInteractableObject();
            ShowGUI(interactable?.GetText);
        }

        private void ShowGUI(string text)
        {
            _agentInteractionGUI.ShowIntecrationGUi(text, text == null ? AgentInteractionGUI.Visibility.hide : AgentInteractionGUI.Visibility.show);
        }

        /// <summary> Получить ближайший интерактивный объект в заданном радиусе </summary>
        private Interactable GetNearestInteractableObject()
        {
            _interactables.Clear();
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, _interactRange, _layer);
            foreach (Collider collider in colliderArray)
                if (collider.TryGetComponent(out Interactable interactable))
                    _interactables.Add(interactable);

            Interactable closesInteractable = null;//ближайший обьект
            if (_interactables.Count != 0)
                foreach (Interactable interactable in _interactables)
                    if (closesInteractable == null)
                        closesInteractable = interactable;
                    else
                    {
                        //Если следующий обьект по списку ближе чем "ближайший обьект", то сделать этот объект ближайшим
                        if (Vector3.Distance(transform.position, interactable.transform.position) < 
                            Vector3.Distance(transform.position, closesInteractable.transform.position))
                            closesInteractable = interactable;
                    }
            return closesInteractable;
        }
    }
}