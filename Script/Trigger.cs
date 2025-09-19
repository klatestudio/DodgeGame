using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] GameObject Catcher;
    [SerializeField] GameObject Catcher1;
    [SerializeField] GameObject Catcher2;

    private void Start()
    {
        Catcher.SetActive(false);
        Catcher1.SetActive(false);
        Catcher2.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Catcher.SetActive(true);
            Catcher1.SetActive(true);
            Catcher2.SetActive(true);
          

        }
    }
   
}
