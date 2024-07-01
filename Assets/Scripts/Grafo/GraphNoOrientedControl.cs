using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNoOrientedControl : MonoBehaviour
{
    public NodeControl[] allNodesControl;
    public NodeControl initialNodeControl;
    public EnemyControl enemyControl;

    void Start()
    {
        enemyControl.SetInitialNodeToMove(initialNodeControl);
    }
}
