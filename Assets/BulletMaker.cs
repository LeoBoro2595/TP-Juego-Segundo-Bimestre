using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMaker : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject BulletSpawnPoint;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.X))
        {
            GameObject clonBala;
            clonBala = Instantiate(bulletPrefab);
            clonBala.transform.position = BulletSpawnPoint.transform.position;
            clonBala.GetComponent<Rigidbody>().AddForce(new Vector3 (-1500, 0, 0));
            Destroy(clonBala, 3);
        }
    }
}