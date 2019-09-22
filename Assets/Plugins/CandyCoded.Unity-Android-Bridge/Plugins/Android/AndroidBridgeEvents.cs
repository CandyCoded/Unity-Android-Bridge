using System;
using UnityEngine;

namespace CandyCoded.UnityAndroidBridge
{

    public class AndroidBridgeEvents : MonoBehaviour
    {

        public Action action;

        public void CallbackOneShot()
        {

            action?.Invoke();

            Destroy(gameObject);

        }

    }

}
