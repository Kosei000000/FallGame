using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float countTime = 59.9f;

    void Start()
    {

    }

    void Update()
    {
        countTime -= Time.deltaTime;

        GetComponent<Text>().text = countTime.ToString("F1");
    }
}
