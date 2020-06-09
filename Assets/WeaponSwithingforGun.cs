using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwithingforGun : MonoBehaviour
{
    public Transform knife;

    void Start()
    {
        knife.gameObject.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKey("g"))
        {
            Debug.Log("Gun is selected");

            knife.gameObject.SetActive(false);
        }
        if (Input.GetKey("k"))
        {
            Debug.Log("Knife is selected");

            knife.gameObject.SetActive(true);
        }
    }
}
