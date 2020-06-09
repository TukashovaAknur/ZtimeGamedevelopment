using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwithing : MonoBehaviour
{
    public Transform gun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("k"))
        {
            Debug.Log("Knife is selected");

            gun.gameObject.SetActive(false);
        }
        if (Input.GetKey("g"))
        {
            Debug.Log("Gun is selected");

            gun.gameObject.SetActive(true);
        }
    }
}
