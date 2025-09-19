using UnityEngine;

public class Scorer : MonoBehaviour
  
{
    int Score;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != ("Hit"))
        {
            Score++;
            Debug.Log("You Bumped " + Score + " Times");
        }
             
    }
}
