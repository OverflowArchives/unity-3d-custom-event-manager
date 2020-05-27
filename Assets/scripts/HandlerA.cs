using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerA : MonoBehaviour
{

    private void OnEnable()
    {
        EventManager.StartListening(EventManager.TRIGGER_A, EventTriggerFromB);
    }

    private void OnDisable()
    {
        EventManager.StopListening(EventManager.TRIGGER_A, EventTriggerFromB);
    }

    void EventTriggerFromB() {
        Debug.Log("this method in Handler A is triggered from HandlerB");
    }

    public void BtnHandlerA()
    {
        EventManager.TriggerEvent(EventManager.TRIGGER_B);
    }
}
