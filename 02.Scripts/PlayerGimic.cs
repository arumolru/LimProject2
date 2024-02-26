using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerGimic : MonoBehaviour
{
    PlayerInputActions inputActions;

    public GameObject stageClearUI;
    public GameObject interactionUI;
    public GameObject gameOverUI;
    public GameObject monster;
    private Monster monsterScript;

    public GameObject portal;

    public Animator door;
    public AudioSource doorSound;

    public GameObject spawnPoint;

    public int count;
    public int clearCount;

    public AudioSource backGroundSound;

    private void Start()
    {
        monsterScript = monster.GetComponent<Monster>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("MONSTER"))
        {
            gameOverUI.SetActive(true);
            backGroundSound.enabled = false;
            transform.Translate(300, 300, 300);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PORTAL"))
        {
            stageClearUI.SetActive(true);
            monster.SetActive(false);
            backGroundSound.enabled = false;
        }

        if (other.gameObject.CompareTag("KEY"))
        {
            count++;

            if (monsterScript != null)
            {
                monsterScript.moveSpeed++;
            }

            if(count == clearCount)
            {
                GameObject portalSpawnZone = Instantiate(portal, spawnPoint.transform.position, Quaternion.identity);
                door.SetTrigger("OpenDoor");
                doorSound.Play();
            }
        }
    }
}
