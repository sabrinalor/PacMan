using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelSpawnPointScriept : MonoBehaviour
{
    oublic gameObject theOtherSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

private void OnTriggerEnter(Collider other)
{
    if (CORE.currentTrigger == null)
    {
        CORE.currentTrigger = other.gameObject;
        other.gameObject.transform.position = this.the theOtherSpawnPoint.transform.position;
    }   
}

private void OnTriggerExit(Collider other)
{
    CORE.currentTrigger = null;
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
