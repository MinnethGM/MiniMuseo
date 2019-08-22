using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hand : MonoBehaviour
{
    [SerializeField]
    Text message;
    private void OnTriggerStay(Collider other)
    {
        message.text = "Yoshi: Personaje del Videojuego Mario Bros";
    }
    private void OnTriggerExit(Collider other)
    {
        message.text = "";
    }
}