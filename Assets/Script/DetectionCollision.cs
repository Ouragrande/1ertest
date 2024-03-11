using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawner : MonoBehaviour
{
    private SpawerManager spawnerManager;
    [SerializeField]
    private Transform endPlatform;
    [SerializeField]
    private Transform platform;
    private void Start()
    {
        spawnerManager = GameObject.Find("SpawnerManager").GetComponent<SpawerManager>();
        //Destroy(transform.parent.gameObject, 8f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //Instantiate(spawnerManager.platform, new Vector3(platform.position.x, platform.position.y, platform.localScale.z*10 + platform.position.z), Quaternion.identity);
            Instantiate(spawnerManager.platforms[Random.Range(0, spawnerManager.platforms.Length)], new Vector3(platform.position.x, platform.position.y, platform.localScale.z*10 + platform.position.z),Quaternion.identity);
        }
    }
}

