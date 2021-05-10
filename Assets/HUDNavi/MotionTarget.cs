using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HUDNavi
{
    public class MotionTarget : MonoBehaviour
    {
        public bool isDetectable = false;
        public bool isAlwaysDetected = false;
        [HideInInspector]
        public bool isMoving = false;
        public int IFFGroup = 0;
        // Start is called before the first frame update
        void Start()
        {

        }
        Vector3 LastPosition;
        // Update is called once per frame
        void Update()
        {
            if (isDetectable == false)
            {
                if (isMoving == true) isMoving = false;
            }
            else
            {
                if (isAlwaysDetected == true)
                {
                    if (isMoving == false) isMoving = true;
                }
                else
                {
                    var length = (LastPosition - transform.position).magnitude;
                    if (length != 0)
                    {
                        if (isMoving == false) isMoving = true;
                    }
                    else
                    {
                        if (isMoving == true) isMoving = false;
                    }
                    LastPosition = transform.position;
                }
            }
        }
    }
}