using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    // Start is called before the first frame update
    public int value = 1;
    private bool currentlyTriggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player2"))
        {
            if (!currentlyTriggered)
            {
                currentlyTriggered = true;
                Destroy(gameObject);
                ScoreManager.instance.ChangeScore(value);
                Debug.Log("+1");
            }
        }
    }
}
