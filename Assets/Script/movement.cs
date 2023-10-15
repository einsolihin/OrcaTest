using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private List<GameObject> posList = new List<GameObject>();
    [SerializeField] private float speed = 5;
    int location = 0;

    // Start is called before the first frame update
    void Start()
    {
        getRandomLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, posList[location].transform.position) < 0.05)
            getRandomLocation();

        transform.position = Vector3.MoveTowards(transform.position, posList[location].transform.position, speed*Time.deltaTime);
    }

    void getRandomLocation()
    {
        location = Random.Range(0, posList.Count);
    }
}
