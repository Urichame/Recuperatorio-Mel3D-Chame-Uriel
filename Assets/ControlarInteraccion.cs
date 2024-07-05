using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlarInteraccion : MonoBehaviour
{
    public GameObject PanelAdvertencia;
    public GameObject[] objetos;
    public InputField ingresoTexto;

    void Start()
    {
        desactivartodo();
        desactivarPanelAdvertencia();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void desactivarPanelAdvertencia()
    {
        PanelAdvertencia.SetActive(false);
    }

     void desactivartodo()
    {
        for(int i = 0; i < objetos.Length; i ++)
        {
            objetos[i].SetActive(false);
        }
    }

    public void OnAceptarClick()
    {
        if(ingresoTexto.text == "")
        {
            PanelAdvertencia.SetActive(true);

        }
    }

    public void volverInicio()
    {
        PanelAdvertencia.SetActive(false);
    }

    public void numeroDelInput()
    {

    }
}
