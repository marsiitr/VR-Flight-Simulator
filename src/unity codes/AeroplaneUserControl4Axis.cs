using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;
using System.Collections.Generic;
namespace UnityStandardAssets.Vehicles.Aeroplane
{


    
    [RequireComponent(typeof (AeroplaneController))]
    public class AeroplaneUserControl4Axis : MonoBehaviour
    {
        // Start is called before the first frame update
        public Rigidbody rocket;
        public float speed = 2000f;
        
        public float y;
        public float z;
        public float y2;
        InputController inputController;
        // these max angles are only used on mobile, due to the way pitch and roll input are handled
        public float maxRollAngle = 80;
        public float maxPitchAngle = 80;

        // reference to the aeroplane that we're controlling
        
        private AeroplaneController m_Aeroplane;
        private float m_Throttle;
        private bool m_AirBrakes;
        private float m_Yaw;
        int rcount = 0;

        void FireRocket()
        {
            rcount++;
            //
            string[] lines = { "0" };
            //System.IO.File.WriteAllLines(@"D:\unity\vr flight simulator\vr flight simulator\rocket" + rcount + ".txt", lines);
            //string id = rcount.ToString();
           // string[] rid = { id };
         //   System.IO.File.WriteAllLines(@"D:\unity\vr flight simulator\vr flight simulator\rocketid.txt", rid);
            Vector3 temp = new Vector3(0, 10, 0);
            Rigidbody rocketClone = (Rigidbody)Instantiate(rocket, transform.position + temp, transform.rotation);
            rocketClone.velocity = transform.forward * speed;

            // You can also access other components / scripts of the clone
            //rocketClone.GetComponent<MyRocketScript>().DoSomething();
        }
        private void Awake()
        {
            // Set up the reference to the aeroplane controller.
            m_Aeroplane = GetComponent<AeroplaneController>();
            inputController = new InputController();
            inputController.Begin("192.168.43.49", 80);
        }


        private void FixedUpdate()
        {
            if (/*Input.GetButton("fire"))*/inputController.bump == 1)
            {

                FireRocket();
            }

           


           if((inputController.ultrasonic) >= 16&& (inputController.ultrasonic) <= 20)
            {
                y = 0;
            }

              else  if ((inputController.ultrasonic)<16)
            {
                y = 1;// (inputController.ultrasonic-18)/5;
            }
           else if ((inputController.ultrasonic) > 20)
            {
                y = -1;// (-inputController.ultrasonic+22)/7;
            }
            // Debug.Log(y);

            if (inputController.gyro > -.1 && inputController.gyro < .1)
            {
                y2 = 0;
            }
            else if (inputController.gyro < -.1)
            {
                y2 = -1;
            }
            else if (inputController.gyro > .1)
            {
                y2 = 1;
            }
            
            Debug.Log(inputController.ultrasonic);
            if (inputController.pot > 2.9)
            {
                z = 0;
            }
            else if (inputController.pot < 1.9)
            {
                z = 1;
            }
          
            else if(inputController.pot<=3.1&& inputController.pot >= 1.7)
            {
                z = (float)(-(inputController.pot - 3.1)*10)/14;
            }

            // Read input for the pitch, yaw, roll and throttle of the aeroplane.
            float roll = /*y2;*//* inputController.gyro;*/ CrossPlatformInputManager.GetAxis("Fire2");

            float pitch =  /*y;*/CrossPlatformInputManager.GetAxis("Fire1");
            
            m_AirBrakes = CrossPlatformInputManager.GetButton("space");
            m_Yaw = /*y2 / 4;*//*(inputController.gyro)/4;*/ CrossPlatformInputManager.GetAxis("Horizontal");

            m_Throttle =  /*z;*/    /*script12.x;*/ CrossPlatformInputManager.GetAxis("Vertical");
#if MOBILE_INPUT
        AdjustInputForMobileControls(ref roll, ref pitch, ref m_Throttle);
#endif
            // Pass the input to the aeroplane
            m_Aeroplane.Move(roll, pitch, m_Yaw, m_Throttle, m_AirBrakes);
        }


        private void AdjustInputForMobileControls(ref float roll, ref float pitch, ref float throttle)
        {
            // because mobile tilt is used for roll and pitch, we help out by
            // assuming that a centered level device means the user
            // wants to fly straight and level!

            // this means on mobile, the input represents the *desired* roll angle of the aeroplane,
            // and the roll input is calculated to achieve that.
            // whereas on non-mobile, the input directly controls the roll of the aeroplane.

            float intendedRollAngle = roll*maxRollAngle*Mathf.Deg2Rad;
            float intendedPitchAngle = pitch*maxPitchAngle*Mathf.Deg2Rad;
            roll = Mathf.Clamp((intendedRollAngle - m_Aeroplane.RollAngle), -1, 1);
            pitch = Mathf.Clamp((intendedPitchAngle - m_Aeroplane.PitchAngle), -1, 1);
        }
    }
}
