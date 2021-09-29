using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [HideInInspector] public Vector2 moveVector;
    [HideInInspector] public bool dash;
    [HideInInspector] public bool interact;
    [HideInInspector] public bool attack;
    
    private void Update()
    {
        moveVector.x = (Keyboard.current.aKey.isPressed ? -1f : 0f) + (Keyboard.current.dKey.isPressed ? 1f : 0f);
        moveVector.y = (Keyboard.current.sKey.isPressed ? -1f : 0f) + (Keyboard.current.wKey.isPressed ? 1f : 0f);
        
        if (moveVector.magnitude > 1)
        {
            moveVector = moveVector.normalized;
        }
        
        dash = Keyboard.current.spaceKey.wasPressedThisFrame;
        interact = Keyboard.current.fKey.wasPressedThisFrame;
        attack = Keyboard.current.kKey.wasPressedThisFrame;

        // My little Bugfix
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            moveVector = Vector2.zero;
        }
    }
}