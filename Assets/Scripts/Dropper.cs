using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    Rigidbody rigidbody;
    MeshRenderer meshRenderer;

    private bool hasDropped = false;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();    
    }
    private void Start()
    {
        rigidbody.useGravity = false;
        meshRenderer.enabled = false;
    }
    void Update()
    {
        Debug.Log(Time.time);
        if(Time.time >= timeToWait && !hasDropped)
        {
            rigidbody.useGravity = true;
            meshRenderer.enabled= true;

            hasDropped = true;
        }
    }
}
