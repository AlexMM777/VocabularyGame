using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DED : MonoBehaviour
{
    [SerializeField] private GameObject DeadAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wrong"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
            DeadAudio.SetActive(false);
            DeadAudio.SetActive(true);
        }

        if (other.CompareTag("Correct"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
    }
 }
