using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzamientoDeCaña : MonoBehaviour
{
    public GameObject caña;
    public float speed = 5f;
    public Camera mainCamera; //= Camera.main;
    private GameObject cañaGenerada;
    public Vector3 targetPosition;
    public float tiempoDisparo = 3f;

    void Start()
    {
        mainCamera = Camera.main;
    }
    void Update()
    {
        tiempoDisparo += Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && tiempoDisparo >= 3f)
        {
            Generar();
            tiempoDisparo = 0f;
        }
        if (cañaGenerada != null)
        {
            Movimiento();
        }
    }

    void Generar()
    {
        targetPosition = GetMouseWorldPosition();
        cañaGenerada = Instantiate(caña, transform.position, Quaternion.identity);
    }

    void Movimiento()
    {
        cañaGenerada.transform.position = Vector2.MoveTowards(cañaGenerada.transform.position, targetPosition, speed * Time.deltaTime);
        if (Vector2.Distance(cañaGenerada.transform.position, targetPosition) < 0.1f)
        {
            Destroy(cañaGenerada);
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = Mathf.Abs(mainCamera.transform.position.z);
        return mainCamera.ScreenToWorldPoint(mouseScreenPosition);
    }
}