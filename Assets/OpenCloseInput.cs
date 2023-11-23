using UnityEngine;
using UnityEngine.InputSystem;

public class OpenCloseInput : MonoBehaviour
{
    [SerializeField] private InputActionReference _input;
    [SerializeField] private GameObject _gameObject;

    private void Update()
    {
        if (_input.action.ReadValue<float>() != 0)
        {
            Debug.Log("True");
            _gameObject.SetActive(!_gameObject.activeSelf);
        }
    }
}