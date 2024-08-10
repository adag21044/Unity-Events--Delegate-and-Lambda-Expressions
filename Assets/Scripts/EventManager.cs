using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void MouseClickDelegate();

    public static MouseClickDelegate OnMouseClick;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (OnMouseClick != null) OnMouseClick();
        }
    }
}
