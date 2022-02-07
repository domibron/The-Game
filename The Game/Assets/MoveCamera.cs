using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Rigidbody ridB;

    public GameObject player;

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1.3f, player.transform.position.z);
    }
}
