using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] bulletPrefab;
    public GameObject desdeDondeSaleLaBala;
    public float tiempoDeDisparo;
    public float velocidadBala;
    private float tiempoDesdeUltimaBala;
    private float tiempoDesdeUltimaSpace;
    private bool tamanioDuplicado;
    // Start is called before the first frame update
    void Start()
    {
        velocidadBala = 15f;
        tiempoDeDisparo = 1f;
        tiempoDesdeUltimaBala = 0;
        tiempoDesdeUltimaSpace = 0;
        tamanioDuplicado = false;
    }

    void Update()
    {
        tiempoDesdeUltimaBala += Time.deltaTime;
        tiempoDesdeUltimaSpace += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && tiempoDesdeUltimaSpace > 1.5f)
        {
            SpawnBullets(true);
            tiempoDesdeUltimaSpace = 0;
            tiempoDesdeUltimaBala += 0.5f;
        }
        else if (tiempoDesdeUltimaBala >= tiempoDeDisparo)
        {
            tiempoDesdeUltimaBala = 0;
            SpawnBullets();
        }


    }

    void SpawnBullets(bool doble = false)
    {
        GameObject balaTemplate = bulletPrefab[Random.Range(0, bulletPrefab.Length)];
        if (doble)
        {
            balaTemplate.transform.localScale *= 2;
            tamanioDuplicado = false;
        }
        else
        {
            balaTemplate.transform.localScale = new Vector3(1, 1, 1);
        }

        GameObject balaInstanciada = Instantiate(balaTemplate, desdeDondeSaleLaBala.transform.position, Quaternion.identity);
        balaInstanciada.transform.rotation = this.transform.rotation;
        Rigidbody rigidbody = balaInstanciada.GetComponent<Rigidbody>();
        rigidbody.AddForce((this.transform.forward * -1 ) * 
                            balaInstanciada.GetComponent<BulletController>().bulletSpeed, 
                            ForceMode.Impulse);

    }
}
