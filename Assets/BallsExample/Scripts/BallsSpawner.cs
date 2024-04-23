using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallsSpawner : MonoBehaviour
{
    private const float RandomSpawnDeviation = 0.1f;

    [SerializeField] private float _timeToSpawnOneBall = 0.1f;
    [SerializeField, Range(0, 10)] private int _ballsCount;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private GameObject _ballsCounterObject;

    private BallsCounter _ballsCounter;

    private void Awake()
    {
        _ballsCounter = _ballsCounterObject.GetComponent<BallsCounter>();
    }
    
    public void Spawn()
    {
        StartCoroutine(SpawnBalls());
    }

    private IEnumerator SpawnBalls()
    {
        for (int i = 0; i < _ballsCount; i++)
        {
            SpawnOneBall();
            yield return new WaitForSeconds(_timeToSpawnOneBall);
        }
    }

    private void SpawnOneBall()
    {
        Vector3 spawnPosition = _spawnPosition.position + new Vector3(Random.value, Random.value, Random.value);
        GameObject ball = Instantiate(_ballPrefab, spawnPosition, Quaternion.identity);
        BallType randomBallType = (BallType)Random.Range(0, Enum.GetValues(typeof(BallType)).Length);

        if (ball.TryGetComponent(out Ball component))
            component.Initialize(randomBallType, _ballsCounter);
        else
            Destroy(ball);
    }
}
