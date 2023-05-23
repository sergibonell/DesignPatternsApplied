using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinCollecting : MonoBehaviour
{
    [SerializeField] UnityEvent winEvent;
    int n = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            if (++n == 3)
                winEvent.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
