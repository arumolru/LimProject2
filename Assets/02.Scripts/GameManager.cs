using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool isPaused = false;

    public GameManager(bool isPaused)
    {
        this.isPaused = isPaused;
    }

    PlayerInputActions managerInputActions;

    public GameObject stageClearUI;
    public GameObject gameOverUI;
    public GameObject miniMapUI;
    public GameObject pauseUI;

    private void Awake()
    {
        managerInputActions = new PlayerInputActions();

        stageClearUI.SetActive(false);
        gameOverUI.SetActive(false);
        miniMapUI.SetActive(false);
        pauseUI.SetActive(false);
    }

    private void OnEnable()
    {
        managerInputActions.Manager.Enable();
        managerInputActions.Manager.Lobby.performed += OnManager;
        managerInputActions.Manager.Lobby.canceled += OnManager;
    }

    private void OnDisable()
    {
        managerInputActions.Manager.Lobby.canceled -= OnManager;
        managerInputActions.Manager.Lobby.performed -= OnManager;
        managerInputActions.Manager.Disable();
    }

    void OnManager(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            pauseUI.SetActive(true);
            Pause();
        }
    }

    public void OnButtonClick()
    {
        Resume();
    }

    void Pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    void Resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
        pauseUI.SetActive(false);
    }
}
