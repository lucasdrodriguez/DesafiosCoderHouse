using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] bulletPrefab;
    public GameObject desdeDondeSaleLaBala;
    public float velocidadBala;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullets", 2f, 1.5f);
        velocidadBala = 15f;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnBullets()
    {
        int enemyIndex = Random.Range(0, bulletPrefab.Length);
        GameObject balaInstanciada = Instantiate(bulletPrefab[enemyIndex], desdeDondeSaleLaBala.transform.position, Quaternion.identity);

        float velocidad = balaInstanciada.GetComponent<BulletController>().bulletSpeed;

        balaInstanciada.transform.rotation = this.transform.rotation;
        Rigidbody rigidbody = balaInstanciada.GetComponent<Rigidbody>();
        rigidbody.AddForce(this.transform.forward * -1 * velocidad, ForceMode.Impulse);

    }
}
