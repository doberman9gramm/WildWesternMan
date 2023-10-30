using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class Revolver : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem fire;
    [SerializeField]
    private GameObject _bulletPrefab;
    [SerializeField]
    private Vector3 _correction;
    [SerializeField]
    private AudioClip _firePistol;

    private AudioSource _audio;


    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _audio.clip = _firePistol;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            fire.Play(true);
            Instantiate(_bulletPrefab, transform.position + _correction, Quaternion.identity);
            _audio.Play();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + _correction, 0.1f);
    }
}
