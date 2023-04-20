using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Hero : MonoBehaviour
{

    public float moventSpeed = 10;
    public float turnSpeed = 50;
    public static float verticalInput, horisontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horisontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * moventSpeed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * horisontalInput * Time.deltaTime);
    }
}
