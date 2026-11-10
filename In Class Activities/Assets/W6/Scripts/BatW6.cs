using UnityEngine;
using UnityEngine.AI;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Transform player;
    private bool isChasing = false;

    private void Update()
    {
        if (isChasing)
        {
            Vector3 Bat = new Vector3(player.position.x, player.position.y, 0f);
            transform.position = Vector3.MoveTowards(transform.position, Bat, speed * Time.deltaTime);
        }

    }

    public void startChasing() {
        isChasing = true;
    }
    public void stopChasing() {
        isChasing = false;
    }
}
