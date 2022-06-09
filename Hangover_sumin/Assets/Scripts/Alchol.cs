using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alchol : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.CompareTo("Player") == 0){
           // DataManager.Instace.score -= 1; //point minus later part
            gameObject.SetActive(false); //Screen Out
        }
    }
}
