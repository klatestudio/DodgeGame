using JetBrains.Annotations;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Caller();
    }

    // Update is called once per frame
    void Update()
    {
        MoveControl();
  
    
    }
    void Caller()
    {
        Debug.Log("Hello");
    }
    void MoveControl()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0f, zValue);
    }
}
