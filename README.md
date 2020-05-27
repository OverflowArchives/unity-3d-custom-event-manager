# Unity 3D Custom Event Manager
![Custom EventManager in Unity 3d](http://www.overflowarchives.com/wp-content/uploads/2020/05/maxresdefault-1.jpg)
## Introduction
This custom event manager for Unity 3D helps to trigger / Invoke any event/method in an active gameobject.
Using this snippet an event can be triggered from any gameobject and it can listen in the active script.

### Basic Methods
This Snippet have three static methods that used to handle the events as followed.
1. `StartListentning()` - This static method should be handled inside the `OnEnabled()` of the MonoBehaviour. It is responsible to listening the events triggered in some other scripts when the gameobject is active.
2. `StopListentning()` - This static method should be handled inside the `OnDisabled()` of the MonoBehaviour. It will remove the event listening in the EventManager when the script/Gameobject is disabled.
3. `TriggerEvent()` - `TriggerEvent()` method is used to point the Event which need to be triggered and invokes the method/event.


## Watch YouTube tutorial [Here](https://youtu.be/NDdgyX6U2cc)
Watch this Tutorial, it will help you to understand how to use this Eventmanager.
