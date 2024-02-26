using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HellRetryButton : MonoBehaviour
{
    public int stageLevel;

    public void RetryScene()
    {
        SceneManager.LoadScene("HellStage" + stageLevel.ToString());
    }
}
