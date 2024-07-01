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

    void Start()
    {
        energy = 15f;
        currentNodeToMove = FindObjectOfType<NodeControl>();
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
