using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    #region MyRegion

    //public int playerHealth = 3;
    //[Range(0, 50)] public float speedPlayer;

    //[Header("escala")]
    //public float x;
    //public float y;
    //public float z;


    //[Header("direccion")]
    //[Range(-1, 1)] public int movX;
    //[Range(-1, 1)] public int movY;
    //[Range(-1, 1)] public int movZ;

    //private float timer = 0f;


    #endregion

    public float rotarEnY;
    public float velocidadRotacion;

    void Start()
    {

        velocidadRotacion = 50;
    }

    // Update is called once per frame
    void Update()
    {

        rotarEnY = Input.GetAxis("Horizontal");

        this.transform.Rotate(Vector3.up * rotarEnY * velocidadRotacion * Time.deltaTime);

    }



}