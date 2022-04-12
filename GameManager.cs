using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverCanvas = null;
    [SerializeField] private Player player = null;
    [SerializeField] private PipeSpawner pipeSpawner = null;

    private void Start()
    {
        GameOver(true);
    }

    public void AddScore()
    {
        Score.score++;
    }

    public void GameOver(bool _fistStart)
    {
        if (_fistStart)
        {
            gameOverCanvas.transform.GetChild(1).gameObject.SetActive(false);
            gameOverCanvas.transform.GetChild(2).gameObject.SetActive(false);
        }
        else
        {
            gameOverCanvas.transform.GetChild(1).gameObject.SetActive(true);
            gameOverCanvas.transform.GetChild(2).gameObject.SetActive(true);
        }

        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }    

    public void Replay()
    {
        for (int i = 0; i < pipeSpawner.transform.childCount; i++)
        {
            Destroy(pipeSpawner.transform.GetChild(i).gameObject);
        }

        player.transform.position = Vector3.zero;
        player.transform.rotation = Quaternion.identity;

        Score.score = 0;

        for (int i = 0; i < pipeSpawner.transform.childCount; i++)
        {
            Destroy(pipeSpawner.transform.GetChild(i).gameObject);
        }

        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
