using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cablebox_Plug : MonoBehaviour
{
    public GameObject CollisionObject;
    public float Delay;
    private float timeUntilDisconnect = 0;
    private bool isPlugConnected = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilDisconnect -= Time.deltaTime;
        if (timeUntilDisconnect <= 0)
        {
            DisconnectCollision();
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == CollisionObject.name)
        {
            // creates joint
            FixedJoint joint = gameObject.AddComponent<FixedJoint>();
            // sets joint position to point of contact
            joint.anchor = col.contacts[0].point;
            // connects the joint to the other object
            joint.connectedBody = col.contacts[0].otherCollider.transform.GetComponentInParent<Rigidbody>();
            // Stops objects from continuing to collide and creating more joints
            joint.enableCollision = false;

            isPlugConnected = true;
        }
    }

    void DisconnectCollision()
    {
        Destroy(gameObject.AddComponent<FixedJoint>());
        isPlugConnected = false;
    }
}
