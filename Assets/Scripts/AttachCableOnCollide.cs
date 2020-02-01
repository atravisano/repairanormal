using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachCableOnCollide : MonoBehaviour
{
    public string GameObjectName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == GameObjectName)
        {
            // disable spark
            EnableSpark(false);

            // creates joint
            FixedJoint joint = gameObject.AddComponent<FixedJoint>();
            // sets joint position to point of contact
            joint.anchor = col.contacts[0].point;
            // conects the joint to the other object
            joint.connectedBody = col.contacts[0].otherCollider.transform.GetComponentInParent<Rigidbody>();
            // Stops objects from continuing to collide and creating more joints
            joint.enableCollision = false;
            Debug.Log("Connected!");
        }
    }
    
     void EnableSpark(bool isEnabled)
     {
        this.transform.GetChild(0).gameObject.SetActive(isEnabled);
     }
}
