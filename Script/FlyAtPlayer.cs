using Unity.Cinemachine;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 0.1f;
    Vector3 playerPosition;
    void Start()
    {
    }

    void Update()
    {
        movePlayer();
        whenReachDestroy();

    }
    void movePlayer()
    {
        playerPosition = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
    void whenReachDestroy()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
    //Other Way
    // private void OnCollisionEnter(Collision other)
    //  {
    //   if (other.gameObject.tag == "Player")
    //  {
    // Destroy(gameObject);
    //  }
    //      
    

        
   

