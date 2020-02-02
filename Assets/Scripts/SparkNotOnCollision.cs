using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkNotOnCollision : MonoBehaviour
{
    public GameObject GameObjectName;
    public GameObject GameManagerReference;
    private GameManager _gameManager;

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
            col.gameObject.GetComponent<Rigidbody>().useGravity = false;
            _gameManager.FuseInstalled = true;
        }
    }

    void OnTriggerExit(Collider other) 
    {
        EnableSpark(true);
        _gameManager.FuseInstalled = false;
        other.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

     void EnableSpark(bool isEnabled)
     {
        this.transform.GetChild(0).gameObject.SetActive(isEnabled);
     }
}
