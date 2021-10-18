using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{

    public GameObject jugadorASeguir;  // CAÑON
    public Vector3 distanciaPlayer;   // OFFSET -> LA DISTANCIA QUE VA A TOMAR DESDE EL CAÑON 

    private void Awake()
    {
        distanciaPlayer = new Vector3(0, 3, 8);
        this.transform.Rotate(Vector3.up * -180);
        this.transform.Rotate(Vector3.right * 13);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // THIS -> ES LA CAMARA 
        this.transform.position = jugadorASeguir.transform.position + distanciaPlayer;
        this.transform.rotation = jugadorASeguir.transform.rotation;
        this.transform.Rotate(jugadorASeguir.transform.up * -180);
    }
}
