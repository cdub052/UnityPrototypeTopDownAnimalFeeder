using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float xRange = 15f;
    public float zRange = 3f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //stop movement after certain point on map
        if (transform.position.x < -xRange)
        {
            //keep player from going to far on  x axis to the left while keeping y and z the same 
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        else if (transform.position.x > xRange)
        {
            //keep player from going to far on  x axis to the right while keeping y and z the same 
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //stop movement after certain point on map
        else if(transform.position.z < -zRange)
        {
            //keep player from going to far on  z axis
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);

        }
        else if (transform.position.z > zRange)
        {
            //keep player from going to far on  x axis to the right while keeping y and z the same 
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        //get horizontal movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //get vertical movement
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        //if statement to get playerinput from space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch projectile
            Instantiate(projectilePrefab, transform.transform.position, projectilePrefab.transform.rotation);
        }
    }
}
