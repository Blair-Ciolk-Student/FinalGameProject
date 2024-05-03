using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSmoothTime, GravityStrength, JumpStrength, WalkSpeed, RunSpeed;


    private CharacterController Controller;
    private Vector3 CurrentMoveVelocity, MoveDampVelcity, CurrentForceVelocity;


    void Start()
    {
     Controller = GetComponent<CharacterController>();   
    }

    void Update()
    {
        Vector3 PlayerInput = new Vector3
        {
            x = Input.GetAxisRaw("Horizontal"),
            y = 0f,
            z = Input.GetAxisRaw("Vertical")
        };

        if(PlayerInput.magnitude > 1)
        {
            PlayerInput.Normalize();
        }

        Vector3 MoveVector = transform.TransformDirection(PlayerInput);
        float CurrentSpeed = Input.GetKey(KeyCode.LeftShift) ? RunSpeed : JumpStrength;

        CurrentMoveVelocity = Vector3.SmoothDamp(
            CurrentMoveVelocity,
            MoveVector * CurrentSpeed,
            ref MoveDampVelcity,
            MoveSmoothTime
            );

        Controller.Move(CurrentMoveVelocity * Time.deltaTime);

        Ray groundCheckRay = new Ray(transform.position, Vector3.down);
        if(Physics.Raycast(groundCheckRay, 1.25f))
        {
            CurrentForceVelocity.y = -2f;

            if(Input.GetKey(KeyCode.Space))
            {
                CurrentForceVelocity.y = JumpStrength;
            }
            else
            {
                CurrentForceVelocity.y -= GravityStrength * Time.deltaTime;
            }
        }

        Controller.Move(CurrentForceVelocity * Time.deltaTime);

    }
}
