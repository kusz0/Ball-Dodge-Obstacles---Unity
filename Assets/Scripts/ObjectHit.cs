using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    [SerializeField]
    private GameObject hitObject;

    private void Awake()
    {
        hitObject = gameObject;   
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Hit {hitObject.name} by {collision.gameObject.name}");   
    }
}
