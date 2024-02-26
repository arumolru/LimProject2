using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HellStageNextButton : MonoBehaviour
{
    public int stageLevel;

    public void OnButtonClick()
    {
        SceneManager.LoadScene("HellStage" + stageLevel + 1.ToString());
    }
}
