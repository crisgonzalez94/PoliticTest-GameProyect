using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pregunta : MonoBehaviour{

    public int numero;
    public string enunciado;
    public string respuestaA;
    public string respuestaB;
    public string respuestaC;

    
    public pregunta(int num , string enun , string respA , string respB ,string respC ){

        numero = num;
        enunciado = enun;
        
        //Respuestas
        respuestaA = respA;
        respuestaB = respB;
        respuestaC = respC;

    }
}
