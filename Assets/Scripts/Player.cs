using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour 
{
    public GameObject player;
    public float speedX, speedY, speedZ;
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            player.transform.position += new Vector3(0f, 0f, speedZ * Time.deltaTime);
        }
    }

}