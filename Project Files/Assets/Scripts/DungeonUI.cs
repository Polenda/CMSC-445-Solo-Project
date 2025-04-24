using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DungeonUI : MonoBehaviour
{
    public static DungeonUI instance;
    
    // Start is called before the first frame update
    private void Start()
    {
        instance = this;
    }

        
    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene(0);
        }
    }
}
