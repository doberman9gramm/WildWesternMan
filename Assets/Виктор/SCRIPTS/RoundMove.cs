using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundMove : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _radius = 0.5f;
    [SerializeField] private Vector3 _rotationOffset;

    private Vector3 _cachedCenter; 
    private float _angle = 0;


    private void Start()
    {
        _cachedCenter = transform.position;
    }

    private void Update()
    {
        _angle += Time.deltaTime;
        var x = Mathf.Cos(_angle * _speed) * _radius;
        var y = Mathf.Sin(_angle * _speed) * _radius;
        transform.position = new Vector3(y, 0, x) + _cachedCenter;
        transform.LookAt(_cachedCenter + _rotationOffset * 2 * _radius);
    }
}