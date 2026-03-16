using UnityEngine;

public class Dropper : MonoBehaviour
{
    private Time timer;
    void Start()
    {
        
    }

    void Update()
    {
        Debug.Log(Time.time);
        if(Time.time >= 3f)
        {
            gameObject.AddComponent<Rigidbody>();
        }
    }
}
