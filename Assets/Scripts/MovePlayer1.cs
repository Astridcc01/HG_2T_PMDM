using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer1 : MonoBehaviour
{
    public float speed = 5.0f;
    public float gravity = -9.8f;
    private CharacterController controller;

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 mov = new Vector3(deltaX, 0, deltaZ);
        mov = Vector3.ClampMagnitude(mov, speed);
        mov.y = gravity;
        mov *= Time.deltaTime;
        mov = transform.TransformDirection(mov);
        controller.Move(mov);

        transform.Translate(deltaX * Time.deltaTime, 0, deltaZ * Time.deltaTime);
    }

       void Start()
   {
       controller =  GetComponent<CharacterController>();
   }
}
