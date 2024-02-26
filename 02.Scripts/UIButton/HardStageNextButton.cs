using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardStageNextButton : MonoBehaviour
{
    public int stageLevel;

    public void OnButtonClick()
    {
        SceneManager.LoadScene("HardStage" + stageLevel + 1.ToString());
    }
}
