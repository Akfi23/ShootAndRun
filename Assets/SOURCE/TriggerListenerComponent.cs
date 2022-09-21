using Supyrb;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerListenerComponent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Signals.Get<OnTriggerCollide>().Dispatch();
    }
}
