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
    public TMP_InputField fieldXi,fieldXiCPU,fieldEcuacion;

    public GameObject p1IconGood;
    public GameObject p1IconBad;
    public GameObject p2IconGood;
    public GameObject p2IconBad;

    public GameObject screenP1;
    public GameObject screenP2;
    public GameObject screenP3;
    public GameObject screenP4;

    public Button btnValidar;
    public Button btnVerRespuesta;
    public Button btnRendirse;
    public Button btnNoAplicaElMetodo;

    float x, x1, x2, x3, x4, y1, y2, y3, y4;
    float startingTime = 180f;
    float currentTime;

    float gx;
    float xi;

    bool aplicaMetodo;

    int opcion;

    private void OnEnable() {

        btnNoAplicaElMetodo.onClick.AddListener(delegate {

            if (screenP1.activeSelf) {

                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = false;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;

                if (aplicaMetodo == false) {
                    //Respuesta correcta
                    fieldGx.text = "No aplica el método";
                    p1IconGood.SetActive(true);
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    fieldGx.text = "No aplica el método";
                    p1IconBad.SetActive(true);
                    Invoke("perder", 3);
                }

            }

            if (screenP2.activeSelf) {

                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = false;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;

                if (aplicaMetodo == false) {
                    //Respuesta correcta
                    fieldXi.text = "No aplica el método";
                    p2IconGood.SetActive(true);
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    fieldXi.text = "No aplica el método";
                    p2IconBad.SetActive(true);
                    Invoke("perder", 3);
                }
            }

            if (screenP3.activeSelf) {

            }

            if (screenP4.activeSelf) {

            }

            

        });

        btnVerRespuesta.onClick.AddListener(delegate {

            if (screenP1.activeSelf) {

                fieldGxCPU.gameObject.SetActive(true);
                fieldGxCPU.text = gx.ToString("0.0000000");
                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = true;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;
            }

            if (screenP2.activeSelf) {

                fieldXiCPU.gameObject.SetActive(true);
                fieldXiCPU.text = xi.ToString("0.0000000");
                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = true;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;
            }

            if (screenP3.activeSelf) {

            }

            if (screenP4.activeSelf) {

            }
            
        });

        btnRendirse.onClick.AddListener(delegate {

            if (screenP1.activeSelf) {

            }

            if (screenP2.activeSelf) {

            }

            if (screenP3.activeSelf) {

            }

            if (screenP4.activeSelf) {

            }
            
        });

        btnValidar.onClick.AddListener(delegate {

            if (screenP1.activeSelf) {

                if (fieldGx.text.Contains(gx.ToString())) {
                    //Respuesta correcta
                    p1IconGood.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    p1IconBad.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("perder", 3);
                }

            }

            if (screenP2.activeSelf) {

                if (fieldXi.text.Contains(xi.ToString())) {
                    //Respuesta correcta
                    p2IconGood.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    p2IconBad.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("perder", 3);
                }
            }

            if (screenP3.activeSelf) {

            }

            if (screenP4.activeSelf) {

            }
            
        });

        p1IconGood.SetActive(false);
        p1IconBad.SetActive(false);
        fieldGxCPU.gameObject.SetActive(false);

        p2IconGood.SetActive(false);
        p2IconBad.SetActive(false);
        fieldXiCPU.gameObject.SetActive(false);

        btnVerRespuesta.interactable = true;
        btnRendirse.interactable = true;
        btnValidar.interactable = true;
        btnNoAplicaElMetodo.interactable = true;

        fieldGx.text = "";
        fieldXi.text = "";

        currentTime = startingTime;

        inicializarDatos();

        //opcion = UnityEngine.Random.Range(1, 5); // No incluye el  5, el rango es de 1 a 4

        opcion = 8;

        switch (opcion) {
            case 1:
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                newtonHaciaAdelante();
                break;
            case 2:
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                newtonHaciaAtras();
                break;
            case 3:
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                newtonDiferenciasDivididas();
                break;
            case 4:
                laGrange();
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                break;
            case 5:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                puntoFijo();
                break;
            case 6:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                newtonRaphson();
                break;
            case 7:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                falsaPosicion();
                break;
            case 8:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                secante();
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

    // NEWTON DIFERENCIAS DIVIDIDAS
    private void newtonDiferenciasDivididas() {
        textoNombreMetodo.text = "Newton diferencias divididas";

        aplicaMetodo = true;

        float[] xi = { x1, x2, x3, x4 };
        float[] yi = { y1, y2, y3, y4 };

        //Primera diferencia D'f(xi)
        float d1_1 = (yi[1] - yi[0]) / (xi[1] - xi[0]);
        float d1_2 = (yi[2] - yi[1]) / (xi[2] - xi[1]);
        float d1_3 = (yi[3] - yi[2]) / (xi[3] - xi[2]);

        //Segunda diferencia D''f(xi)
        float d2_1 = (d1_2 - d1_1) / (xi[2] - xi[0]);
        float d2_2 = (d1_3 - d1_2) / (xi[3] - xi[1]);

        //Tercera diferencia D'''f(xi)
        float d3_1 = (d2_2 - d2_1) / (xi[3] - xi[0]);

        gx = yi[0] + (d1_1 * (x - xi[0])) + (d2_1 * (x - xi[0]) * (x - xi[1])) + (d3_1 * (x - xi[0]) * (x - xi[1]) * (x - xi[2]));

        Debug.Log("Newton hacia atrás: g(x) = " + gx);
    }

    // LAGRANGE
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

    //PUNTO FIJO
    private void puntoFijo() {

        textoNombreMetodo.text = "Punto fijo";
        aplicaMetodo = true;

        float tmp = 0;
        float e = 0;

        while (true) {

            xi = (2 * (float)Math.Pow(tmp, 2) - 2) / 6;

            fieldEcuacion.text = "x = ( "+2+"x^2 - "+2+" ) / "+6+"";

            e = Math.Abs(xi - tmp);

            tmp = xi;


            if (e.ToString("0.0000000").StartsWith("0.00000")) {
                Debug.Log("xi: " + xi.ToString("0.0000000"));
                break;
            }
        }

    }


    //NEWTON RAPHSON
    private void newtonRaphson() {

        textoNombreMetodo.text = "Newton - Raphson";
        aplicaMetodo = true;

        float xi = 0;
        float tmp = 1;
        float e = 0;

        while (true) {

            xi = tmp - ((float)(Math.Exp(3 * tmp)) - 4) / (3 * (float)Math.Exp(3 * tmp)); // e^3x - 4

            fieldEcuacion.text = "f(x) = e^3x -4";

            e = Math.Abs(xi - tmp);

            

            tmp = xi;

            if (e.ToString("0.0000000").StartsWith("0.00000")) {
                Debug.Log("xi: " + xi.ToString("0.0000000"));
                break;
            }
        }
    }

    //FALSA POSICION
    private void falsaPosicion() {

        textoNombreMetodo.text = "Falsa posición";
        aplicaMetodo = true;

        float tmp = 0;
        float e = 0;

        float a = 0;
        float b = 1;

        float fb = 16;
        float fa = -3;

        while (true) {

            a = xi;

            //fa= 2*(math.pow(a,2))- (6*a) -2 # Para 2x^2 - 6x - 2

            fa = (float)(Math.Exp(3 * a)) - 4; // Para e^3x - 4
            xi = a - ((fa * (b - a)) / (fb - fa));

            fieldEcuacion.text = "f(x) = e^3x - 4";

            e = Math.Abs(xi - tmp);

            tmp = xi;

            if (e.ToString("0.0000000").StartsWith("0.000")) {
                Debug.Log("xi: " + xi.ToString("0.0000000"));
                break;
            }
        }

    }

    // SECANTE
    private void secante() {
        textoNombreMetodo.text = "Secante";
        aplicaMetodo = true;

        fieldEcuacion.text = "f(x) = e^3x - 4";

        float temp1 = 0;
        float ftemp1 = (float)(Math.Exp(3 * temp1)) - 4;

        float temp2 = 1;
        float ftemp2 = (float)(Math.Exp(3 * temp2)) - 4;

        float fxi;

        float e;

        while (true) {
            xi = temp2 - ((ftemp2 * (temp2 - temp1)) / (ftemp2 - ftemp1));
            fxi = (float)(Math.Exp(3 * xi)) - 4;
            e = Math.Abs(xi - temp2);
            temp1 = temp2;
            ftemp1 = ftemp2;
            temp2 = xi;
            ftemp2 = fxi;

            if (e.ToString("0.0000000").StartsWith("0.000")) {
                Debug.Log("xi: " + xi.ToString("0.0000000"));
                break;
            }
        }
    }

}
