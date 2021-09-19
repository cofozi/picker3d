using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;

    private float _horizontalValue;

    [SerializeField] private float speedHorizontal, speedForward;

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Instance.onHorizontalValueChanged += OnHorizontalValueChanged;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        ForwardMovement();
        HorizontalMovement();

        rigidbody.velocity += new Vector3(_horizontalValue * speedHorizontal * Time.fixedDeltaTime, 0, 0);
    }

    private void OnHorizontalValueChanged(float val)
    {
        _horizontalValue = val;
    }

    private void ForwardMovement();
    {
        rigidbody.velocity += new Vector3(0,0,_horizontalValue* speedHorizontal * Time.fixedDeltaTime);
    }
}
