using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public bool gameOver=false;
    // Start is called before the first frame update
    void Awake() {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}

