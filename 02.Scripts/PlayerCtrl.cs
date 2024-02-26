using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCtrl : MonoBehaviour
{
    PlayerInputActions inputActions;
    Vector3 vec;
    Rigidbody rb;
    Animator anim;
    private AudioSource audio1;

    public int moveSpeed;
    public int jumpForce;
    public int rotateSpeed;
    public GameObject miniMapUI;

    bool isJumped = false;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        audio1 = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
        inputActions.Player.Move.performed += OnMove;
        inputActions.Player.Move.canceled += OnMove;

        inputActions.Player.Jump.performed += OnJump;
        inputActions.Player.Jump.canceled += OnJump;

        inputActions.Player.MiniMap.performed += OnMiniMap;
        inputActions.Player.MiniMap.canceled += OnMiniMap;
    }

    private void OnDisable()
    {
        inputActions.Player.MiniMap.canceled -= OnMiniMap;
        inputActions.Player.MiniMap.performed -= OnMiniMap;

        inputActions.Player.Jump.canceled -= OnJump;
        inputActions.Player.Jump.performed -= OnJump;

        inputActions.Player.Move.canceled -= OnMove;
        inputActions.Player.Move.performed -= OnMove;
        inputActions.Player.Disable();
    }

    void OnMove(InputAction.CallbackContext context)
    {
        vec = context.ReadValue<Vector3>();

        if(context.performed)
        {
            anim.SetFloat("InputZ", vec.z);
            anim.SetFloat("InputX", vec.x);
            audio1.Play();
        }
    }

    void OnJump(InputAction.CallbackContext context)
    {
        if(context.performed && !isJumped)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumped = true;
            anim.SetBool("isJumped", true);
        }
    }

    void OnMiniMap(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            miniMapUI.SetActive(true);
        }
        if(context.canceled)
        {
            miniMapUI.SetActive(false);
        }
    }

    private void Update()
    {
        Vector3 mouseDelta = Mouse.current.delta.ReadValue();

        Vector3 rotation = new Vector3(0, mouseDelta.x, 0) * rotateSpeed * Time.deltaTime;
        transform.Rotate(rotation);
    }

    private void FixedUpdate()
    {
        transform.Translate(Time.deltaTime * moveSpeed * vec);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("GROUND"))
        {
            isJumped = false;
            anim.SetBool("isJumped", false);
        }
    }
}
