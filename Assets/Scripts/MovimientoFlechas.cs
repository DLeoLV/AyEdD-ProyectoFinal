using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFlechas : MonoBehaviour
{
    public float vel = 5f;

    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector2(movimientoHorizontal, movimientoVertical) * vel * Time.deltaTime;

        transform.position += movimiento;
    }
}
