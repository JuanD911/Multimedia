    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bala;
    public GameObject cañon;
    public float bulletSpeed;
    public float bulletDamage;

    private void Update(){
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("Shoot");
            bulletInvocation();
        }
    }

    public void bulletInvocation(){
        GameObject bulletInstantiated = Instantiate(bala, cañon.transform.position, cañon.transform.rotation);
        bulletInstantiated.GetComponent<Bala>().bulletDamage = bulletDamage;
        bulletInstantiated.GetComponent<Rigidbody>().AddForce(cañon.transform.forward * bulletSpeed );

    }
}
