using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody myRB;

    public Vector2 force = new Vector2(10, 10);



    // Start is called before the first frame update
    void Start()
    {
        var forceAmountY = Random.Range(force.x, force.y);
        var forceAmountX = forceAmountY = Random.Range(-0.5f, 0.5f);
        var forceAmountZ = forceAmountY = Random.Range(-0.5f, 0.5f);



        myRB = gameObject.GetComponent<Rigidbody>();
        var forceVector = new Vector3(forceAmountX, forceAmountY, forceAmountZ);
        myRB.AddForce(forceVector, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
