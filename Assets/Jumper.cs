using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    //public Rigidbody myRigidbody;
    //Changed from public to private
    [SerializeField]
    private Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.AddForce(0, 500, 0);
    }
}
