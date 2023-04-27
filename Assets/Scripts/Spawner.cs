using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    [SerializeField]
    GameObject spawnItem;
    [SerializeField]
    int maxItems;
    [SerializeField]
    float xRange;
    [SerializeField]
    float yRange;
    [SerializeField]
    float zRange;

    List<GameObject> spawnedItems;

    private void Start() {
        spawnedItems = new List<GameObject>();
    }

    void Update() {
        spawnedItems.RemoveAll(s => s == null);
        if (spawnedItems.Count < maxItems) {
            var item = Instantiate(spawnItem);
            item.transform.parent = gameObject.transform;
            item.transform.localPosition = new Vector3(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), Random.Range(-zRange, zRange));

            spawnedItems.Add(item);
        }
    }
}
