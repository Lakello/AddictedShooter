using UnityEngine;

[RequireComponent(typeof(UserInput))]
public class CharacterMovement : MonoBehaviour
{
    private UserInput _userInput;
    private float _horizontal { get { return _userInput.Horizontal; } }
    private float _vertical { get { return _userInput.Vertical; } }
    private bool _isRun { get { return _userInput.RunKey; } }

    private void Start()
    {
        _userInput = GetComponent<UserInput>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {

    }
}
