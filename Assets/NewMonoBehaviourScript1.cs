using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float force = 100f;
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.back * force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
