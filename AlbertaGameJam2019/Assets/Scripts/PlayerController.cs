using System.Collections;
using System.Collections.Generic;
using Missive_CSharp;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour, IMissiveListener<SwordInputEvent>
{
    CharacterController characterController;
    public float speed = 6.0f;
    public static PlayerController instance;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Move Character
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed;
        characterController.Move(moveDirection * Time.deltaTime);

        //Rotate Character
        Vector3 PlayerDirection = Vector3.right  * Input.GetAxis("RHorizontal") + Vector3.forward * -Input.GetAxis("RVertical");
        if(PlayerDirection.sqrMagnitude > 0.0f)
        {
            transform.LookAt(transform.position + PlayerDirection);
        }
    }

    public void HandleMissive(SwordInputEvent missive)
    {
        gameObject.GetComponentSafely<SwordSkill>().Use(gameObject);
    }
}
