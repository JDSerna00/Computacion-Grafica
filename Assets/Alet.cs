using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alet : MonoBehaviour
{
    Button tap;

    private void Start()
    {
        tap = GetComponent<Button>();
        tap.onClick.AddListener(OnTap);
    }

    private void OnTap()
    {
        // Aquí puedes definir lo que sucede al hacer clic en el botón
        Debug.Log("Botón Alet presionado");
        // Por ejemplo, podrías cambiar el color del botón
        Destroy(gameObject); // Destruye el objeto al hacer clic
    }
}
