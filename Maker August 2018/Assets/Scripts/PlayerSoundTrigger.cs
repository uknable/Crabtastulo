using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundTrigger : MonoBehaviour {

    public AudioClip[] clips;

    AudioSource audioSource;

	void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "mirror" && !audioSource.isPlaying)
        {
            int randomInt = Random.Range(0, 8);
            audioSource.clip = clips[randomInt];
            audioSource.Play();
        }
    }

}