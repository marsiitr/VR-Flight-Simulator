using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityStandardAssets.Vehicles.Aeroplane
{   
    public class shooting : MonoBehaviour
    {
      
        // Start is called before the first frame update
        public Rigidbody rocket;
        public float speed = 2000f;
       
        void FireRocket()
        {
            Vector3 temp = new Vector3(0, 10, 0);
            Rigidbody rocketClone = (Rigidbody)Instantiate(rocket, transform.position + temp, transform.rotation);
            rocketClone.velocity = transform.forward * speed;

            // You can also access other components / scripts of the clone
            //rocketClone.GetComponent<MyRocketScript>().DoSomething();
        }

        // Calls the fire method when holding down ctrl or mouse
        void Update()
        {
           
            if (Input.GetButton("Fire"))
            {

                FireRocket();
            }
        }

    }
}