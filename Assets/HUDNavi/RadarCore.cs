using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HUDNavi
{
    public class RadarCore : MonoBehaviour
    {
        public static RadarCore CurrentRadar;
        public GameObject Detector;
        public List<RadarDot> dots = new List<RadarDot>();
        public float RandarRadius = 50;
        [HideInInspector]
        public List<MotionTarget> Targets;

        /// <summary>
        /// The detection distance.
        /// </summary>
        public float Distance = 25;
        void Start()
        {
            CurrentRadar = this;
        }

        void Update()
        {

        }
    }
    [Serializable]
    public class RadarDot
    {
        public GameObject Dot;
        public Color Color;
        public int TypeID;
    }
}