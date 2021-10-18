using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [Header("Speed")]
    [Range(0, 10)] public float bulletSpeed;

    [Header("Damage")]
    public float bulletDamage = 5;
    [Range(1,25)]
    public float tiempoLimite;
    public float tiempoVida;
    
    // Start is called before the first frame update
    void Start()
    {
        tiempoLimite = 5;
        tiempoVida = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoVida += Time.deltaTime;

        if (tiempoVida > tiempoLimite)
        {
            Destroy(this.gameObject);   
        }
    }

  
}