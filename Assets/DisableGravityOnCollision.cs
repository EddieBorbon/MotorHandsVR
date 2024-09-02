using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGravityOnCollision : MonoBehaviour
{                
    private Rigidbody rb;
    public FixedJoint fixedJoint;
    public GameObject targetObject;

    private void Start()
    {
        // Obtén el componente Rigidbody del objeto
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto ha colisionado con otro objeto
        if (other.gameObject == targetObject)
        {
            // Crea un nuevo FixedJoint si no existe
            if (fixedJoint == null)
            {
                // Crea un nuevo FixedJoint y asigna el objeto con el que se colisiona como punto de anclaje
                fixedJoint = gameObject.AddComponent<FixedJoint>();
                fixedJoint.connectedBody = targetObject.GetComponent<Rigidbody>();

                // Establece la posición del objeto encajado a la posición del objeto que colisionó
                gameObject.transform.position = targetObject.transform.position;
            }
        }
    }
}
