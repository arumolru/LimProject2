using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUI : MonoBehaviour
{
    public GameObject gameOverUI;

    private void Awake()
    {
        gameOverUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("MONSTER"))
        {
            gameOverUI.SetActive(true);
        }
    }
}
