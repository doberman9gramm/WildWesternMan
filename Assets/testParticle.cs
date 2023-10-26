using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testParticle : MonoBehaviour
{

    [SerializeField]
    private GameObject person;
    [SerializeField]
    private ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            person.SetActive(!person.activeSelf);
            particle.Play(true);
        }
    }
}
