using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] MonoBehaviour[] script;
    private bool isActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            if(isActivated)
            {
                return;
            }
            foreach (MonoBehaviour script in script)
            {
                script.enabled = true;
                isActivated = true;
            }
        }
    }

}
