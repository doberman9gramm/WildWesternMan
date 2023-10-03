using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;//Сделать логику через Vector3

    private void FixedUpdate()
    {
        transform.Rotate(0f, 0f, _speed / 100, Space.Self);
    }
}