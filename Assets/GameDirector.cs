using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Player player;
    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        if (player.Score >= 5000)
        {
            SceneManager.LoadScene("gameclear");
        }
        if (timer.countTime <= 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }
}
