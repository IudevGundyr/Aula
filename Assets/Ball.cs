using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private static readonly float DestructionThreshold = -10f;

    private Rigidbody myRB;

    public Vector2 force = new Vector2(10, 10);



    // Start is called before the first frame update
    void Start()
    {
        float forceAmountY = Random.Range(force.x, force.y);
        float forceAmountX = forceAmountY = Random.Range(-0.5f, 0.5f);
        float forceAmountZ = forceAmountY = Random.Range(-0.5f, 0.5f);
        Vector3 forceVector = new Vector3(forceAmountX, forceAmountY, forceAmountZ);

        myRB = gameObject.GetComponent<Rigidbody>();
        myRB.AddForce(forceVector, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        float y = transform.position.y;
        if(y <= DestructionThreshold)
        {
            Destroy(gameObject);
        }
    }
}
