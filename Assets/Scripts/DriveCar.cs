using UnityEngine;

public class DriverCar : MonoBehaviour
{
    public Rigidbody2D frontWheel;
    public Rigidbody2D backWheel;
    public float motorTorque = 150f;
    public float tiltTorque = 15f;

    private bool accelerate;
    private bool brake;
    private float tiltInput;

    void Update()
    {
        
        accelerate = Input.GetKey(KeyCode.W);
        brake = Input.GetKey(KeyCode.S);

        if (Input.GetKey(KeyCode.D)) tiltInput = 1f;
        else if (Input.GetKey(KeyCode.A)) tiltInput = -1f;
        else tiltInput = 0f;
    }

    void FixedUpdate()
    {
        
        if (accelerate)
        {
            frontWheel.AddTorque(-motorTorque * Time.fixedDeltaTime);
            backWheel.AddTorque(-motorTorque * Time.fixedDeltaTime);
        }
        else if (brake)
        {
            frontWheel.AddTorque(motorTorque * Time.fixedDeltaTime);
            backWheel.AddTorque(motorTorque * Time.fixedDeltaTime);
        }

       
        GetComponent<Rigidbody2D>().AddTorque(-tiltInput * tiltTorque * Time.fixedDeltaTime);
    }
}
