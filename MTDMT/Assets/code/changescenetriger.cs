using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescenetriger : MonoBehaviour
{
    public int nextscene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //tag Player
        {
            SceneManager.LoadScene(nextscene);
        }
    }
}
