using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Añadir el scene managment (es para administrar escenas)*/
using UnityEngine.SceneManagement;

public class CambiarScena : MonoBehaviour
{
    //Funcion para pasar de la escena principal a las preguntas
    public void cambiarScena(string scena){
        SceneManager.LoadScene(scena);
    }
    
}
