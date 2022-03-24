using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    [SerializeField] private GameObject light;
    

    // Update is called once per frame
    void Update()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(light.transform.position, light.transform.TransformDirection(Vector3.left), out hit, 10000));
        {
            Debug.Log("Bir şeye çarptı");
            Debug.DrawRay(light.transform.position, light.transform.TransformDirection(Vector3.left) * 10000);
            if (hit.collider.tag.Equals("Player"))
            {
                Debug.Log("çarptııı");
                
            }
 
        }

    }
}
