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
        /*if(other.tag == "mirror" && !audioSource.isPlaying)
        {
            int randomInt = Random.Range(0, 8);
            audioSource.clip = clips[randomInt];
            audioSource.Play();
        }*/

        if (other.tag == "mirror")
        {
            AudioSource mirrorAudio;
            mirrorAudio = other.gameObject.GetComponent<AudioSource>();

            if(!mirrorAudio.isPlaying)
            {
                mirrorAudio.Play();
            }
        }
    }

}