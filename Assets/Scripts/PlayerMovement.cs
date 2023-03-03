using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 myVelocity = Vector3.zero;
    public float mySpeed = 6f;

    public GameObject MainCamera;

    private Rigidbody myRigidbody;

    public float myRayLength = 100f;

    private int myMaskingLayer;

    //Start is called before the first frame update 
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        myMaskingLayer = LayerMask.GetMask("Floor");
    }

    //Update is called once per frame 
    void Update()
    {

    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Move(horizontal, vertical);

        Turn();
    }

    private void Move(float horizontal, float vertical)
    {
        //Direction from input
        myVelocity.Set(horizontal, 0, vertical);
        //Velocity = normalised direction * speed
        myVelocity = myVelocity.normalized * mySpeed * Time.deltaTime;
        //Add the velocity e.g. the distance moved this 
        myRigidbody.MovePosition(myRigidbody.position + myVelocity);
    }

    private void Turn()
    {
        RaycastHit floorHit;
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out floorHit, myRayLength, myMaskingLayer))
        {
            Vector3 playerToMouse = floorHit.point - myRigidbody.position;

            playerToMouse.y = 0;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);

            myRigidbody.MoveRotation(newRotation);
        }
    }
}