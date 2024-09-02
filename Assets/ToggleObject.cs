using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToggleObject : MonoBehaviour
{
    public GameObject objectToToggle; // este es el objeto que quieres activar/desactivar
    public Toggle toggle; // este es el Toggle que controlará el objeto
    public TextMeshProUGUI textMeshProText;
    public Vector3 objectPosition; // Esta es la variable para la posición del objeto


    // Variable personalizable
    public string text = "";

    void Start()
    {
        // Establecer la función ToggleControl como callback para el evento onValueChanged del Toggle
        toggle.onValueChanged.AddListener(ToggleControl);
    }

    // Función que activará o desactivará el objeto
    void ToggleControl(bool toggleStatus)
    {
        objectToToggle.SetActive(toggleStatus);
        objectToToggle.transform.position = objectPosition;
        textMeshProText.text = text; // Utilizar la variable de cadena personalizable
    }
}
