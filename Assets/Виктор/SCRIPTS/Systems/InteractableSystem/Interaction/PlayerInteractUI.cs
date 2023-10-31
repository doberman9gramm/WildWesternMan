using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractUI : MonoBehaviour
{
    [SerializeField] private GameObject _container;

    private void Show()
    {
        _container.SetActive(true);
    }

    private void Hide()
    {
        _container.SetActive(false);
    }
}