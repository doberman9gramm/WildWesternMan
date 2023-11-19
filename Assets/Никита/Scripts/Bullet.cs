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
        //Debug.Break();
        transform.Translate(Vector3.forward * _velocity * Time.deltaTime);
    }
}
