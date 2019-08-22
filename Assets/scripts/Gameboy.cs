using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gameboy : MonoBehaviour
{
    [SerializeField]
    Text message;
    private void OnTriggerStay(Collider other)
    {
        message.text = "Gameboy: Consola viejita chila";
    }
    private void OnTriggerExit(Collider other)
    {
        message.text = "";
    }
}
