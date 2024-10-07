using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DectetorPlayer : MonoBehaviour
{
    // Variables publicas
    public float timeToFinish;
    public UnityEvent OnDectetorPlayer, AfterTime;

    private void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("Player"))
        {
            OnDectetorPlayer.Invoke();
            GetComponent<Collider>().enabled = false;

            StartCoroutine(AfterTimeEvent());
        }
    }

    IEnumerator AfterTimeEvent()
    {
        yield return new WaitForSeconds(timeToFinish);
        AfterTime.Invoke();
        gameObject.SetActive(false);
    }



}
