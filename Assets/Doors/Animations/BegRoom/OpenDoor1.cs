using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
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

        if (other.CompareTag("Wrong"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
    }
}