using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlarInteraccion : MonoBehaviour
{
    public GameObject PanelAdvertencia;
    public GameObject[] objetos;
    public InputField ingresoTexto;
    public int Index = -1;
    public int objetoElegido;
    //public int objetoAnterior;

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
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }

    public void OnAceptarClick()
    {

        desactivartodo(); 
        
         if (ingresoTexto.text == "")
        {
            PanelAdvertencia.SetActive(true);

        }
        objetoElegido = int.Parse(ingresoTexto.text);
        objetos[objetoElegido].SetActive(true);

       

        //objetoAnterior = int.Parse(ingresoTexto.text);
        //objetos[objetoAnterior].SetActive(false);
        
    }

    public void volverInicio()
    {
        PanelAdvertencia.SetActive(false);
    }
}