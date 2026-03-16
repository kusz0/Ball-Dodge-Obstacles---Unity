using UnityEditor;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField]
    private int score;
    void Start()
    {
        score = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Front wall")
        {
            score++;
        }
        Debug.Log($"ur score {score}");
    }

}
