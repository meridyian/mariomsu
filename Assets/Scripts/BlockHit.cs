using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHit : MonoBehaviour
{
    public int maxHits = -1;
    public Sprite emptyBlock;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.transform.DotTest(transform, Vector2.up))
            {

            }
        }
    }
    private void Hit()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        maxHits--;

        if (maxHits == 0 )
        {
            spriteRenderer.sprite = emptyBlock;
        }

        StartCoroutine(Animate());
    }
    private IEnumerator Animate()
    {

    }
}
