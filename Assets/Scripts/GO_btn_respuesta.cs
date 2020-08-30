using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_btn_respuesta : MonoBehaviour
{
    
     //Añadir el script de txt_pregunta
    public GO_txt_pregunta script_txt_pregunta;


    public void siguientePregunta(){
        script_txt_pregunta.num_pregunta++;
    }

    //Esta funcion indicica que se ha presionado este boton
    //en la pregunta , este sera almacenado en un array para
    //luego ser evaluado.
    public void elegirOpcion(int opcion , int pregunta){

    }
}
