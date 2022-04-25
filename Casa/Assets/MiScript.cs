using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiScript : MonoBehaviour
{
    public string mensajeBienvenida;
    public string miNombre;
    public string nombreDeAmigo;
    public int edadMía;
    public int edadAmigo;
    public int edadSuma;
    public bool estaArriba;

    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("Hola Mundo mi nombre es: " + miNombre);
        Debug.Log("Su nombres es: " + nombreDeAmigo);
        Debug.Log("Mi edad es: " + edadMía);
        Debug.Log("Su edad es: " + edadAmigo);
        Debug.Log("La suma es: " + edadSuma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnJump()
    {

    }
}
