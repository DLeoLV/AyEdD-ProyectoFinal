using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNoOrientedControl : MonoBehaviour
{
    public NodeControl[] allNodesControl;
    public NodeControl initialNodeControl;
    public EnemyControl enemyControl;
    // Start is called before the first frame update
    void Start()
    {
        enemyControl.SetInitialNodeToMove(initialNodeControl);
    }
}
