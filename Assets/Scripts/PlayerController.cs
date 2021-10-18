using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class PlayerController : MonoBehaviour
//{

//    #region Variables


//    [SerializeField] private float playerScale;

//    [SerializeField] [Range(0, 100)] private float speed;


//    [Header("Ejes")]

//    [SerializeField] [Range(-20, 20)] private int x;
//    [SerializeField] [Range(-20, 20)] private int y;
//    [SerializeField] [Range(-20, 20)] private int z;

//    #endregion

//    void Start()
//    {

//        playerScale = 20;
//        x = y = z = 0;
//    }

//    void Update()
//    {

//        transform.localScale = Vector3.one * playerScale;
//        transform.position += new Vector3(x, y, z) * Time.deltaTime * speed;

//    }
//}
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
        #region Codigo Viejo
        //Debug.ClearDeveloperConsole();
        //Debug.Log(transform.position);
        //x = 0.5f;
        //y = 0.5f;
        //z = 0.5f;
        //transform.position = new Vector3(1, 4, 3);
        //transform.localScale = new Vector3(x, y, z);
        //speedPlayer = 0;

        #endregion
        velocidadRotacion = 50;
    }

    // Update is called once per frame
    void Update()
    {

        rotarEnY = Input.GetAxis("Horizontal");

        this.transform.Rotate(Vector3.up * rotarEnY * velocidadRotacion * Time.deltaTime);

    }
    #region Codigo Viejo
    //private void Moverse()
    //{
    //    transform.position += new Vector3(movX, movY, movZ) * speedPlayer;
    //}

    //private void Curarse()
    //{
    //    playerHealth += 10;
    //    Debug.Log("Jugador curado en 10 unidades");
    //}
    //private void Lastimarse()
    //{
    //    playerHealth -= 3;
    //}
    //private void CambiarTamanio()
    //{
    //    transform.localScale = new Vector3(x, y, z);
    //}
    #endregion


}