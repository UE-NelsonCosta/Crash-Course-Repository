using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryEndArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yaaay we reached the end!");

        StartCoroutine(RestartAfter2Seconds());
    }

    private IEnumerator RestartAfter2Seconds()
    {
        yield return new WaitForSeconds(2.0f);

        SceneManager.LoadScene("4. GeometryDashClone");
    }
}
