using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;

    // cashed reference
    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("entered collision");
        Debug.Log("Should add score");
        FindObjectOfType<GameStatus>().AddToScore();
        Debug.Log("Play Clip");
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Debug.Log("Destroy Game Object");
        Destroy(gameObject);
        level.BlockDestroyed();

    }
}
