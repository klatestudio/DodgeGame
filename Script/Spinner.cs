using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xVector = 0.5f;
    [SerializeField] float yVector = 0.5f;
    [SerializeField] float zVector = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xVector, yVector, zVector);  
    }
}
