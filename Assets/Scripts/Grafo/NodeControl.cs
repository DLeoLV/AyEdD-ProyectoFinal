using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeControl : MonoBehaviour
{
    public int weight;
    public NodeControl[] allAdjacentNodes;

    public NodeControl ChooseRandomAdjacentNode()
    {
        int randomPosition = Random.Range(0, allAdjacentNodes.Length);
        return allAdjacentNodes[randomPosition];
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<EnemyControl>().Cooldown(weight);
        }
    }
}
