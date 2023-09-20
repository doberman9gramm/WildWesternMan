using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;//Сделать логику через Vector3

    private void FixedUpdate()
    {
        transform.Rotate(0f, _speed + Time.deltaTime, 0.0f, Space.Self);
    }
}