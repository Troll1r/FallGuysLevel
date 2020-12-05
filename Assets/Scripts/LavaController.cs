using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaController : MonoBehaviour
{
    public GameObject player;
    public GameObject lava;
    public float value = 100;
    public float speed = 5;

    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Destroy(player);
        }
    }

}
