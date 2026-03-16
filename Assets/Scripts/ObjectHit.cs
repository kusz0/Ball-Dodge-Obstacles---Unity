using System.Runtime.CompilerServices;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        Debug.Log($"Hit {gameObject.name} by {collision.gameObject.name}");   
    }
}
