using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject onCollectEffect;
    private AudioSource audioSoruce;
    // Start is called before the first frame update
    void Start()
    {
       audioSoruce = GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
        
    }

    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSoruce.Play();
            //Destroy the collectible
            Destroy(gameObject,audioSoruce.clip.length);
            //Instantiate the particle effect
            Instantiate(onCollectEffect, transform.position, transform.rotation);

       
            
        }
        

    }
}
