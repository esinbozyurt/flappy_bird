using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float queueTime = 1.5f;
    private float time = 0;
    public GameObject obstacle;
    public float height;

    public GameManager manage;

    void Start()
    {
        manage= GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (time > queueTime)
        {
            GameObject go = Instantiate(obstacle);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            time = 0;
            manage.increase_score(10);
            Destroy(go, 10);
        }

        time += Time.deltaTime;
    }
}