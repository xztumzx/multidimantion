using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class EnemyLocomotionManager : MonoBehaviour
{
    EnemyManager enemyManager;

    public CharacterState currentTarget;
    public LayerMask detectionLayer;

    private void Awake()
    {
        enemyManager = GetComponent<EnemyManager>();
    }
    public void HandleDetaction()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, enemyManager.detectionRadius, detectionLayer);
        
        for (int i = 0; i < colliders.Length; i++)
        {
            CharacterState characterState = colliders[i].transform.GetComponent<CharacterState>();

            if (characterState != null)
            {
                // Check for team ID

                Vector3 targetDirection = characterState.transform.position - transform.position;
                float viewableAngle = Vector3.Angle(targetDirection, transform.forward);

                if (viewableAngle > enemyManager.minimumDetectionAngle && viewableAngle < enemyManager.maximumDetectionAngle)
                {
                    currentTarget  = characterState;
                }
            }
        }
    }

}
