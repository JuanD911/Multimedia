using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vida : MonoBehaviour
{
    // Start is called before the first frame update
    public float vida=100;
    public TextMeshProUGUI textMeshPro_;


    void Update()
    {
        textMeshPro_.text = vida.ToString();
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
