using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void onClickNextScene() {
        SceneManager.LoadScene("noey3");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
