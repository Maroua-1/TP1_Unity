using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            2f * Time.deltaTime
        );
    }
}

