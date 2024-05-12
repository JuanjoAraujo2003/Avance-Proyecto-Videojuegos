using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {

        float movimientoVertical = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        transform.Translate(0f, 0f, movimientoVertical);

        float movimientoHorizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        transform.Translate(movimientoHorizontal, 0f, 0f);


    }
}

