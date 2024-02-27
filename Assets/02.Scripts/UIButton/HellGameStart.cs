using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HellGameStart : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("HellStage1");
    }
}
