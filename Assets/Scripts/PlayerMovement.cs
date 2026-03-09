using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = .001f;

    private void Start()
    {
        
    }
    private void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0;
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue * speed, yValue, zValue * speed);    



    }
}
