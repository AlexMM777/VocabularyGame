using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorsScript : MonoBehaviour
{
    [SerializeField] private GameObject DoorAudio;
    [SerializeField] private GameObject DeadAudio;

    [SerializeField] private Animator AnimationControllerL;
    [SerializeField] private Animator AnimationControllerR;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Correct"))
        {
            AnimationControllerL.SetBool("DoorOpenL", true);
        }

        if (other.CompareTag("Correct"))
        {
            AnimationControllerR.SetBool("DoorOpenR", true);
        }

        if (other.CompareTag("Correct"))
        {
            DoorAudio.SetActive(false);
            DoorAudio.SetActive(true);
        }

        if (other.CompareTag("Wrong"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
    }
}