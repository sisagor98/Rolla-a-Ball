using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject boomPrefab;
    public int numberCoin = 10;

    public float xLimit;
    public float zLimit;

    private void Start()
    {
        GenerateCoins();
        GenerateBoom();
    }

    private void GenerateBoom()
    {
        Vector3 coinPos = new Vector3(Random.Range(xLimit, -xLimit), .5f, Random.Range(zLimit, -zLimit));
        Instantiate(boomPrefab, coinPos, Quaternion.identity);
    }

    private void GenerateCoins()
    {
        for (int i = 0; i < numberCoin; i++)
        {
            Vector3 coinPos = new Vector3(Random.Range(xLimit, -xLimit), .5f, Random.Range(zLimit, -zLimit));
            Instantiate(coinPrefab, coinPos, Quaternion.identity);
        }
    }
}
