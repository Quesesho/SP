using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuxMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Camera mainCamera;
    private bool canChange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }
    void MovementPlayer()
    {
        transform.Translate(Input.GetAxis("Horizontal")*Vector2.right*Time.deltaTime*speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(mainCamera.transform.position.y < 0)
                mainCamera.transform.position += Vector3.up * 10.25f;
            else
                mainCamera.transform.position -= Vector3.up * 10.25f;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Tuneles"))
        {
            canChange = true;
            
            Debug.Log("Tadentro");
               
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Tuneles"))
            canChange = false;
    }
}
