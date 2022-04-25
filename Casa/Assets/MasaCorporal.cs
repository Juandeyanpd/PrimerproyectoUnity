using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasaCorporal : MonoBehaviour
{
    public string nombreDeUsuario;
    public float altura;
    public float kilogramos;

    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("Mi nombre es: " + nombreDeUsuario);
        Debug.Log("Mi altura es: " + altura);
        Debug.Log("Mi peso es: " + kilogramos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
