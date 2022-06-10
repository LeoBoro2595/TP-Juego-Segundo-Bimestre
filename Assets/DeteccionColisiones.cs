using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionColisiones : MonoBehaviour
{

    AudioSource source;
    bool isPlaying;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision herido)
    {
        if (gameObject.tag == "Balas")
        {
            Destroy(herido.gameObject);
        }
        Destroy(gameObject);
        source.Play();
    }
}