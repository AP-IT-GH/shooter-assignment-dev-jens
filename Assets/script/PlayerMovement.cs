using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveVal;

    [SerializeField]
    float moveSpeed;

    float horizontal = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        var xOffset = horizontal * moveSpeed * Time.deltaTime;
        var newXPos = Mathf.Clamp(transform.localPosition.x + xOffset, -15, 15);
        transform.localPosition = new Vector3(newXPos, transform.localPosition.y, transform.localPosition.z);
        
    }

    private void OnHorizontal(InputValue value)
    {
        var data = value.Get<float>();

        Debug.Log(value);
        horizontal = data;
    }
    private void OnHorizontalCanceled(InputAction.CallbackContext context)
    {
        var data = context.ReadValue<float>();
        
        horizontal = data;
    }

}
