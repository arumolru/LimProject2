using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardRetryButton : MonoBehaviour
{
    public int stageLevel;

    public void RetryScene()
    {
        SceneManager.LoadScene("HardStage" + stageLevel.ToString());
    }
}
