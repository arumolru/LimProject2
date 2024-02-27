using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardGameStart : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("HardStage1");
    }
}
