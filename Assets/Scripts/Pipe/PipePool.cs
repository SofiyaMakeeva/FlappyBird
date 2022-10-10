using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PipePool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private int _capacity;

    private Camera _camera;
    private List<GameObject> _pool = new List<GameObject>();

    public void ResetPool()
    {
        foreach (var item in _pool)
        {
            item.SetActive(false);
        }
    }

    protected void Initialize(GameObject prefab)
    {
        _camera = Camera.main;

        for (int i = 0; i < _capacity; i++)
        {
            GameObject spawned = Instantiate(prefab, _container.transform);
            spawned.SetActive(false);

            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject gameObject)
    {
        gameObject = _pool.FirstOrDefault(pool => pool.activeSelf == false);

        return gameObject != null;
    }

    protected void DisableObjectAbroadScreen()
    {
        Vector3 disablePoint = _camera.ViewportToWorldPoint(new Vector2(0.5f, 0.5f));

        foreach (var item in _pool)
        {
            if (item.activeSelf == true)
            {
                if (item.transform.position.x < disablePoint.x)
                {
                    item.SetActive(false);
                }
            }
        }
    }
}
