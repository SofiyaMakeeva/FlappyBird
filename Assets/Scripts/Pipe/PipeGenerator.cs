using UnityEngine;

public class PipeGenerator : PipePool
{
    [SerializeField] private GameObject _template;
    [SerializeField] private float _maxSpawnPositionY;
    [SerializeField] private float _minSpawnPositionY;

    private float _elapsedTime = 0;
    private float _secondsBetweenSpawn = 1.5f;
    private float _spawnPositionY;
    private Vector3 _spawnPosition;

    private void Start()
    {
        Initialize(_template);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _secondsBetweenSpawn)
        {
            if (TryGetObject(out GameObject pipe))
            {
                _elapsedTime = 0;
                _spawnPositionY = Random.Range(_minSpawnPositionY, _maxSpawnPositionY);
                _spawnPosition = new Vector3(transform.position.x, _spawnPositionY, transform.position.z);

                pipe.SetActive(true);
                pipe.transform.position = _spawnPosition;

                DisableObjectAbroadScreen();
            } 
        }  
    }
}
