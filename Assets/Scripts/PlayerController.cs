using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    private void Start()
    {
        //controller = gameObject.AddComponent<CharacterController>();
        controller = GetComponent<CharacterController>();   
    }

    void Update()
    {

        if (controller.isGrounded)
        {
            print("CharacterController is grounded");
        }


        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            print("ground");
            playerVelocity.y = 0f;
        }

        //playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);



        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        //if (move != Vector3.zero)
        //{
        //    gameObject.transform.forward = move;
        //}

        //// Changes the height position of the player..
        //if (Input.GetButtonDown("Jump") && groundedPlayer)
        //{
        //    print("jump");
        //    playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        //}

        //playerVelocity.y += gravityValue * Time.deltaTime;
        //controller.Move(playerVelocity * Time.deltaTime);
    }

    
    /*
    CharacterController characterController;
    private Vector3 motion;
    public float speed;
    public float jumpSpeed;
    private Vector3 jumpVelocity;
    private bool  isGrounded;
    public float gravity;

    // Start is called before the first frame update

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //motion = Vector3.zero;

        //motion = transform.forward; //goes forward in player z direction
        isGrounded = characterController.isGrounded;
        if (isGrounded && jumpVelocity.y < 0f)
        {
            //jump logic
            print("grounded");

            jumpVelocity.y = 0; 

            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                print("Jump");
                //jumpVelocity.y = jumpSpeed;

            }
        }
        else
        {
            //jumpVelocity = jumpVelocity - gravity * Time.deltaTime;
        }


        //motion.Normalize();

        //motion = motion * speed * Time.deltaTime;
        //characterController.Move(motion);


    } */
}
