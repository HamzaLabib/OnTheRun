using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        //Debug.Log(player.position);
        transform.position = player.position + offset;
    }
}
