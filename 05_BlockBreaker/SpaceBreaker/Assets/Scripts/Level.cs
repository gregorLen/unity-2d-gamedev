using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Level : MonoBehaviour
{
    // parameters
    [SerializeField] int breakableBlocks; // Serialized for debugging purpose

    // cashed reference
    SceneLoader sceneLoader; 

    public void Start()
    {
        Debug.Log("entered start method");
        sceneLoader = FindObjectOfType<SceneLoader>();
        print(sceneLoader);
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks --;
        if (breakableBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }


}
