using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class that is responsible for the Camera Perspective
public class ThirdPersonView : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Sets the Camera to the wanted Position by changing the offset
        // Camera follows the Player
        transform.position = player.position + offset;
    }
}
