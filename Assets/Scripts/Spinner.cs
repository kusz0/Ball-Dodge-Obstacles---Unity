using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;
    private void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
