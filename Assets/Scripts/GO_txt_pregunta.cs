using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Importar libreria para metodologias de la UI
using UnityEngine.UI;

public class GO_txt_pregunta : MonoBehaviour
{
    //Variables para los parametros del custionario
    public int num_pregunta;

    //Texto de la caja de pregunta
    public Text txt_pregunta;

    //texto caja numero de pregunta
    public Text txt_numPregunta;

    //Texto de los botones de respuesta
    public Text txt_btn_respuesta1;
    public Text txt_btn_respuesta2;
    public Text txt_btn_respuesta3;
    

    //

    //Variable de tipo pregunta (esta cambiara constantemente)
    public pregunta preguntaActual;


    // Start is called before the first frame update
    void Start(){
        num_pregunta = 1;
    }

    // Update is called once per frame
    void Update(){

        /*Este switch verifica por cual numero de pregunta estamos
        y en base a ello selecciona una o otra*/
        switch(num_pregunta){
            case 1:
                preguntaActual = new pregunta(
                    1 , 
                    "Algunos individuos y medios de comunicación difunden con facilidad opiniones equivocadas con objetivos cuestionables." ,
                    "Debe prohibirse la difusión de opiniones equivocadas cuyo objetivo sea manipular y/o influir en los demás.", 
                    "Debe prohibirse la realización de apologías de ideologías extremas." , 
                    "No debe haber censura de opiniones por parte del Estado en ningún caso"
                );
                break;
            case 2:
                preguntaActual = new pregunta(
                    2 , 
                    "La Iglesia realiza ciertas labores de carácter social. Por ello..." ,
                    "El Estado debe contribuir a la financiación de la Iglesia, y tener en cuenta sus valores a la hora de legislar.", 
                    "El Estado debe ser aconfesional, aunque puede contribuir a la financiación de la Iglesia para sostener su labor social en colegios concertados, centros de asistencia, etc..." , 
                    "La Iglesia debe autofinanciarse, y estar en igualdad de condiciones con cualquier otra asociación. El Estado debe permanecer laico."
                );
                break;
            case 3:
                preguntaActual = new pregunta(
                    3 , 
                    "La defensa del país corresponde a quienes prestan Servicio Militar en los ejércitos." ,
                    "El Servicio Militar debe ser obligatorio como forma de contribuir al bien común y/o a la formación de los jóvenes.", 
                    "El Sercicio Militar debe ser voluntario. Es el mejor modo de tener un ejército profesional y preparado para defender nuestros intereses y compromisos en el exterior." , 
                    "El Servicio Militar debería ser voluntario en caso de existir ejército, y de ser así, su naturaleza debería limitarse a sus funciones más esenciales de defensa."
                );
                break;
            case 4:
                preguntaActual = new pregunta(
                    4 , 
                    "Las relaciones sexuales entre adultos que consienten son un asunto de la esfera privada de las personas. Sin embargo..." ,
                    "Conductas como la homosexualidad, la poligamia o la prostitución deben prohibirse o estar fuertemente controladas.", 
                    "La prostitución debe prohibirse o estar fuertemente controlada." , 
                    "Las leyes no deben entrometerse en las relaciones sexuales entre adultos que consientan, en ningún caso."
                );
                break;
            case 5:
                preguntaActual = new pregunta(
                    5 , 
                    "Las drogas suponen un drama para muchas familias." ,
                    "El Estado debería combatir el tráfico de drogas con más medios y de un modo más eficaz.", 
                    "El uso de algunas de las drogas prohibidas actualmente debería ser legal, aunque debería controlarse su distribución." , 
                    "Deberían legalizarse las drogas, despenalizando su uso y liberalizando su distribución."
                );
                break;
            case 6:
                preguntaActual = new pregunta(
                    6 , 
                    "La toma de medidas preventivas puede suponer una mejora de la seguridad ciudadana. Sin embargo, en muchos casos éstas chocan con algunos derechos individuales, como el derecho a la intimidad." ,
                    "La seguridad de todos está por encima de los derechos de uno solo; Las fuerzas de seguridad del Estado no deben ver su función entorpecida porque un posible criminal se ampare en sus derechos individuales.", 
                    "Las leyes y el poder judicial deben establecer en qué casos se puede anteponer el uso de medidas preventivas de seguridad a ciertos derechos individuales y en qué casos no." , 
                    "El Estado no debe vulnerar ningún derecho individual por motivos de seguridad."
                );
                break;
            case 7:
                preguntaActual = new pregunta(
                    7 , 
                    "En ciertas instituciones, grupos o profesiones, existe disparidad entre el número de hombres y mujeres, o entre distintas razas o grupos sociales." ,
                    "Las cuotas obligatorias son el mejor instrumento para remediar las situaciones de discriminación histórica.", 
                    "Las ayudas para la integración o los beneficios fiscales a los grupos menos representados son el mejor instrumento para paliar la discriminación." , 
                    "Cualquier tipo de imposición o beneficio basado en criterios de sexo, raza o grupo social, viola el principio de igualdad ante la ley, y no debe ser impuesto por el Estado."
                );
                break;
            case 8:
                preguntaActual = new pregunta(
                    8 , 
                    "Las fronteras se utilizan para controlar la inmigración." ,
                    "Hay que limitar decididamente la entrada de nuevos inmigrantes y/o expulsar a aquellos que no se integren.", 
                    "El Estado debe regular la inmigración para permitir que los inmigrantes necesarios vengan de un modo legal." , 
                    "No debe haber diferencias de derechos en función del lugar de nacimiento o nacionalidad."
                );
                break;
            case 9:
                preguntaActual = new pregunta(
                    9 , 
                    "El Estado moderno suele ir aparejado al concepto de una nación." ,
                    "El Estado debe promover el sentimiento patriótico y defender la identidad nacional, cultura e idioma que le son propios.", 
                    "El Estado debe proteger y/o promover la cultura y el idioma que son propios de su nación." , 
                    "El Estado no debe intervenir en cuestiones tan personales como la identidad o la cultura. Cada ciudadano debe tener la libertad de usar el idioma que considere."
                );
                break;
            case 10:
                preguntaActual = new pregunta(
                    10 , 
                    "Una de las mayores amenazas para la civilización es el deterioro del Medio Ambiente." ,
                    "Las leyes deben obligar a contaminar menos imponiendo estrictas limitaciones de contaminantes.", 
                    "Hay que promover las energías limpias mediante incentivos a aquellos que contaminen menos y cargas a los que contaminan más." , 
                    "Se contaminaría menos si se estableciesen responsabilidades claras y derechos de propiedad bien definidos con respecto a la contaminación."
                );
                break;
            case 11:
                preguntaActual = new pregunta(
                    11 , 
                    "La importación de bienes del extranjero puede ser limitada por el Estado mediante diversos instrumentos, como los aranceles aduaneros, las prohibiciones, o ciertas regulaciones." ,
                    "El Estado debe limitar la entrada de productos de otros países para favorecer a los productores nacionales.", 
                    "El Estado debe limitar la entrada de productos del tercer mundo, ya que se producen con mano de obra barata." , 
                    "El Estado no debe limitar el comercio internacional. Éste debe ser libre y los aranceles deben reducirse o eliminarse."
                );
                break;
            case 12:
                preguntaActual = new pregunta(
                    12 , 
                    "Los impuestos son necesarios para sufragar los gastos del Estado." ,
                    "Los ricos deberían pagar más impuestos para aumentar las prestaciones y servicios del Estado.", 
                    "Los impuestos no deberían subir. Deben ser los justos y necesarios para sufragar los gastos del Estado." , 
                    "Los impuestos deberían reducirse, aunque para ello haya que recortar algunas prestaciones y servicios del Estado."
                );
                break;
            case 13:
                preguntaActual = new pregunta(
                    13 , 
                    "Las pensiones para la jubilación garantizan el bienestar cuando se llega a la tercera edad." ,
                    "Las pensiones de jubilación deben ser gestionadas por el Estado con un sistema público de contribuciones obligatorias (Seguridad Social).", 
                    "Las pensiones de jubilación deben estar garantizadas por el Estado, con algún tipo de modelo mixto que pueda conjugar un sistema público y planes privados." , 
                    "Las pensiones de jubilación son un asunto de ahorro y planificación individual. El Estado no debe exigir contribuciones obligatorias a un sistema público."
                );
                break;
            case 14:
                preguntaActual = new pregunta(
                    14 , 
                    "Los pobres y necesitados dependen de la solidaridad del resto de la sociedad." ,
                    "El Estado debe encargarse de eliminar o reducir la desigualdad y la pobreza en la sociedad.", 
                    "El Estado debe gestionar la ayuda y asistencia adecuada a los necesitados, independientemente de que las instituciones privadas de caridad puedan complementarla voluntariamente." , 
                    "Las instituciones privadas de caridad deben ser las principales canalizadoras de la solidaridad de la sociedad."
                );
                break;
            case 15:
                preguntaActual = new pregunta(
                    15 , 
                    "Algunas profesiones requieren una cierta cualificación para ejercerlas." ,
                    "Los sectores profesionales tienen que estar regulados por las leyes. El ejercicio de las profesiones cualificadas debe requerir de las oportunas licencias y permisos otorgadas en cada caso por el órgano competente del Estado.", 
                    "Los sectores profesionales deben estar regulados por organismos independientes, como los colegios profesionales. Los profesionales cualificados deben colegiarse en ellos, ya que su supervisión garantiza la calidad de sus servicios." , 
                    "Las licencias, permisos y colegios profesionales son trabas innecesarias. El ejercicio de cualquier profesión debe ser libre para cualquier persona cualificada."
                );
                break;
            case 16:
                preguntaActual = new pregunta(
                    16 , 
                    "Los sindicatos representan los intereses de los trabajadores." ,
                    "Los sindicatos son esenciales para proteger los derechos de los trabajadores. El Estado debe proveerles financiación y atribuírles funciones especiales en la legislación laboral.", 
                    "Los sindicatos, como representantes de los trabajadores, deben contar con ciertas funciones especiales en la legislación laboral, pero no deben ser financiados por el Estado." , 
                    "Los sindicatos deben regirse por las normas aplicables a cualquier otra asociación, y no recibir financiación pública o atribuírseles funciones especiales."
                );
                break;
            case 17:
                preguntaActual = new pregunta(
                    17 , 
                    "La cobertura médica es una necesidad eventual para todas las personas." ,
                    "El Estado debe gestionar centros médicos de carácter público, y financiarlos mediante contribuciones a un seguro médico público de carácter obligatorio (Seguridad Social).", 
                    "El Estado debe garantizar el acceso universal a la sanidad mediante centros con algún tipo de financiación pública, sean gestionados o no por el Estado." , 
                    "Gestionar centros médicos no debe ser una función del Estado. Los centros médicos deben ser privados, y los ciudadanos ser libres de contratar el seguro médico que prefieran."
                );
                break;
            case 18:
                preguntaActual = new pregunta(
                    18 , 
                    "El Banco Central y el sistema bancario, formado por los bancos comerciales, son los que ponen en circulación el dinero de curso legal." ,
                    "Tanto el Banco Central como los bancos comerciales deben ser públicos y atender a las necesidades sociales.", 
                    "El Banco Central tiene una función esencial regulando la economía, por lo que debe ser independiente y supervisar a los bancos comerciales." , 
                    "El Banco Central debería reducir sus competencias, y los bancos comerciales ser todos de carácter privado."
                );
                break;
            case 19:
                preguntaActual = new pregunta(
                    19 , 
                    "Las grandes superficies tienen ciertas ventajas competetitivas frente al pequeño comercio tradicional." ,
                    "Algunas Grandes Superficies tienen prácticas de competencia abusivas. Deberían imponérseles condiciones más restrictivas de funcionamiento, o cerrarse.", 
                    "Se deben corregir algunas ventajas competitivas de las Grandes Superfies, regulando ciertas materias como sus horarios y días de apertura, o el descuento máximo que pueden aplicar." , 
                    "Las Grandes Superficies son empresas como cualquier otra. Tienen derecho a competir libremente en el mercado, sin restricciones en sus horarios o precios."
                );
                break;
            case 20:
                preguntaActual = new pregunta(
                    20 , 
                    "Los contratos laborales vinculan a empresarios y trabajadores en sus obligaciones." ,
                    "La legislación sobre contratos laborales debería restringir más el despido, así como limitar más el empleo precario y garantizar una mayor protección al trabajador.", 
                    "La legislación sobre contratos laborales debe siempre mantener una protección especial al trabajador, protegiéndole frente al despido y el empleo precario." , 
                    "Los contratos laborales deben gozar de más libertad de cláusulas entre las partes. La legislación debería interferir menos en materias puramente contractuales, como su duración o causas de rescisión."
                );
                break;
        }

        txt_pregunta.text = preguntaActual.enunciado;
        txt_numPregunta.text = num_pregunta.ToString() + "/20";
        txt_btn_respuesta1.text = preguntaActual.respuestaA;
        txt_btn_respuesta2.text = preguntaActual.respuestaB;
        txt_btn_respuesta3.text = preguntaActual.respuestaC;

    }

    
}