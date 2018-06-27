using UnityEngine; 
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private float moveSpeed;
    
    private void Start()
    {
        moveSpeed = 1f;
    }

    private void Update()
    {
        transform.Translate(0f, 0f, Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed);
        transform.Rotate(0f, Input.GetAxis("Horizontal") * Time.deltaTime * 50, 0f);
    }
}