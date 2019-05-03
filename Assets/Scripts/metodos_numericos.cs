using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class metodos_numericos : MonoBehaviour {

    public TextMeshProUGUI textoCronometro;
    public TextMeshProUGUI textoNombreMetodo;

    public TMP_InputField FieldX, fieldX1, fieldX2, fieldX3, fieldX4, fieldY1, fieldY2, fieldY3, fieldY4, fieldGx, fieldGxCPU;
    public TMP_InputField fieldXi, fieldXiCPU, fieldEcuacion;
    public TMP_InputField fieldX, fieldY, fieldZ, fieldXCPU, fieldYCPU, fieldZCPU;

    public TMP_InputField FieldEcuacion, fieldXi1, fieldXi2, fieldXi3, fieldXi4, fieldYi1, fieldYi2, fieldYi3, fieldYi4;
    public TMP_InputField fieldGx1, fieldGx2, fieldGx3, fieldGx4;
    public TMP_InputField fieldGx1CPU, fieldGx2CPU, fieldGx3CPU, fieldGx4CPU;

    public TMP_InputField fieldEcuacionP5, fieldLimites, fieldN, fieldI, fieldICPU;

    public GameObject p1IconGood;
    public GameObject p1IconBad;
    public GameObject p2IconGood;
    public GameObject p2IconBad;
    public GameObject p3IconGood;
    public GameObject p3IconBad;
    public GameObject p4IconGood;
    public GameObject p4IconBad;
    public GameObject p5IconGood;
    public GameObject p5IconBad;

    public GameObject screenP1;
    public GameObject screenP2;
    public GameObject screenP3;
    public GameObject screenP4;
    public GameObject screenP5;

    public Button btnValidar;
    public Button btnVerRespuesta;
    public Button btnRendirse;
    public Button btnNoAplicaElMetodo;

    float x, x1, x2, x3, x4, y1, y2, y3, y4;
    float startingTime = 180f;
    float currentTime;

    float gx;

    float gx1, gx2, gx3, gx4;

    float xi;

    float rx;
    float ry;
    float rz;

    float i;

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

                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = false;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;

                if (aplicaMetodo == false) {
                    //Respuesta correcta
                    fieldX.text = "No aplica el método";
                    fieldY.text = "No aplica el método";
                    fieldZ.text = "No aplica el método";
                    p3IconGood.SetActive(true);
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    fieldX.text = "No aplica el método";
                    fieldY.text = "No aplica el método";
                    fieldZ.text = "No aplica el método";
                    p3IconBad.SetActive(true);
                    Invoke("perder", 3);
                }

            }

            if (screenP4.activeSelf) {

                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = false;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;

                if (aplicaMetodo == false) {
                    //Respuesta correcta
                    fieldGx1.text = "No aplica el método";
                    fieldGx2.text = "No aplica el método";
                    fieldGx3.text = "No aplica el método";
                    fieldGx4.text = "No aplica el método";
                    p4IconGood.SetActive(true);
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    fieldGx1.text = "No aplica el método";
                    fieldGx2.text = "No aplica el método";
                    fieldGx3.text = "No aplica el método";
                    fieldGx4.text = "No aplica el método";
                    p4IconBad.SetActive(true);
                    Invoke("perder", 3);
                }

            }

            if (screenP5.activeSelf) {

                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = false;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;

                if (aplicaMetodo == false) {
                    fieldI.text = "No aplica el método";
                    //Respuesta correcta
                    p5IconGood.SetActive(true);
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    fieldI.text = "No aplica el método";
                    p5IconBad.SetActive(true);
                    Invoke("perder", 3);
                }

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
                fieldXiCPU.text = rx.ToString("0.0000000");
                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = true;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;
            }

            if (screenP3.activeSelf) {
                fieldXCPU.gameObject.SetActive(true);
                fieldYCPU.gameObject.SetActive(true);
                fieldZCPU.gameObject.SetActive(true);
                fieldXCPU.text = rx.ToString("0.0000000");
                fieldYCPU.text = ry.ToString("0.0000000");
                fieldZCPU.text = rz.ToString("0.0000000");
                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = true;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;
            }

            if (screenP4.activeSelf) {

                fieldGx1CPU.gameObject.SetActive(true);
                fieldGx2CPU.gameObject.SetActive(true);
                fieldGx3CPU.gameObject.SetActive(true);
                fieldGx4CPU.gameObject.SetActive(true);
                fieldGx1CPU.text = gx1.ToString("0.0000000");
                fieldGx2CPU.text = gx2.ToString("0.0000000");
                fieldGx3CPU.text = gx3.ToString("0.0000000");
                fieldGx4CPU.text = gx4.ToString("0.0000000");
                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = true;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;
            }

            if (screenP5.activeSelf) {

                fieldICPU.gameObject.SetActive(true);
                fieldICPU.text = i.ToString("0.0000000");
                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = true;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;
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

            if (screenP5.activeSelf) {

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

                if (fieldX.text.Contains(rx.ToString()) && fieldY.text.Contains(ry.ToString()) && fieldZ.text.Contains(rz.ToString())) {
                    //Respuesta correcta
                    p3IconGood.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    p3IconBad.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("perder", 3);
                }
            }

            if (screenP4.activeSelf) {

                if (fieldGx1.text.Contains(gx1.ToString()) && fieldGx2.text.Contains(gx2.ToString()) && fieldGx3.text.Contains(gx3.ToString()) && fieldGx4.text.Contains(gx4.ToString())) {
                    //Respuesta correcta
                    p4IconGood.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    p4IconBad.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("perder", 3);
                }

            }

            if (screenP5.activeSelf) {

                if (fieldI.text.Contains(i.ToString())) {
                    //Respuesta correcta
                    p5IconGood.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    p5IconBad.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("perder", 3);
                }

            }

        });

        p1IconGood.SetActive(false);
        p1IconBad.SetActive(false);
        fieldGxCPU.gameObject.SetActive(false);

        p2IconGood.SetActive(false);
        p2IconBad.SetActive(false);
        fieldXiCPU.gameObject.SetActive(false);

        p3IconGood.SetActive(false);
        p3IconBad.SetActive(false);

        p4IconGood.SetActive(false);
        p4IconBad.SetActive(false);
        fieldXCPU.gameObject.SetActive(false);
        fieldYCPU.gameObject.SetActive(false);
        fieldZCPU.gameObject.SetActive(false);

        p5IconGood.SetActive(false);
        p5IconBad.SetActive(false);
        fieldICPU.gameObject.SetActive(false);
        fieldI.text = "";
        fieldEcuacionP5.text = "";
        fieldLimites.text = "";
        fieldN.text = "";

        btnVerRespuesta.interactable = true;
        btnRendirse.interactable = true;
        btnValidar.interactable = true;
        btnNoAplicaElMetodo.interactable = true;

        fieldGx1CPU.gameObject.SetActive(false);
        fieldGx2CPU.gameObject.SetActive(false);
        fieldGx3CPU.gameObject.SetActive(false);
        fieldGx4CPU.gameObject.SetActive(false);

        fieldGx1.text = "";
        fieldGx2.text = "";
        fieldGx3.text = "";
        fieldGx4.text = "";

        fieldGx.text = "";
        fieldXi.text = "";
        fieldX.text = "";
        fieldY.text = "";
        fieldZ.text = "";

        

        currentTime = startingTime;

        inicializarDatos();

        //opcion = UnityEngine.Random.Range(1, 5); // No incluye el  5, el rango es de 1 a 4

        opcion = 19;

        switch (opcion) {
            case 1:
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                newtonHaciaAdelante();
                break;
            case 2:
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                newtonHaciaAtras();
                break;
            case 3:
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                newtonDiferenciasDivididas();
                break;
            case 4:
                laGrange();
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                break;
            case 5:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                puntoFijo();
                break;
            case 6:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                newtonRaphson();
                break;
            case 7:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                falsaPosicion();
                break;
            case 8:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                secante();
                break;
            case 9:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(true);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                montante();
                break;
            case 10:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(true);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                gaussJordan();
                break;
            case 11:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(true);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                eliminacionGaussiana();
                break;
            case 12:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(true);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                gaussSeidel();
                break;
            case 13:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(true);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                jacobi();
                break;
            case 14:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(true);
                screenP5.SetActive(false);
                lineaRecta();
                break;
            case 15:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(true);
                screenP5.SetActive(false);
                cuadratica();
                break;
            case 16:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(true);
                screenP5.SetActive(false);
                cubica();
                break;
            case 17:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(true);
                screenP5.SetActive(false);
                linealConFuncion();
                break;
            case 18:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(true);
                screenP5.SetActive(false);
                cuadraticaConFuncion();
                break;
            case 19:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(true);
                reglaTrapezoidal();
                break;
            case 20:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(true);
                regla13Simpson();
                break;
            case 21:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(true);
                regla38Simpson();
                break;
            case 22:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(true);
                newtonCotesCerradas();
                break;
            case 23:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(true);
                newtonCotesAbiertas();
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

        fieldXi1.text = x1.ToString("0.00");
        fieldXi2.text = x2.ToString("0.00");
        fieldXi3.text = x3.ToString("0.00");
        fieldXi4.text = x4.ToString("0.00");
        fieldYi1.text = y1.ToString("0.00");
        fieldYi2.text = y2.ToString("0.00");
        fieldYi3.text = y3.ToString("0.00");
        fieldYi4.text = y4.ToString("0.00");
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

    private void montante() {
        textoNombreMetodo.text = "Montante";
        aplicaMetodo = true;
    }

    private void gaussJordan() {
        textoNombreMetodo.text = "Gass - Jordan";
        aplicaMetodo = true;
    }

    private void eliminacionGaussiana() {
        textoNombreMetodo.text = "Eliminación Gaussiana";
        aplicaMetodo = true;
    }

    // GAUSS - SEIDEL
    private void gaussSeidel() {

        textoNombreMetodo.text = "Gauss - Seidel";
        aplicaMetodo = true;

        float x = 0;
        float y = 0;
        float z = 0;

        while (true) {

            float xi = (7.85f + (0.1f * y) + (0.2f * z)) / 3f;
            float yi = (-19.3f - (0.1f * x) + (0.3f * z)) / 7f;
            float zi = (71.4f - (0.3f * x) + (0.2f * y)) / 10f;

            float ex = Math.Abs(xi - x);
            float ey = Math.Abs(yi - y);
            float ez = Math.Abs(zi - z);

            x = xi;
            y = yi;
            z = zi;

            if (ey.ToString("0.0000000").StartsWith("0.000")) {
                rx = x;
                ry = y;
                rz = z;
                Debug.Log("\txi: " + rx.ToString("0.0000000") + "\tyi: " + ry.ToString("0.0000000") + "\tzi: " + rz.ToString("0.0000000"));
                break;
            }
        }
            
    }

    // JACOBI
    private void jacobi() {
        textoNombreMetodo.text = "Jacobi";
        aplicaMetodo = true;

        float x = 1;
        float y = 1;
        float z = 1;

        while (true) {
            
            float xi = (8 + y + z) / 8;
            float yi = (4 + (2 * x) - z) / 4;
            float zi = (5 - x + (3 * y)) / 5;

            float ex = Math.Abs(xi - x);
            float ey = Math.Abs(yi - y);
            float ez = Math.Abs(zi - z);

            x = xi;
            y = yi;
            z = zi;

            if (ex.ToString("0.0000000").StartsWith("0.001")) {
                rx = x;
                ry = y;
                rz = z;
                Debug.Log("\txi: " + rx.ToString("0.0000000")+ "\tyi: " + ry.ToString("0.0000000")+ "\tzi: " + rz.ToString("0.0000000"));
                break;

            }
        }


    }

    private void lineaRecta() {
        textoNombreMetodo.text = "Linea recta";
        aplicaMetodo = true;

        float x1 = 1.1f, x2 = 1.9f, x3 = 2.4f, x4 = 4.8f, x5 = 5.1f, x6 = 10.5f;
        float y1 = 2.5f, y2 = 2.7f, y3 = 3.7f, y4 = 5.2f, y5 = 6.0f, y6 = 8.3f;

        float n = 6.0f;

        float x = x1 + x2 + x3 + x4 + x5 + x6; //25.799999999999997
        float y = y1 + y2 + y3 + y4 + y5 + y6; //28.400000000000002
        float cx = (x1 * x1) + (x2 * x2) + (x3 * x3) + (x4 * x4) + (x5 * x5) + (x6 * x6);//169.88
        float xy = (x1 * y1) + (x2 * y2) + (x3 * y3) + (x4 * y4) + (x5 * y5) + (x6 * y6);//159.47

        float ecuac1 = (n * -4.3f) + x; //(6*-4.3)+25.799999999999997=0
        float ecuac2 = (x * -4.3f) + cx; //(25.799999999999997*-4.3)+169.88=58.94
        float ecuac3 = (y * -4.3f) + xy; //(28.4*-4.3)+159.47=37.35

        float a1 = ecuac3 / ecuac2; //a1= 37.35/58.94 = 0.6336952833389886
        Debug.Log("a1: " + a1);

        float a0;
        a0 = (y - x * a1) / n; //a0=2.008443614975683

        Debug.Log("a0: " + a0);

        gx1 = a0 + a1 * x1;
        gx2 = a0 + a1 * x2;
        gx3 = a0 + a1 * x3;
        gx4 = a0 + a1 * x4;

        Debug.Log("gx1: " + gx1);
        Debug.Log("gx2: " + gx2);
        Debug.Log("gx3: " + gx3);
        Debug.Log("gx4: " + gx4);
    }

    private void cuadratica() {
        textoNombreMetodo.text = "Cuadratica";
        aplicaMetodo = true;
    }

    private void cubica() {
        textoNombreMetodo.text = "Cubica";
        aplicaMetodo = true;
    }

    private void linealConFuncion() {
        textoNombreMetodo.text = "Lineal con función";
        aplicaMetodo = true;
    }

    private void cuadraticaConFuncion() {
        textoNombreMetodo.text = "Cuadrática con función";
        aplicaMetodo = true;
    }


    // REGLA TRAPEZOIDAL
    private void reglaTrapezoidal() {
        textoNombreMetodo.text = "Regla trapezoidal";
        aplicaMetodo = true;

        float a = 2.0f, b = 3.0f, n = 4.0f;
        float h = (b - a) / n;

        fieldLimites.text = "de " + a.ToString() + " a " + b.ToString();
        fieldN.text = n.ToString();
        fieldEcuacionP5.text = "Por definir en codigo";

        //double I=(h/2)*((1/1+(2*2))+2*((1/1+(2.25*2.25))+(1/1+(2.5+2.5))+(1/1+(2.75*2.75)))+(1/1+(3*3)));

        float A = (1.0f / (1.0f + (2 * 2)));
        float B = 2 * (1.0f / (1.0f + (2.25f * 2.25f)));
        float C = 2 * (1.0f / (1.0f + (2.5f * 2.5f)));
        float D = 2 * (1.0f / (1.0f + (2.75f * 2.75f)));
        float E = 1.0f / (1.0f + (3.0f * 3.0f));

        i = (h / 2) * (A + B + C + D + E);

        Debug.Log("I: " + i);
    }

    private void regla13Simpson() {
        textoNombreMetodo.text = "Regla 1/3 Simpson";
        aplicaMetodo = true;
    }

    private void regla38Simpson() {
        textoNombreMetodo.text = "Regla 3/8 Simpson";
        aplicaMetodo = true;
    }

    // NEWTON COTES CERRADAS
    private void newtonCotesCerradas() {
        textoNombreMetodo.text = "Newton - Cotes (Cerradas)";
        aplicaMetodo = true;

        float a = -2, b = 2, n = 4;

        fieldLimites.text = "de "+a.ToString()+" a "+b.ToString();
        fieldN.text = n.ToString();
        fieldEcuacionP5.text = "Por definir en codigo";

        float h = (b - a) / (n);
        float A = 0.04444444444f; // 2 / 45;Constante de Cotes cerradas cuando n=4


        float q = (7) * (3 * (-2 * -2 * -2) - 10);
        float z = (32) * (3 * (-1 * -1 * -1) - 10);
        float x = (12) * (3 * (0) - 10);
        float y = (32) * (3 * (1 * 1 * 1) - 10);
        float u = (7) * (3 * (2 * 2 * 2) - 10);


        i = (A * h) * (q + z + x + y + u);

        Debug.Log("I: " + i);

    }

    // NEWTON COTES ABIERTAS
    private void newtonCotesAbiertas() {
        textoNombreMetodo.text = "Newton - Cotes (Abiertas)";
        aplicaMetodo = true;

        float a = -2, b = 2, n = 4;
        float h = (b - a) / (n + 2);
        float A = 0.3f; //6 / 20;Constante de Cotes abiertas cuando n=4

        fieldLimites.text = "de " + a.ToString() + " a " + b.ToString();
        fieldN.text = n.ToString();
        fieldEcuacionP5.text = "Por definir en codigo";

        float numero1 = -1.333333333f;//-4/3
        float cubo1 = (float)Math.Pow(numero1, 3);
        float numero2 = -0.6666666667f;// -2/3
        float cubo2 = (float)Math.Pow(numero2, 3);
        float numero3 = 0.6666666667f;// 2/3
        float cubo3 = (float)Math.Pow(numero3, 3);
        float numero4 = 1.333333333f;// 4/3
        float cubo4 = (float)Math.Pow(numero4, 3);


        float q = (0) * (3 * (-2 * -2 * -2) - 10);
        float z = (11) * (3 * (cubo1) - 10);
        float x = (-14) * (3 * (cubo2) - 10);
        float y = (26) * (3 * (0 * 0 * 0) - 10);
        float u = (-14) * (3 * (cubo3) - 10);
        float o = (11) * (3 * (cubo4) - 10);
        float p = (0) * (3 * (2 * 2 * 2) - 10);

        double i = (A * h) * (q + z + x + y + u + o + p);

        Debug.Log("I: " + i);
    }

}
