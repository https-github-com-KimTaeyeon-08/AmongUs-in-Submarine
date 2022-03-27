using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCCtrl : MonoBehaviour
{
    public Sprite[] idles, deads;

    SpriteRenderer sr;

    int rand;
    float rand_npc;
    public float moveSpeed = 0.1f;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        rand = Random.Range(0, 5);
        sr.sprite = idles[rand];
    }

    // 죽은 이미지
    public void Dead()
    {

        sr.sprite = deads[rand];

        sr.sortingOrder = -1;
    }
    public void Update()
    {
        moveControl();
    }
    void moveControl()
    {
        rand_npc = Random.Range(-0.5f,0.5f);
        float distance = moveSpeed * 0.3f;
        for (int i = 0; i < 3; i++)
        {
            sr.gameObject.transform.Translate(distance * rand_npc, 0, 0);
            sr.gameObject.transform.Translate(0, distance * rand_npc, 0);
            sr.gameObject.transform.Translate(0, 0, distance * rand_npc);
        }
    }
}