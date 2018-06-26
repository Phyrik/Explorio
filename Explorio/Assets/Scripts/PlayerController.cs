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
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Input.GetAxis("Vertical") * Time.deltaTime);
    }
}