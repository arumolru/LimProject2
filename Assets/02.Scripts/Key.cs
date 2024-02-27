using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private int rotationSpeed = 50;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PLAYER"))
        {
            gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime * new Vector3(1, 0, 1));
    }
}
