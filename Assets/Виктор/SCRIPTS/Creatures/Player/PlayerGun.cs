using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private InputActionReference _shoot;
    [SerializeField] private Gun _currentGun;

    private void Update()
    {
        if (_shoot.action.ReadValue<float>() != 0)
        {
            //_currentGun.Shoot();
        }
    }
}