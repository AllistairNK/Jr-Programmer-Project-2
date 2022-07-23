using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] private float horsePower = 50.0f;
    private float turnSpeed = 120.0f;
    private float horizontalInput;
    private float forwardInput;
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
        transform.Translate(Vector3.forward * Time.deltaTime * horsePower * forwardInput);
        //Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnim.Play("Base Layer.Bark",0,0);
        }
    }
    public void PlayBark()
    {
        playerAnim.Play("Base Layer.Bark", 0, 0);
    }
    public void PlayEat()
    {
        playerAnim.Play("Base Layer.Eat", 0, 0);
    }

    public void PlaySit()
    {
        playerAnim.Play("Base Layer.SideDown", 0, 0);
    }
}
