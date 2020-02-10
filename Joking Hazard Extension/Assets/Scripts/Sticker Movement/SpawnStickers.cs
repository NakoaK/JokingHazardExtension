using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStickers : MonoBehaviour
{
    public GameObject prefab;
    void Update()
    {
        Instantiate(prefab, Vector3.up, Quaternion.identity);
        
    }

}
