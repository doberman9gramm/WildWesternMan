using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundMove : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] private float radius = 0.5f;

    private Vector3 cachedCenter; 
    private float angle = 0;


    private void Start()
    {
        cachedCenter = transform.position;
    }

    private void Update()
    {
        angle += Time.deltaTime;
        var x = Mathf.Cos(angle * speed) * radius;
        var y = Mathf.Sin(angle * speed) * radius;
        transform.position = new Vector3(y, 0, x) + cachedCenter;
        transform.LookAt(transform.position + new Vector3(y, 0, x));
    }
}
