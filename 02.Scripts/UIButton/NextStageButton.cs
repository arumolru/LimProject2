using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStageButton : MonoBehaviour
{
    public int stageLevel;
    
    public void OnButtonClick()
    {
        SceneManager.LoadScene("NormalStage" + stageLevel + 1.ToString());
    }
}
