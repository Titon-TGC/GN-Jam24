using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
   [SerializeField]
    private float _chanceOfCollectableDrop;

    private GameObject _collectableSpawner;

    private void Awake()
    {
        _collectableSpawner = GameObject.Find("CollectableSpawner");
    }

    public void RandomlyDropCollectable()
    {
        float random = Random.Range(0f, 1f);

        if (_chanceOfCollectableDrop >= random)
        {
            _collectableSpawner.GetComponent<CollectableSpawner>().SpawnCollectable(transform.position);
        }
    }
}
