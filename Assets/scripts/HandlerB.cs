using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerB : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.StartListening(EventManager.TRIGGER_B, EventTriggerFromA);
    }

    private void OnDisable()
    {
        EventManager.StopListening(EventManager.TRIGGER_B, EventTriggerFromA);
    }

    void EventTriggerFromA()
    {
        Debug.Log("this method in Handler B is triggered from HandlerA");
    }

    public void BtnHandlerB() {
        EventManager.TriggerEvent(EventManager.TRIGGER_A);
    }
}
