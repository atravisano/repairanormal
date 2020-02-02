using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkNotOnCollision : MonoBehaviour
{
    public GameObject GameObjectName;
    public GameObject GameManagerReference;
    public float Delay;
    private GameManager _gameManager;
    private float timeUntilSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameManagerReference.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == GameObjectName.name)
        {
            // disable spark
            EnableSpark(false);
            // disable gravity
            EnableColliderGravity(col, false);
            _gameManager.FuseInstalled = true;
        }
    }

    void OnTriggerStay(Collider other) {
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            // disable gravity
            EnableColliderGravity(other, false);
            timeUntilSpawn = Delay;
        }
    }
    void OnTriggerExit(Collider other) 
    {
        EnableSpark(true);
        _gameManager.FuseInstalled = false;
        // enable gravity
        EnableColliderGravity(other, true);
    }

     void EnableSpark(bool isEnabled)
     {
        this.transform.GetChild(0).gameObject.SetActive(isEnabled);
     }

     void EnableColliderGravity(Collider other, bool isEnabled)
     {
         other.gameObject.GetComponent<Rigidbody>().useGravity = isEnabled;
     }
}
