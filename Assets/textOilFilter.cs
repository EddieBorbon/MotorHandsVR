using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class textOilFilter : MonoBehaviour
{
    public TextMeshProUGUI textMeshProText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void changeText(){
        textMeshProText.text = "¡Hola! Este es el nuevo texto.";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
