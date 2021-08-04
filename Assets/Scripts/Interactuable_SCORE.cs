using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactuable_SCORE : MonoBehaviour
{
    private MeshRenderer myRenderer;
    private AudioSource audioSource;
    public int add_Score = 5;
    public GameObject particulas;

    void Start() 
    {
        audioSource = GetComponent<AudioSource>();
        myRenderer = GetComponent<MeshRenderer>();
    }
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            myRenderer.enabled = false;
            Points.instance.score += add_Score;
            Instantiate(particulas, transform.position, transform.rotation);

            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.Play();


            Destroy(this.gameObject, 1);
        }
        
    }
}
