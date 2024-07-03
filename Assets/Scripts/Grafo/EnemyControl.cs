using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float speed;
    public float cooldown;
    private float step;
    public NodeControl currentNodeToMove;
    public float energy = 15f;
    public GameObject NodoInicial;

    void Start()
    {
        int randomNumber = Random.Range(0, 5);
        if(randomNumber == 0)
        {
            NodoInicial = GameObject.Find("Nodo (1)");
        }
        else if(randomNumber == 1)
        {
            NodoInicial = GameObject.Find("Nodo (24)");
        }
        else if(randomNumber == 2)
        {
            NodoInicial = GameObject.Find("Nodo (29)");
        }
        else if(randomNumber == 3)
        {
            NodoInicial = GameObject.Find("Nodo (32)");
        }
        else if (randomNumber == 4)
        {
            NodoInicial = GameObject.Find("Nodo (21)");
        }

        transform.position = new Vector3(NodoInicial.transform.position.x + 1, NodoInicial.transform.position.y + 1, 3);
        currentNodeToMove = NodoInicial.GetComponent<NodeControl>();
        energy = 15f;
    }

    void Update()
    {
        step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, currentNodeToMove.transform.position, step);
        if(energy <= 0)
        {
            speed = 0;
            cooldown = cooldown + Time.deltaTime;
        }
        if (cooldown > 1)
        {
            speed = 15f;
            cooldown = 0;
            energy = 1f;
        }
    }

    public void SelectNextNodePosition()
    {
        currentNodeToMove = currentNodeToMove.ChooseRandomAdjacentNode();
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.gameObject.tag == "Node")
        {
            SelectNextNodePosition();
            energy = 0;
        } 
    }

    public void SetInitialNodeToMove(NodeControl initialNode)
    {
        currentNodeToMove = initialNode;
    }
}
