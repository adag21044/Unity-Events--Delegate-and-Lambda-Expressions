using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void MouseClickDelegate();

    public static event MouseClickDelegate OnMouseClick;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnMouseClick?.Invoke();
        }
    }
}