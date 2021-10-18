using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [Header("Speed")]
    [Range(0, 10)] public float bulletSpeed;

    [Header("Damage")]
    public float bulletDamage = 5;

    
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
       
        if (this.transform.position.z < -25 || this.transform.position.z >25 || 
        this.transform.position.x < -25 || this.transform.position.x >25)
        {
            Destroy(this.gameObject);
        }
    }

  
}