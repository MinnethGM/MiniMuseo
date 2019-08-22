using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bomber : MonoBehaviour
{
    [SerializeField]
    Text message;
    private void OnTriggerStay(Collider other)
    {
        message.text = "Bomberman: Personaje de Videojuego Bomberman";
    }
    private void OnTriggerExit(Collider other)
    {
        message.text = "";
    }
}
