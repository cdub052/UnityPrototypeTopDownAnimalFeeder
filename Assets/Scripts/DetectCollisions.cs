using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //get method to detect collisions 
    private void OnTriggerEnter(Collider other)
    {
        //destroy game objects on collision
        Destroy(gameObject);

        Destroy(other.gameObject);
    }
}
