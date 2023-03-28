using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class move_player : MonoBehaviour
{
    [SerializeField]
    public float speed;
    [SerializeField]
    public float startX;

    [SerializeField]
    InputAction up = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction down = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction left = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction right = new InputAction(type: InputActionType.Button);

    public void OnEnable()
    {
        up.Enable();
        down.Enable();
        left.Enable();
        right.Enable();
        
    }

    public void OnDisable()
    {
        up.Disable();
        down.Disable();
        left.Disable();
        right.Disable();
       
    }
    void Start()
    {
        transform.position = new Vector3(startX, 1.9f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (up.IsPressed() && transform.position.y <= 8)
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (down.IsPressed() && transform.position.y >= -21)
        {
            transform.position += new Vector3(0, -1 * speed * Time.deltaTime, 0);
        }
        if (left.IsPressed() && transform.position.x >= -48.06)
        {
            transform.position += new Vector3(-1 * speed * Time.deltaTime, 0, 0);
        }
        if (right.IsPressed() && transform.position.x <= 48.06)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

    }
}
