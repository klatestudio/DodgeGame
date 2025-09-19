using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dropper : MonoBehaviour
{
    int timer = 3;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        Debug.Log(Time.time);
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {        
        if (Time.time > timer)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity =true;
        }
        else
        {
            
        }
        
    }
}
