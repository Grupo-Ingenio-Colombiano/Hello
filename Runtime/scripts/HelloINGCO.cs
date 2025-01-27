
using System;
using UnityEngine;

namespace VP.HelloIngco
{
    public class HelloINGCO : MonoBehaviour
    {
        public string whatSay;

        private void Start()
        {
            Hello();
        }

        public void Hello()
        {
            Debug.Log(whatSay);

        }
    }
}


