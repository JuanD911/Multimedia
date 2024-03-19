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
    public bool is_enemy;
    public float tiempo_disparo = 2f;
    float tiempo_espera;

    private void Update(){

        if(Input.GetButtonDown("Fire1")){
            bulletInvocation();
        }

        if(is_enemy){
            tiempo_espera -= Time.deltaTime;
            if(tiempo_espera < 1){
                bulletInvocation();
                tiempo_espera = tiempo_disparo;
            }
        }
    }
    public void bulletInvocation(){
        GameObject bulletInstantiated = Instantiate(bala, cañon.transform.position, cañon.transform.rotation);
        bulletInstantiated.GetComponent<Bala>().bulletDamage = bulletDamage;
        bulletInstantiated.GetComponent<Rigidbody>().AddForce(cañon.transform.forward * bulletSpeed );
    }
}
