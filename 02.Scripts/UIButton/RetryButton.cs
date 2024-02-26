using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public int stageLevel;

    public void RetryScene()
    {
        SceneManager.LoadScene("NormalStage" + stageLevel.ToString());
    }
}
