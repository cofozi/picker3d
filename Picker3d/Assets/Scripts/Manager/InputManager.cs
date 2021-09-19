using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class InputManager : MonoBehaviour
{


    public static InputManager Instance;

    public UnityAction<float> onHorizontalValueChanged = delegate { };

    private float _horizontalValue;

    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }

    void Update()
    {
        //_horizontalValue = InputManager.GetAxisRaw("Horizontal");

        if (Input.GetMouseButton(0))
        {
            _horizontalValue = InputManager.MousePosition;
        }

        onHorizontalValueChanged?.Invoke(_horizontalValue);
    }

}
