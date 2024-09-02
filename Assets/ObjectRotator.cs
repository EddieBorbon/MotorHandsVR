using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectRotator : MonoBehaviour
{
    public Slider rotationSlider;
    public float rotationSpeed = 50f;

    private void Start()
    {
        // Asigna el método OnSliderValueChanged al evento onValueChanged del Slider
        rotationSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        // Obtiene el valor del Slider y aplica la rotación al objeto en el eje Y
        float rotationAmount = value * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationAmount, 0f);
    }
}
