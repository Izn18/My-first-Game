using UnityEngine;

public class EndpointTrigger : MonoBehaviour
{
    public GameManager gm;
    void OnTriggerEnter()
    {
        gm.LevelComplete();
    }
}
