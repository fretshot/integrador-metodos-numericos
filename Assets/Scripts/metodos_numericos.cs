using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class metodos_numericos : MonoBehaviour{

    public TextMeshProUGUI textoCronometro;
    public TextMeshProUGUI textoNombreMetodo;

    public TMP_InputField fieldX1,fieldX2,fieldX3,fieldX4,fieldY1,fieldY2,fieldY3,fieldY4,FieldX;

    float startingTime = 180f; //420 segundos ~ 7 minutos
    float currentTime;

    int opcion;

    void Start(){

    }


    private void OnEnable() {

        currentTime = startingTime;
        inicializarDatos();
        opcion = Random.Range(1, 5); // No incluye el  5, el rango es de 1 a 4

        switch (opcion) {
            case 1:
                newtonHaciaAdelante();
                break;
            case 2:
                newtonHaciaAtras();
                break;
            case 3:
                newtonDiferenciasDivididas();
                break;
            case 4:
                laGrange();
                break;
        }
    }


    void Update(){
        stopwatch();
    }

    void stopwatch() {
        currentTime -= 1 * Time.deltaTime;
        string minutes = Mathf.Floor(currentTime / 60).ToString("00");
        string seconds = (currentTime % 60).ToString("00");
        //string fraction = ((currentTime * 100) % 100).ToString("000");
        textoCronometro.text = "Tiempo: " + minutes + ":" + seconds;
        //Debug.Log("Time Left: " + minutes + ":" + seconds + ":" + fraction);
        if (currentTime <= 0) {
            currentTime = 0;
            // Se acaba el tiempo.
            NotificationCenter.DefaultCenter().PostNotification(this, "playerLost");
        }
    }



    private void inicializarDatos() {

        int x = Random.Range(1, 7);

        int x1 = Random.Range(1, 7);
        int x2 = Random.Range(1, 7);
        int x3 = Random.Range(1, 7);
        int x4 = Random.Range(1, 7);

        int y1 = Random.Range(1, 7);
        int y2 = Random.Range(1, 7);
        int y3 = Random.Range(1, 7);
        int y4 = Random.Range(1, 7);

        FieldX.text = x.ToString();

        fieldX1.text = x1.ToString();
        fieldX2.text = x2.ToString();
        fieldX3.text = x3.ToString();
        fieldX4.text = x4.ToString();

        fieldY1.text = y1.ToString();
        fieldY2.text = y2.ToString();
        fieldY3.text = y3.ToString();
        fieldY4.text = y4.ToString();
    }


    // =========================== Métodos numericos ========================= //

    private void newtonHaciaAdelante() {
        textoNombreMetodo.text = "Newton hacia adelante";
        Debug.Log("Newton hacia adelante");
        //Aqui empiezan los problemas
        //NotificationCenter.DefaultCenter().PostNotification(this, "respuestaCorrecta");
        //NotificationCenter.DefaultCenter().PostNotification(this, "respuestaInorrecta");
    }

    private void newtonHaciaAtras() {
        textoNombreMetodo.text = "Newton hacia atrás";
        Debug.Log("Newton hacia atrás");
       
    }

    private void newtonDiferenciasDivididas() {
        textoNombreMetodo.text = "Newton diferencias divididas";
        Debug.Log("Newton diferencias divididas");
    }

    private void laGrange() {
        textoNombreMetodo.text = "LaGrange";
        Debug.Log("LaGrange");
    }

}
