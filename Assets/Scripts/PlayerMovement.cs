using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 8f;

    private void Start()
    {
        
    }
    private void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xValue * speed , yValue, zValue * speed);    



    }
}
