using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLogic : MonoBehaviour
{
    [SerializeField] Camera ShootCamera;
    [SerializeField] float range = 1000f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(ShootCamera.transform.position, ShootCamera.transform.forward, out hit, range);
        Debug.Log("I hit this thing: " + hit.transform.name);

        if (hit.transform.tag.Equals("Enemy"))
        {
            EnemyLogic target = hit.transform.GetComponent<EnemyLogic>();
            target.TakeDamage(50);
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 direction = ShootCamera.transform.TransformDirection(Vector3.forward) * range;
        Gizmos.DrawRay(ShootCamera.transform.position, direction);
    }
}