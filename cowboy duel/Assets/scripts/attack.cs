using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
   
    
    [SerializeField] private GameObject ammo;
    public Transform fireTransform;
      
    
    

    


    void Update()
    {
       
        Playerýnput();

    }

    private void Playerýnput()
    {
        
            if (Input.GetMouseButtonDown(0))
            {
                
                
                    fire();
                

            }

        
    }

    public void fire()
    {
        float diffrance = 180f - transform.eulerAngles.y;
        float targetRotation = -90f;

        if (diffrance >= 90f)
        {
            targetRotation = -90f;
        }

        else if (diffrance < 90)
        {
            targetRotation = 90f;
        }
        
        
        
        GameObject bulletClone = Instantiate(ammo, fireTransform.position, Quaternion.Euler(0f, 0f, targetRotation));
       
    }
}
