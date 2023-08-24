using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if statement to destroy topbound object
        if (gameObject.transform.position.z > topBound)
        {
            //destroy food that is out of view
            Destroy(gameObject);
        }
        //else if statement to get lowerbound
        else if (gameObject.transform.position.z < lowerBound)
        {
            //use debug log to show game is over is animal passes player
            Debug.Log("Game over");

            //destroy animal that passes player
            Destroy(gameObject);
        }
    }
}
