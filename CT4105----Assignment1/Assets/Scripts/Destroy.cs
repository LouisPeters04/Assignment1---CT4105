using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject ClosedDoor;
    public GameObject OpenDoor;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(ClosedDoor);

            OpenDoor.SetActive(true);

            
        }

    }

   
}
