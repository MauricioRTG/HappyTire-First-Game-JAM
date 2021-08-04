using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInstancer : MonoBehaviour
{
    // Update is called once per frame
    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            int randInt = Random.Range(0, LevelManager.instance.nivelesPrefabs.Length);

            GameObject randGameObject = LevelManager.instance.nivelesPrefabs[randInt].gameObject;
            
            Instantiate(randGameObject,
                        LevelManager.instance.offset.position,
                        LevelManager.instance.offset.rotation);
            
            LevelManager.instance.offset.Translate(new Vector3(50,0,0),Space.World);
        }
    }
}
