using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HUDNavi
{
    public class MotionTarget : MonoBehaviour
    {
        [HideInInspector]
        public GameObject RadarPoint;
        public bool isDetectable = false;
        public bool isAlwaysDetected = false;
        [HideInInspector]
        public bool isMoving = false;
        public int RadarIconType = 0;


        bool isAdded = false;
        void Start()
        {

        }
        Vector3 LastPosition;
        // Update is called once per frame
        void Update()
        {
            if (isAdded == false)
            {
                if (RadarCore.CurrentRadar != null)
                {
                    RadarCore.CurrentRadar.Targets.Add(this);
                    isAdded = true;
                }
            }
            else
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
}