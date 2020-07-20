using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class CursorShow : MonoBehaviour
{
    [SerializeField] private GameObject Player;

    void OnTriggerEnter(Collider Dead)
    {
        if (Dead.CompareTag("Player"))
        {
            Player.GetComponent<FirstPersonController>().enabled = false;
            //LelToMakeMouseAppear
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

    }
}
