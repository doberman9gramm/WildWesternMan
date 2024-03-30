using UnityEngine;
using UnityEngine.InputSystem;

public class OpenCloseInput : MonoBehaviour
{
    [SerializeField] private InputActionReference _input;
    [SerializeField] private GameObject _gameObject;

    private void OnEnable()
    {
        
    }

    private void Update()
    {
        _gameObject.SetActive(!_gameObject.activeSelf);
    }
}