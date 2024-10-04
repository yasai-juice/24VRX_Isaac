using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        movecube();

        rotatecube();

        scalecube();

        if (Input.GetKeyDown(KeyCode.L))
        {
            LookAtTarget();
        }
    }
    private void movecube()
    {
        float movespeed = 5f;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * movespeed * Time.deltaTime; //move forward
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * movespeed * Time.deltaTime; //move back
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * movespeed * Time.deltaTime; //move left
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * movespeed * Time.deltaTime; //move right
        }
    }

    void rotatecube()
    {
        //rotate the cube around the y-axis (up/down) with q and e
        float rotationspeed = 50f;
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -rotationspeed * Time.deltaTime); //rotate left
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.down, rotationspeed * Time.deltaTime); //rotate right
        }
    }

    void scalecube()
    {
        Vector3 scalechange = new Vector3(1, 1, 1) * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            transform.localScale += scalechange; //increase size
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localScale -= scalechange; //decrease size
        }
    }

    void LookAtTarget()
    {
        //rotate the cube to look at the target
        if (target != null)
        {
            transform.LookAt(target); //rotate the cube to face the target
        }
        else
        {
            Debug.LogWarning("No target assigned for LookAt.");
        }
    }
}

