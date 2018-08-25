using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    public float endDelay = 5f;
    public GameObject mainCamera;
    public GameObject endScreen;
    private int gameSuccess = 0;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && gameSuccess == 0)
        {
            gameSuccess = 1;
            Debug.Log("HIT");
            Invoke("EndGame", endDelay);
            Debug.Log("Complete");
        }
    }

    void EndGame()
    {
        Debug.Log("Moving Camera");
        SceneManager.LoadScene("EndScene");


    }



}
