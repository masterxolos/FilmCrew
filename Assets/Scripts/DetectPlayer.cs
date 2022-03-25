using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    [SerializeField] private GameObject raycastPoint;
    

    // Update is called once per frame
    void Update()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(raycastPoint.transform.position, raycastPoint.transform.TransformDirection(Vector3.down), out hit, 10000));
        {
            Debug.Log("Bir şeye çarptı");
            Debug.DrawRay(raycastPoint.transform.position, raycastPoint.transform.TransformDirection(Vector3.down) * 10000);
            if (hit.collider.tag.Equals("Player"))
            {
                Debug.Log("çarptııı");
                
            }
 
        }

    }
}
