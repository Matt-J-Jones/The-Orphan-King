using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public string NewScene;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(NewScene); 
    }

}
