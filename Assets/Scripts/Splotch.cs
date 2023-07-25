using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splotch : MonoBehaviour
{
    public ColorCollect cc;
    public string colorTag;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other);
        if(other.CompareTag("Player")) {
            //audioSource.Play();
            Debug.Log("color collected");
            //Color objectColor = objectRenderer.material.color;
            //objectColor.a = 0f;
            //objectRenderer.material.color = objectColor;
            colorTag = gameObject.tag;
            cc.CollectThisColor(colorTag);
            Destroy(gameObject,.2f);
        }
    }

}
