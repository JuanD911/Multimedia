using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletDamage;

    public void Start(){
        Destroy (gameObject, 4f);
    }
    
    private void OnCollisionEnter(Collision collision){
        if(!collision.collider.CompareTag("Bala"));
        Destroy (gameObject);
    }
}
