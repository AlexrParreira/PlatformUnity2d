using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public GameObject platform;
    public Transform generation;
    public float distance;

    private float platformWidth;
    private float platformHeight;
    
    void Start()
    {
        platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
        platformHeight = platform.transform.position.y;
    }


    void Update()
    {
        if(transform.position.x < generation.position.x){
            transform.position = new Vector3(transform.position.x + platformWidth + distance, platformHeight + Random.Range(-3.0f, 3.0f), transform.position.z);


            Instantiate(platform, transform.position, transform.rotation);
        }
    }
}
