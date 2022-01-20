using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForceSide = 500f;
    public float ForceForward = 2000f;
    int tiltyes;
    private void Start()
    {
        tiltyes = PlayerPrefs.GetInt("tilt");
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        rb.AddForce(0, 0, ForceForward * Time.deltaTime);
        if (tiltyes==0)
        {
            if (Input.touchCount > 0)
            {
                Touch info = Input.GetTouch(0);
                if (info.position.x < Screen.width / 2)
                {
                    rb.AddForce(-ForceSide * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                if (info.position.x > Screen.width / 2)
                {
                    rb.AddForce(ForceSide * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
            }
        }

        else if (tiltyes== 1 )
        {
            Vector3 acc = Input.acceleration;
            rb.AddForce(acc.x * ForceSide*Time.deltaTime*5, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-ForceSide * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(ForceSide * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
