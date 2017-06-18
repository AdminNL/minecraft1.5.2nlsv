using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject Prefab;
    public int SpawnNum;
    
	void Start ()
    {
        int i = 0;

        while (i < SpawnNum)
        {
            float size = Prefab.GetComponent<SpriteRenderer>().sprite.bounds.size.x;
            size *= Prefab.transform.localScale.x;

            GameObject newObject = Instantiate(Prefab);
            newObject.transform.position = new Vector3(i * size, 0.0f);

            i++;
        }
	}

    void Update()
    {
    }
}
