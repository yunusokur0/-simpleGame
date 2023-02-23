using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody rigidbody;
    [SerializeField] private float speed;
    [SerializeField] private float TurnSpeed;
   

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        TakeInput();
    }

    private void TakeInput()
    {
        

        if (Input.GetKeyDown(KeyCode.D) && CompareTag("Player"))
        {
            rigidbody.velocity = new Vector3(Mathf.Clamp(speed * 100 * Time.deltaTime, 0f, 15f), rigidbody.velocity.y, 0f);
           

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, -89.9f, 0f), TurnSpeed * Time.deltaTime);
        }

        else if (Input.GetKeyDown(KeyCode.A) && CompareTag("Player"))
        {
            rigidbody.velocity = new Vector3(Mathf.Clamp(-speed * 100 * Time.deltaTime, -15f, 0f), rigidbody.velocity.y, 0f);
            //transform.rotation = Quaternion.Euler(0f, -90f, 0f);

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 89.9f, 0f), TurnSpeed * Time.deltaTime);
        }
       else if (Input.GetKeyDown(KeyCode.A) && CompareTag("Player2"))
        {
            rigidbody.velocity = new Vector3(Mathf.Clamp(speed * 100 * Time.deltaTime, 0f, 15f), rigidbody.velocity.y, 0f);


            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 89.9f, 0f), TurnSpeed * Time.deltaTime);
        }

        else if (Input.GetKeyDown(KeyCode.D) && CompareTag("Player2"))
        {
            rigidbody.velocity = new Vector3(Mathf.Clamp(-speed * 100 * Time.deltaTime, -15f, 0f), rigidbody.velocity.y, 0f);
            //transform.rotation = Quaternion.Euler(0f, -90f, 0f);

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, -89.9f, 0f), TurnSpeed * Time.deltaTime);
        }


        else
        {
            rigidbody.velocity = new Vector3(0f, rigidbody.velocity.y, 0f);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("collider"))
        {
            Destroy(other.gameObject);
        }
        
    }

    

}
