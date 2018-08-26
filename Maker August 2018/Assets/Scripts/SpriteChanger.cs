using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour {

    public Sprite spriteA;
    public Sprite spriteB;

    bool changed = false;
    SpriteRenderer spriteRenderer;

	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "changer")
        {
            Debug.Log("hello");

            if (!changed)
            {
                spriteRenderer.sprite = spriteB;
                changed = !changed;
            } else
            {
                spriteRenderer.sprite = spriteA;
                changed = !changed;
            }
        }

    }
}
