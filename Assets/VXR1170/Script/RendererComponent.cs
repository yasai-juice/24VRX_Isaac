using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendererComponent : MonoBehaviour
{
    // Renderer is responsible for how the object is drawn in the game, controlling properties liek materials textures, and visibility
    // Use it to manipulate how the object looks, interacts with light, and appears on the screen

    private Renderer objectRender;
    // Start is called before the first frame update
    void Start()
    {
        objectRender = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            objectRender.material.color = Color.green;
            //objectRenderer.enable = false;
        }
    }
}
