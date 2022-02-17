using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    private Vector3 motion;
    public float speed = 10f;

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
        motion = Vector3.zero;

        motion = transform.forward; //goes forward in player z direction

        motion.Normalize();

        motion = motion * speed * Time.deltaTime;
        characterController.Move(motion);
    }
}
