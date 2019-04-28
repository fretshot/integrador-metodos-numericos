using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class metodos_numericos : MonoBehaviour{

    public TextMeshProUGUI textoCronometro;
    public TextMeshProUGUI textoNombreMetodo;

    public TMP_InputField FieldX,fieldX1, fieldX2, fieldX3, fieldX4, fieldY1, fieldY2, fieldY3, fieldY4, fieldGx,fieldGxCPU;

    public GameObject iconGood;
    public GameObject iconBad;

    public Button btnValidar;
    public Button btnVerRespuesta;
    public Button btnRendirse;
    public Button btnNoAplicaElMetodo;

    float x, x1, x2, x3, x4, y1, y2, y3, y4;
    float startingTime = 180f;
    float currentTime;
    float gx;

    bool aplicaMetodo;

    int opcion;

    private void OnEnable() {

        btnNoAplicaElMetodo.onClick.AddListener(delegate {

            btnVerRespuesta.interactable = false;
            btnRendirse.interactable = false;
            btnValidar.interactable = false;
            btnNoAplicaElMetodo.interactable = false;

            if (aplicaMetodo == false) {
                //Respuesta correcta
                fieldGx.text = "No aplica el método";
                iconGood.SetActive(true);
                Invoke("ganar", 3);
            } else {
                //Respuesta incorrecta
                fieldGx.text = "No aplica el método";
                iconBad.SetActive(true);
                Invoke("perder", 3);
            }

        });

        btnVerRespuesta.onClick.AddListener(delegate {
            fieldGxCPU.gameObject.SetActive(true);
            fieldGxCPU.text = gx.ToString("0.0000000");
            btnVerRespuesta.interactable = false;
            btnRendirse.interactable = true;
            btnValidar.interactable = false;
            btnNoAplicaElMetodo.interactable = false;
        });

        btnRendirse.onClick.AddListener(delegate {
            //do something
        });

        btnValidar.onClick.AddListener(delegate {
            if (fieldGx.text.Contains(gx.ToString())) {
                //Respuesta correcta
                iconGood.SetActive(true);
                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = false;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;
                Invoke("ganar", 3);
            } else {
                //Respuesta incorrecta
                iconBad.SetActive(true);
                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = false;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;
                Invoke("perder", 3);
            }
        });

        iconGood.SetActive(false);
        iconBad.SetActive(false);
        fieldGxCPU.gameObject.SetActive(false);

        btnVerRespuesta.interactable = true;
        btnRendirse.interactable = true;
        btnValidar.interactable = true;
        btnNoAplicaElMetodo.interactable = true;

        fieldGx.text = "";

        currentTime = startingTime;

        inicializarDatos();

        opcion = UnityEngine.Random.Range(1, 5); // No incluye el  5, el rango es de 1 a 4

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

        x = UnityEngine.Random.Range(1.0f, 3.0f);

        x1 = UnityEngine.Random.Range(1.0f, 1.5f);
        x2 = UnityEngine.Random.Range(1.5f, 2.0f);
        x3 = UnityEngine.Random.Range(2.0f, 2.5f);
        x4 = UnityEngine.Random.Range(2.5f, 3.0f);

        y1 = UnityEngine.Random.Range(1.0f, 2.5f);
        y2 = UnityEngine.Random.Range(2.5f, 3.0f);
        y3 = UnityEngine.Random.Range(3.0f, 3.5f);
        y4 = UnityEngine.Random.Range(3.5f, 4.0f);

        FieldX.text = x.ToString("0.00");

        fieldX1.text = x1.ToString("0.00");
        fieldX2.text = x2.ToString("0.00");
        fieldX3.text = x3.ToString("0.00");
        fieldX4.text = x4.ToString("0.00");

        fieldY1.text = y1.ToString("0.00");
        fieldY2.text = y2.ToString("0.00");
        fieldY3.text = y3.ToString("0.00");
        fieldY4.text = y4.ToString("0.00");
    }

    float factorial(float n) {
        int factorial = 1;
        for (int i = 1; i <= n; i++) {
            factorial *= i;
        }
        return factorial;
    }

    void ganar() {
        
        NotificationCenter.DefaultCenter().PostNotification(this, "respuestaCorrecta");  
    }

    void perder() {
        NotificationCenter.DefaultCenter().PostNotification(this, "respuestaInorrecta");
    }


    // =========================== Métodos numericos ========================= //


    // NEWTON HACIA ADELANTE
    private void newtonHaciaAdelante() {

        textoNombreMetodo.text = "Newton hacia adelante";

        float[] xi = {x1, x2, x3, x4};
        float[] yi = {y1, y2, y3, y4};

        float h1 = Math.Abs(xi[0] - xi[1]);
        float h2 = Math.Abs(xi[2] - xi[1]);
        float h3 = Math.Abs(xi[3] - xi[2]);

        if (h1 == h2 && h1 == h3 && h2 == h3 ) {
            aplicaMetodo = true;
        } else {
            aplicaMetodo = false;
        }

        float s = (x - xi[0]) / h1;
        float s0 = 1;
        float s1 = s;
        float s2 = (s * (s - 1)) / factorial(2);
        float s3 = (s * (s - 1) * (s - 2)) / factorial(3);
        float s4 = (s * (s - 1) * (s - 2) * (s - 3)) / factorial(4);

        //Primera diferencia D'f(xi)
        float d1_1 = (yi[1] - yi[0]);
        float d1_2 = (yi[2] - yi[1]);
        float d1_3 = (yi[3] - yi[2]);

        //Segunda diferencia D''f(xi)
        float d2_1 = (d1_2 - d1_1);
        float d2_2 = (d1_3 - d1_2);

        //Tercera diferencia D'''f(xi)
        float d3_1 = (d2_2 - d2_1);

        gx = (yi[0] * s0) + (d1_1 * s1) + (d2_1 * s2) + (d3_1 * s3);

        Debug.Log("Newton hacia adelante: g(x) = "+gx);

    }

    // NEWTON HACIA ATRAS
    private void newtonHaciaAtras() {

        textoNombreMetodo.text = "Newton hacia atrás";

        float[] xi = { x1, x2, x3, x4 };
        float[] yi = { y1, y2, y3, y4 };

        float h1 = Math.Abs(xi[0] - xi[1]);
        float h2 = Math.Abs(xi[2] - xi[1]);
        float h3 = Math.Abs(xi[3] - xi[2]);


        if (h1 == h2 && h1 == h3 && h2 == h3) {
            aplicaMetodo = true; 
        } else {
            aplicaMetodo = false;
        }

        float s = (x - xi[3]) / h1;
        float s0 = 1;
        float s1 = s;
        float s2 = (s * (s + 1)) / factorial(2);
        float s3 = (s * (s + 1) * (s + 2)) / factorial(3);
        float s4 = (s * (s + 1) * (s + 2) * (s + 3)) / factorial(4);

        //Primera diferencia D'f(xi)
        float d1_1 = (yi[1] - yi[0]);
        float d1_2 = (yi[2] - yi[1]);
        float d1_3 = (yi[3] - yi[2]);

        //Segunda diferencia D''f(xi)
        float d2_1 = (d1_2 - d1_1);
        float d2_2 = (d1_3 - d1_2);

        //Tercera diferencia D'''f(xi)
        float d3_1 = (d2_2 - d2_1);

        gx = yi[3] * s0 + (d1_3 * s1) + (d2_2 * s2) + (d3_1 * s3);

        Debug.Log("Newton hacia atrás: g(x) = " + gx);

    }

    private void newtonDiferenciasDivididas() {
        textoNombreMetodo.text = "Newton diferencias divididas";

        aplicaMetodo = true;
        
    }

    private void laGrange() {
        textoNombreMetodo.text = "LaGrange";

        aplicaMetodo = true;

        float[] xi = { x1, x2, x3, x4 };
        float[] yi = { y1, y2, y3, y4 };

        float a = (yi[0] * (x - xi[1]) * (x - xi[2]) * (x - xi[3])) / ((xi[0] - xi[1]) * (xi[0] - xi[2]) * (xi[0] - xi[3]));
        float b = (yi[1] * (x - xi[0]) * (x - xi[2]) * (x - xi[3])) / ((xi[1] - xi[0]) * (xi[1] - xi[2]) * (xi[1] - xi[3]));
        float c = (yi[2] * (x - xi[0]) * (x - xi[1]) * (x - xi[3])) / ((xi[2] - xi[0]) * (xi[2] - xi[1]) * (xi[2] - xi[3]));
        float d = (yi[3] * (x - xi[0]) * (x - xi[1]) * (x - xi[2])) / ((xi[3] - xi[0]) * (xi[3] - xi[1]) * (xi[3] - xi[2]));

        gx = a + b + c + d;

        Debug.Log("Lagrange: g(x) = "+gx);

    }

}
