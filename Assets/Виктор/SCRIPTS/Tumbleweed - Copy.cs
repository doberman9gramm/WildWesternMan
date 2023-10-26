using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Tumbleweed : MonoBehaviour
{
    [SerializeField] private float _velocity;
    [SerializeField] private float _maxVelocity;
    [SerializeField] private float _seconds;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        FunctionTimer.Create(() => RandomAddForce(), _seconds);
    }

    private void RandomAddForce()
    {
        if (_velocity > _rigidbody.velocity.x)
        {
            _rigidbody.AddForce(Vector3.right * _velocity);
        }
        FunctionTimer.Create(() => RandomAddForce(), _seconds);

        Debug.Log("Force");
    }

    private Vector3 GetRandomVector()
    {
        return new Vector3(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
    }
}
