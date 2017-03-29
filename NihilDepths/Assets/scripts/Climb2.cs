using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb2 : MonoBehaviour 
{

	 public float climbSpeed2 = 5f;
     bool climbing2 = false;
 
     void OnTriggerStay(Collider hit)
	 {
         print ("staying");
         if (hit.gameObject.tag == "Wall") 
		 {
			 this.GetComponent<Rigidbody>().useGravity = false;
             //this.GetComponent<Rigidbody>().isKinematic = false;
             climbing2 = true;  
             print ("climbing");      
         }
     }
 
     void OnTriggerExit(Collider hit)
	 {
         if (hit.gameObject.tag == "Wall") 
		 {
			this.GetComponent<Rigidbody>().useGravity = true;
            climbing2 = false;
         }
     }
 
     void Update()
     {
             if (climbing2)
			 {    
                 print ("made it to here");                           
                 if (Input.GetKey(KeyCode.W))
                 {
                     print ("moving up");
                     gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+climbSpeed2,gameObject.transform.position.z);   
                 }
             }
     }
}
