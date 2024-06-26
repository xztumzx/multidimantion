using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyManager : characterManager
{
    EnemyLocomotionManager enemyLocomotionManager;
    bool isPreformingAction;

    [Header("A.I Settings")]
    public float detectionRadius = 20;
    // the higher, and lower, respectively these angles are, the greater drtection FIELD OF VIEW (basically like eye sight)
    public float maximumDetectionAngle = 50;
    public float minimumDetectionAngle = -50;

    private void Awake()
    {
        enemyLocomotionManager = GetComponent<EnemyLocomotionManager>();
    }
    private void Update()
    {
        HandleCurrentAction();
    }
    private void HandleCurrentAction()
    {
        if (enemyLocomotionManager.currentTarget == null)
        {
            enemyLocomotionManager.HandleDetaction();
        }
    }
}

