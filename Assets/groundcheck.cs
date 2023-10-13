using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class groundcheck : MonoBehaviour
{
    PlayerLogic logicmovement;
    
    void Start()
    {
        logicmovement = this.GetComponentInParent<PlayerLogic>();
    }
    private void OnTriggerEnter(Collider other)
    {
        logicmovement.groundedchanger();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
