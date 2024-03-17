using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    // Start is called before the first frame update
    public float vida=100;

    void Update()
    {
        if(vida<1)
        {
            if(gameObject.CompareTag("Player"))
            {
                Debug.Log("Game Over");
            }
            else if((gameObject.CompareTag("Enemy")))
            {
                Destroy(gameObject);
            }
        }
    }
}
