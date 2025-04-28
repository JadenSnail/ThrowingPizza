using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float movementSpeed = 20.0f;
    public float range = 24.0f;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //check if player withen bounds
        if(transform.position.x < -range ){
        transform.position = new Vector3(range,transform.position.y,transform.position.z);
        }
        if(transform.position.x > range ){
        transform.position = new Vector3(-range,transform.position.y,transform.position.z);
        }

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime *  movementSpeed);

    }
}
