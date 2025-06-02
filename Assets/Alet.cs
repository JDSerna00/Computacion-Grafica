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
        // Aqu� puedes definir lo que sucede al hacer clic en el bot�n
        Debug.Log("Bot�n Alet presionado");
        // Por ejemplo, podr�as cambiar el color del bot�n
        Destroy(gameObject); // Destruye el objeto al hacer clic
    }
}
