using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject DoorCam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            MainCamera.SetActive(false);
            DoorCam.SetActive(true);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        MainCamera.SetActive(true);
        DoorCam.SetActive(false);
    }

}
