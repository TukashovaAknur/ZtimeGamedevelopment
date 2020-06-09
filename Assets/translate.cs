using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate : MonoBehaviour
{
    public float speedX, speedY, speedZ;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartCoroutine(waiter());   
        }
    }

    void moveKnife(Vector3 direction)
    {
        this.transform.Translate(direction * Time.deltaTime);
    }

    IEnumerator waiter()
    {
        moveKnife(new Vector3(speedX, speedY, speedZ));
        Debug.Log("Moved");
        yield return new WaitForSecondsRealtime(0.1f);
        moveKnife(new Vector3(-speedX, -speedY, -speedZ));
        Debug.Log("Moved back");
    }
}
