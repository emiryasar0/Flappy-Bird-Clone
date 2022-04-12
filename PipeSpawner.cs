using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]

    [SerializeField] private float maxTime = 1;
    [SerializeField] private float height = 1;
    [SerializeField] private GameObject pipePrefab = null;

    [Header("Others")]
    private float timer = 0;

    private void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipePrefab);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            newPipe.transform.parent = transform;
            Destroy(newPipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
