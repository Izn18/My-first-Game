using UnityEngine;

// Classs that is responsible for spawning Walls
public class SpawnWall : MonoBehaviour
{
    public GameObject Wall;

    public Vector3 center;
    public Vector3 size;
    public float Timer = 1f;

    // Update is called once per frame
    void Update()
    {
        
        // to Call my Spawn method every second
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            Spawn();
            Timer = 1f;
        }
        
        // to Test the Spawn method
        if (Input.GetKey("m"))
        {
            Spawn();
        }
    }

    // Method to Spawn 20 Walls on a Random position of my Box
    public void Spawn()
    {
        for (int i = 0; i < 20; i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2),
                              Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
            Instantiate(Wall, pos, Quaternion.identity);
        }
    }

    // Vizualization to show the Box where the Walls spawn
    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0f, 0f, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
