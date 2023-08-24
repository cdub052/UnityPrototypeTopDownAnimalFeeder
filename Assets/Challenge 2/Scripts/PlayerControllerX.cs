using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float time = 0f;
    // Update is called once per frame
    void Update()
    {
        if(time >0)
        {

            //subtract difference from last method called
            time -= Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && time<=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //Set time after use
            time = .5f;
            
        }

      
    }
}
