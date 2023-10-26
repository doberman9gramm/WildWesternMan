using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float _seconsToDelite;
    [SerializeField]
    private float _velocity;

    private void OnEnable()
    {
        Destroy(gameObject, _seconsToDelite);
    }

    private void Update()
    {
        transform.position += Vector3.left * _velocity * Time.deltaTime;
    }
}
