using UnityEngine;

public class UserInput : MonoBehaviour
{
    [SerializeField] private KeyCode _runKey = KeyCode.LeftShift;

    public float Horizontal
    {
        get
        {
            return Input.GetAxisRaw(Axis.Horizontal);
        } 
    }
    public float Vertical
    {
        get
        {
            return Input.GetAxisRaw(Axis.Vertical);
        }
    }
    public bool RunKey
    {
        get
        {
            return Input.GetKey(_runKey);
        }
    }
}
