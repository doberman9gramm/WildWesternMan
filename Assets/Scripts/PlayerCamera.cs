using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerCamera : MonoBehaviour
    {
        [SerializeField] private CameraController _camera;
        [SerializeField] private InputActionReference _input;

        private void Update()
        {
            float axis = _input.action.ReadValue<float>();
            _camera.ChangeCameraDistance(axis);
        }
    }
}