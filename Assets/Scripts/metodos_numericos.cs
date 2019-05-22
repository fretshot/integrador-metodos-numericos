using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class metodos_numericos : MonoBehaviour {

    public TextMeshProUGUI textoCronometro;
    public TextMeshProUGUI textoNombreMetodo;

    public Text UIAns;

    public TMP_InputField FieldX, fieldX1, fieldX2, fieldX3, fieldX4, fieldY1, fieldY2, fieldY3, fieldY4, fieldGx, fieldGxCPU;
    public TMP_InputField fieldXi, fieldXiCPU, fieldEcuacion;
    public TMP_InputField fieldX, fieldY, fieldZ, fieldXCPU, fieldYCPU, fieldZCPU;
    public TMP_InputField fieldEcu1, fieldEcu2, fieldEcu3;

    public TMP_InputField FieldEcuacion, fieldXi1, fieldXi2, fieldXi3, fieldXi4, fieldXi5, fieldXi6, fieldYi1, fieldYi2, fieldYi3, fieldYi4, fieldYi5, fieldYi6;
    public TMP_InputField fieldGx1, fieldGx2, fieldGx3, fieldGx4, fieldGx5, fieldGx6;
    public TMP_InputField fieldGx1CPU, fieldGx2CPU, fieldGx3CPU, fieldGx4CPU, fieldGx5CPU, fieldGx6CPU;

    public TMP_InputField fieldEcuacionP5, fieldLimites, fieldN, fieldI, fieldICPU;

    public TMP_InputField fieldEcuacionP6, fieldY0P6, fieldT0P6, fieldHP6, fieldY1P6, fieldT1P6, fieldY1AnsP6, fieldY1AnsCPUP6;
    public GameObject txtY1, txtT1;

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
    public GameObject p6IconGood;
    public GameObject p6IconBad;

    public GameObject screenP1;
    public GameObject screenP2;
    public GameObject screenP3;
    public GameObject screenP4;
    public GameObject screenP5;
    public GameObject screenP6;

    public Button btnValidar;
    public Button btnVerRespuesta;
    public Button btnRendirse;
    public Button btnNoAplicaElMetodo;

    float x, x1, x2, x3, x4, y1, y2, y3, y4;
    float startingTime = 720;
    float currentTime;

    float gx;

    float gx1, gx2, gx3, gx4,gx5,gx6;

    float xi;

    float rx;
    float ry;
    float rz;

    float i;

    double yf, yfPrim;

    bool aplicaMetodo;

    int opcion;

    static List<int> _Ec1;
    static List<int> _Ec2;
    static List<int> _Ec3;
    static List<int> _rnd;

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
                    fieldGx5.text = "No aplica el método";
                    fieldGx6.text = "No aplica el método";
                    p4IconGood.SetActive(true);
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    fieldGx1.text = "No aplica el método";
                    fieldGx2.text = "No aplica el método";
                    fieldGx3.text = "No aplica el método";
                    fieldGx4.text = "No aplica el método";
                    fieldGx5.text = "No aplica el método";
                    fieldGx6.text = "No aplica el método";
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

            if (screenP6.activeSelf) {

                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = false;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;

                if (aplicaMetodo == false) {
                    fieldY1AnsP6.text = "No aplica el método";
                    //Respuesta correcta
                    p6IconGood.SetActive(true);
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    fieldY1AnsP6.text = "No aplica el método";
                    p6IconBad.SetActive(true);
                    Invoke("perder", 3);
                }

            }



        });

        btnVerRespuesta.onClick.AddListener(delegate {

            if (screenP1.activeSelf) {

                fieldGxCPU.gameObject.SetActive(true);
                fieldGxCPU.text = gx.ToString();
                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = true;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;
            }

            if (screenP2.activeSelf) {

                fieldXiCPU.gameObject.SetActive(true);
                fieldXiCPU.text = xi.ToString();
                btnVerRespuesta.interactable = false;
                btnRendirse.interactable = true;
                btnValidar.interactable = false;
                btnNoAplicaElMetodo.interactable = false;
            }

            if (screenP3.activeSelf) {
                fieldXCPU.gameObject.SetActive(true);
                fieldYCPU.gameObject.SetActive(true);
                fieldZCPU.gameObject.SetActive(true);
                fieldXCPU.text = "x = "+ rx.ToString();
                fieldYCPU.text = "y = " + ry.ToString();
                fieldZCPU.text = "z = " + rz.ToString();
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
                fieldGx5CPU.gameObject.SetActive(true);
                fieldGx6CPU.gameObject.SetActive(true);
                fieldGx1CPU.text = gx1.ToString("0.0000000");
                fieldGx2CPU.text = gx2.ToString("0.0000000");
                fieldGx3CPU.text = gx3.ToString("0.0000000");
                fieldGx4CPU.text = gx4.ToString("0.0000000");
                fieldGx5CPU.text = gx5.ToString("0.0000000");
                fieldGx6CPU.text = gx6.ToString("0.0000000");
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

            if (screenP6.activeSelf) {

                fieldY1AnsCPUP6.gameObject.SetActive(true);
                fieldY1AnsCPUP6.text = yf.ToString("0.0000000");
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

            if (screenP6.activeSelf) {

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

            if (screenP6.activeSelf) {
                
                if (fieldY1AnsP6.text.Contains(yf.ToString())) {
                    //Respuesta correcta
                    p6IconGood.SetActive(true);
                    btnVerRespuesta.interactable = false;
                    btnRendirse.interactable = false;
                    btnValidar.interactable = false;
                    btnNoAplicaElMetodo.interactable = false;
                    Invoke("ganar", 3);
                } else {
                    //Respuesta incorrecta
                    p6IconBad.SetActive(true);
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

        fieldEcu1.text = "";
        fieldEcu2.text = "";
        fieldEcu3.text = "";

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

        p6IconGood.SetActive(false);
        p6IconBad.SetActive(false);
        fieldY1AnsCPUP6.gameObject.SetActive(false);
        fieldEcuacionP6.text = "";
        fieldY0P6.text = "";
        fieldT0P6.text = "";
        fieldY1P6.text = "";
        fieldT1P6.text = "";
        fieldHP6.text = "";

        btnVerRespuesta.interactable = true;
        btnRendirse.interactable = true;
        btnValidar.interactable = true;
        btnNoAplicaElMetodo.interactable = true;

        fieldGx1CPU.gameObject.SetActive(false);
        fieldGx2CPU.gameObject.SetActive(false);
        fieldGx3CPU.gameObject.SetActive(false);
        fieldGx4CPU.gameObject.SetActive(false);
        fieldGx5CPU.gameObject.SetActive(false);
        fieldGx6CPU.gameObject.SetActive(false);

        fieldGx1.text = "";
        fieldGx2.text = "";
        fieldGx3.text = "";
        fieldGx4.text = "";
        fieldGx5.text = "";
        fieldGx6.text = "";

        fieldXi1.text = "";
        fieldXi2.text = "";
        fieldXi3.text = "";
        fieldXi4.text = "";
        fieldXi5.text = "";
        fieldXi6.text = "";

        fieldYi1.text = "";
        fieldYi2.text = "";
        fieldYi3.text = "";
        fieldYi4.text = "";
        fieldYi5.text = "";
        fieldYi6.text = "";

        fieldGx.text = "";
        fieldXi.text = "";
        fieldX.text = "";
        fieldY.text = "";
        fieldZ.text = "";


        fieldY1AnsP6.text = "";

        UIAns.gameObject.SetActive(false);
        UIAns.text = "";

        currentTime = startingTime;

        inicializarDatos();

        opcion = UnityEngine.Random.Range(1, 31); // No incluye el  5, el rango es de 1 a 4

        //opcion = 30;

        switch (opcion) {
            case 1:
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                newtonHaciaAdelante();
                break;
            case 2:
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                newtonHaciaAtras();
                break;
            case 3:
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                newtonDiferenciasDivididas();
                break;
            case 4:
                screenP1.SetActive(true);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                laGrange();
                break;
            case 5:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                puntoFijo();
                break;
            case 6:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                newtonRaphson();
                break;
            case 7:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                falsaPosicion();
                break;
            case 8:
                screenP1.SetActive(false);
                screenP2.SetActive(true);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                secante();
                break;
            case 9:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(true);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                montante();
                break;
            case 10:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(true);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                gaussJordan();
                break;
            case 11:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(true);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                eliminacionGaussiana();
                break;
            case 12:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(true);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                gaussSeidel();
                break;
            case 13:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(true);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                jacobi();
                break;
            case 14:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(true);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                lineaRecta();
                break;
            case 15:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(true);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                cuadratica();
                break;
            case 16:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(true);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                cubica();
                break;
            case 17:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(true);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                linealConFuncion();
                break;
            case 18:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(true);
                screenP5.SetActive(false);
                screenP6.SetActive(false);
                cuadraticaConFuncion();
                break;
            case 19:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(true);
                screenP6.SetActive(false);
                reglaTrapezoidal();
                break;
            case 20:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(true);
                screenP6.SetActive(false);
                regla13Simpson();
                break;
            case 21:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(true);
                screenP6.SetActive(false);
                regla38Simpson();
                break;
            case 22:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(true);
                screenP6.SetActive(false);
                newtonCotesCerradas();
                break;
            case 23:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(true);
                screenP6.SetActive(false);
                newtonCotesAbiertas();
                break;
            case 24:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(true);
                EulerHaciaAdelante();
                break;
            case 25:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(true);
                EulerModificado();
                break;
            case 26:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(true);
                RK2Orden();
                break;
            case 27:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(true);
                RK3Orden();
                break;
            case 28:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(true);
                RK13Simpson();
                break;
            case 29:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(true);
                RK38Simpson();
                break;
            case 30:
                screenP1.SetActive(false);
                screenP2.SetActive(false);
                screenP3.SetActive(false);
                screenP4.SetActive(false);
                screenP5.SetActive(false);
                screenP6.SetActive(true);
                RKOrdenSuperior();
                break;

        }
    }

    void Update(){
        stopwatch();

        if (Input.GetKeyDown(KeyCode.F12)) {
            if (!UIAns.isActiveAndEnabled) {
                UIAns.gameObject.SetActive(true);
            } else {
                UIAns.gameObject.SetActive(false);
            }
            
        }

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
        gx = (float)Math.Round(gx, 8);

        Debug.Log("Newton hacia adelante: g(x) = "+gx);
        UIAns.text = gx.ToString();
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
        gx = (float)Math.Round(gx, 8);

        Debug.Log("Newton hacia atrás: g(x) = " + gx);
        UIAns.text = gx.ToString();
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
        gx = (float)Math.Round(gx, 8);
        Debug.Log("Newton diferencias divididas: g(x) = " + gx);
        UIAns.text = gx.ToString();
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
        gx = (float)Math.Round(gx, 8);
        Debug.Log("Lagrange: g(x) = "+gx);
        UIAns.text = gx.ToString();
    }

    //PUNTO FIJO
    private void puntoFijo() {

        textoNombreMetodo.text = "Punto fijo";
        aplicaMetodo = true;

        float tmp = 0;
        float e = 0;

        System.Random random = new System.Random();
        int a = random.Next(1,6);
        int b = random.Next(1,6);

        fieldEcuacion.text = "x = ( " + a + "x^2 - " + b + " ) / 6";

        while (true) {

            xi = (a * (float)Math.Pow(tmp, 2) - b) / 6;

            e = Math.Abs(xi - tmp);
           
            xi = (float)Math.Round(xi, 8);

            if (e.ToString("0.0000000").StartsWith("0.00000")) {
                Debug.Log("xi: " + xi);
                UIAns.text = xi.ToString();
                break;
            }
            tmp = xi;
        }

    }


    //NEWTON RAPHSON
    private void newtonRaphson() {

        textoNombreMetodo.text = "Newton - Raphson";
        aplicaMetodo = true;

        fieldEcuacion.text = "f(x) = e^3x - 4";

        float tmp = 1;
        float e = 0;

        while (true) {

            xi = tmp - ((float)(Math.Exp(3 * tmp)) - 4) / (3 * (float)Math.Exp(3 * tmp)); // e^3x - 4

            e = Math.Abs(xi - tmp);

            xi = (float)Math.Round(xi, 8);

            if (e.ToString("0.0000000").StartsWith("0.00000")) {
                Debug.Log("NR xi: " + xi);
                UIAns.text = xi.ToString();
                break;
            }
            tmp = xi;
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

        fieldEcuacion.text = "f(x) = e^3x - 4";

        while (true) {

            a = xi;

            //fa= 2*(math.pow(a,2))- (6*a) -2 # Para 2x^2 - 6x - 2

            fa = (float)(Math.Exp(3 * a)) - 4; // Para e^3x - 4
            xi = a - ((fa * (b - a)) / (fb - fa));

            e = Math.Abs(xi - tmp);

            xi = (float)Math.Round(xi, 8);

            if (e.ToString("0.0000000").StartsWith("0.000")) {
                Debug.Log("xi: " + xi);
                UIAns.text = xi.ToString();
                break;
            }
            tmp = xi;
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

            xi = (float)Math.Round(xi, 8);

            if (e.ToString("0.0000000").StartsWith("0.000")) {
                Debug.Log("xi: " + xi);
                UIAns.text = xi.ToString();
                break;
            }
        }
    }

    private void montante() {

        textoNombreMetodo.text = "Montante";
        aplicaMetodo = true;

        int random1 = UnityEngine.Random.Range(3, 6);
        int random2 = UnityEngine.Random.Range(3, 7);
        int random3 = UnityEngine.Random.Range(3, 8);

        string ec1 = random1 + "x -2y +2z = 1";
        string ec2 = random2 + "x +2y +2z = 2";
        string ec3 = random3 + "x -3b +3c = 3";

        fieldEcu1.text = ec1;
        fieldEcu2.text = ec2;
        fieldEcu3.text = ec3;

        int N_ec = 3;

        double[,] a = {
                {random1, -2, 2, 1},
                {random2, 2, 2, 2 },
                {random3, -3, 3 , 3}
            };

        double[] r = new double[N_ec];

        //ShowMatrix(a, "Sistema de ecuaciones");
        if (LinearEquationsSolver.GaussianElimination(a, r)) {
            ShowSolution(r);
        }else {
            Debug.Log("No es un sistema de ecuaciones lineales");
            aplicaMetodo = false;
        }
    }

    private void gaussJordan() {

        textoNombreMetodo.text = "Gass - Jordan";
        aplicaMetodo = true;

        int random1 = UnityEngine.Random.Range(3, 6);
        int random2 = UnityEngine.Random.Range(3, 7);
        int random3 = UnityEngine.Random.Range(3, 8);

        string ec1 = random1+ "x -2y +2z = 1";
        string ec2 = random2 + "x +2y +2z = 2";
        string ec3 = random3 + "x -3b +3c = 3";

        fieldEcu1.text = ec1;
        fieldEcu2.text = ec2;
        fieldEcu3.text = ec3;

        int N_ec = 3;

        double[,] a = {
                {random1, -2, 2, 1},
                {random2, 2, 2, 2 },
                {random3, -3, 3 , 3}
            };

        double[] r = new double[N_ec];

        //ShowMatrix(a, "Sistema de ecuaciones");
        if (LinearEquationsSolver.GaussianElimination(a, r)) {
            ShowSolution(r);
        } else {
            Debug.Log("No es un sistema de ecuaciones lineales");
            aplicaMetodo = false;
        }
    }

    private void eliminacionGaussiana() {
        textoNombreMetodo.text = "Eliminación Gaussiana";
        aplicaMetodo = true;


        int random1 = UnityEngine.Random.Range(3, 6);
        int random2 = UnityEngine.Random.Range(3, 7);
        int random3 = UnityEngine.Random.Range(3, 8);

        string ec1 = random1 + "x -2y +2z = 1";
        string ec2 = random2 + "x +2y +2z = 2";
        string ec3 = random3 + "x -3b +3c = 3";

        fieldEcu1.text = ec1;
        fieldEcu2.text = ec2;
        fieldEcu3.text = ec3;

        int N_ec = 3;

        double[,] a = {
                {random1, -2, 2, 1},
                {random2, 2, 2, 2 },
                {random3, -3, 3 , 3}
            };

        double[] r = new double[N_ec];

        //ShowMatrix(a, "Sistema de ecuaciones");
        if (LinearEquationsSolver.GaussianElimination(a, r)) {
            ShowSolution(r);
        } else {
            Debug.Log("No es un sistema de ecuaciones lineales");
            aplicaMetodo = false;
        }
    }

    // GAUSS - SEIDEL
    private void gaussSeidel() {

        textoNombreMetodo.text = "Gauss - Seidel";
        aplicaMetodo = true;


        string ec1 = "3x - 0.1y - 0.2z = 7.85";
        string ec2 = "0.1x + 7y - 0.3z = -19.3";
        string ec3 = "0.3x - 0.2y + 10z = 71.4";

        fieldEcu1.text = ec1;
        fieldEcu2.text = ec2;
        fieldEcu3.text = ec3;

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

            x = (float)Math.Round(x, 8);
            y = (float)Math.Round(y, 8);
            z = (float)Math.Round(z, 8);

            if (ey.ToString("0.0000000").StartsWith("0.000")) {
                rx = x;
                ry = y;
                rz = z;
                Debug.Log("\txi: " + rx + "\tyi: " + ry + "\tzi: " + rz);
                UIAns.text = "\txi: " + rx + "\tyi: " + ry + "\tzi: " + rz;
                break;
            }
        }
            
    }

    // JACOBI
    private void jacobi() {
        textoNombreMetodo.text = "Jacobi";
        aplicaMetodo = true;

        string ec1 = "x - 3y + 3z = 5";
        string ec2 = "8x - y - z = 8";
        string ec3 = "-2x + 4y + z = 4";

        fieldEcu1.text = ec1;
        fieldEcu2.text = ec2;
        fieldEcu3.text = ec3;

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

            x = (float)Math.Round(x, 8);
            y = (float)Math.Round(y, 8);
            z = (float)Math.Round(z, 8);

            if (ex.ToString("0.0000000").StartsWith("0.001")) {
                rx = x;
                ry = y;
                rz = z;
                Debug.Log("\txi: " + rx+ "\tyi: " + ry+ "\tzi: " + rz);
                UIAns.text = "\txi: " + rx + "\tyi: " + ry + "\tzi: " + rz;
                break;

            }
        }


    }

    private void lineaRecta() {
        textoNombreMetodo.text = "Linea recta";
        aplicaMetodo = true;

        FieldEcuacion.text = "Sen X";

        
        float x1 = UnityEngine.Random.Range(1f, 1.8f);
        float y1 = UnityEngine.Random.Range(2.0f, 2.6f);

        float x2 = 1.9f, x3 = 2.4f, x4 = 4.8f, x5 = 5.1f, x6 = 10.5f;
        float y2 = 2.7f, y3 = 3.7f, y4 = 5.2f, y5 = 6.0f, y6 = 8.3f;

        fieldXi1.gameObject.SetActive(true);
        fieldXi2.gameObject.SetActive(true);
        fieldXi3.gameObject.SetActive(true);
        fieldXi4.gameObject.SetActive(true);
        fieldXi5.gameObject.SetActive(true);
        fieldXi6.gameObject.SetActive(true);
        fieldYi1.gameObject.SetActive(true);
        fieldYi2.gameObject.SetActive(true);
        fieldYi3.gameObject.SetActive(true);
        fieldYi4.gameObject.SetActive(true);
        fieldYi5.gameObject.SetActive(true);
        fieldYi6.gameObject.SetActive(true);

        fieldXi1.text = x1.ToString();
        fieldXi2.text = x2.ToString();
        fieldXi3.text = x3.ToString();
        fieldXi4.text = x4.ToString();
        fieldXi5.text = x5.ToString();
        fieldXi6.text = x6.ToString();

        fieldYi1.text = y1.ToString();
        fieldYi2.text = y2.ToString();
        fieldYi3.text = y3.ToString();
        fieldYi4.text = y4.ToString();
        fieldYi5.text = y5.ToString();
        fieldYi6.text = y6.ToString();

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
        gx5 = a0 + a1 * x5;
        gx6 = a0 + a1 * x6;

        gx1 = (float)Math.Round(gx1, 8);
        gx2 = (float)Math.Round(gx2, 8);
        gx3 = (float)Math.Round(gx3, 8);
        gx4 = (float)Math.Round(gx4, 8);
        gx5 = (float)Math.Round(gx5, 8);
        gx6 = (float)Math.Round(gx6, 8);


        Debug.Log("gx1: " + gx1);
        Debug.Log("gx2: " + gx2);
        Debug.Log("gx3: " + gx3);
        Debug.Log("gx4: " + gx4);
        Debug.Log("gx5: " + gx5);
        Debug.Log("gx6: " + gx6);
        UIAns.text = "gx1: " + gx1.ToString() + " gx2: " + gx2.ToString() + " gx3: " + gx3.ToString() + " gx4: " + gx4.ToString() + " gx5: " + gx5.ToString() + " gx6: " + gx6.ToString();
    }

    private void cuadratica() {

        textoNombreMetodo.text = "Cuadrática";
        aplicaMetodo = true;

        FieldEcuacion.text = "Cos X";

        float x1 = 1.1f, x2 = 1.9f, x3 = 2.4f, x4 = 4.8f;
        float y1 = 2.5f, y2 = 2.7f, y3 = 3.7f, y4 = 5.2f;

        fieldXi1.text = x1.ToString();
        fieldXi2.text = x2.ToString();
        fieldXi3.text = x3.ToString();
        fieldXi4.text = x4.ToString();
        fieldXi5.gameObject.SetActive(false);
        fieldXi6.gameObject.SetActive(false);

        fieldYi1.text = y1.ToString();
        fieldYi2.text = y2.ToString();
        fieldYi3.text = y3.ToString();
        fieldYi4.text = y4.ToString();
        fieldYi5.gameObject.SetActive(false);
        fieldYi6.gameObject.SetActive(false);

        fieldGx5.gameObject.SetActive(false);
        fieldGx6.gameObject.SetActive(false);

        float numero1 = x1;
        float cubo1 = (float)Math.Pow(numero1, 3f);
        float numero2 = x2;
        float cubo2 = (float)Math.Pow(numero2, 3f);
        float numero3 = x3;
        float cubo3 = (float)Math.Pow(numero3, 3f);
        float numero4 = x4;
        float cubo4 = (float)Math.Pow(numero4, 3f);

        //float n = 4.0f;
        float x = x1 + x2 + x3 + x4;//25.799999999999997
        float y = y1 + y2 + y3 + y4;//28.400000000000002
        float cx = (x1 * x1) + (x2 * x2) + (x3 * x3) + (x4 * x4);//169.88
        float xy = (x1 * y1) + (x2 * y2) + (x3 * y3) + (x4 * y4);//159.47

        float xcubica = (cubo1) + (cubo2) + (cubo3) + (cubo4);
        float xcuarta = (x1 * x1 * x1 * x1) + (x2 * x2 * x2 * x2) + (x3 * x3 * x3 * x3) + (x4 * x4 * x4 * x4);

        float cxy = (x1 * x1) * (y1) + (x2 * x2) * (y2) + (x3 * x3) * (y3) + (x4 * x4) * (y4);

        //System.out.println("x: " + x + "\ny: " + y + "\ncx: " + cx + "\nxy: " + xy + "\nxcubica: " + xcubica + "\nxcuarta: " + xcuarta + "\ncxy: " + cxy);
        /*
        //
        double ecuac1 = (n * -4.3) + x;//(6*-4.3)+25.799999999999997=0
        double ecuac2 = (x * -4.3) + cx;//(25.799999999999997*-4.3)+169.88=58.94
        double ecuac3 = (y * -4.3) + xy;//(28.4*-4.3)+159.47=37.35

        double a1 = ecuac3 / ecuac2;//a1= 37.35/58.94 = 0.6336952833389886
        System.out.println("\na1: " + a1);//

        double a0;
        a0 = (y - x * a1) / n;//a0=2.008443614975683
        System.out.println("a0: " + a0);
         */
        float a0 = 1.462569875f;
        float a1 = 0.8677754453f;
        float a2 = -0.01789378435f;

        gx1 = a0 + (a1 * x1) + a2 * (x1 * x1);
        gx2 = a0 + (a1 * x2) + a2 * (x2 * x2);
        gx3 = a0 + (a1 * x3) + a2 * (x3 * x3);
        gx4 = a0 + (a1 * x4) + a2 * (x4 * x4);

        gx1 = (float)Math.Round(gx1, 8);
        gx2 = (float)Math.Round(gx2, 8);
        gx3 = (float)Math.Round(gx3, 8);
        gx4 = (float)Math.Round(gx4, 8);


        Debug.Log("gx1: " + gx1);
        Debug.Log("gx2: " + gx2);
        Debug.Log("gx3: " + gx3);
        Debug.Log("gx4: " + gx4);

        UIAns.text = "g(x1): " + gx1.ToString() + "g(x2): " + gx2.ToString() + "g(x3): " + gx3.ToString() + "g(x4): " + gx4.ToString();
    }

    private void cubica() {

        textoNombreMetodo.text = "Cúbica";
        aplicaMetodo = true;

        FieldEcuacion.text = "Sen 3x";

        float x1 = 2.4f, x2 = 4.8f, x3 = 5.1f, x4 = 10.5f;
        float y1 = 3.7f, y2 = 5.2f, y3 = 6, y4 = 8.3f;

        fieldXi1.text = x1.ToString();
        fieldXi2.text = x2.ToString();
        fieldXi3.text = x3.ToString();
        fieldXi4.text = x4.ToString();
        fieldXi5.gameObject.SetActive(false);
        fieldXi6.gameObject.SetActive(false);

        fieldYi1.text = y1.ToString();
        fieldYi2.text = y2.ToString();
        fieldYi3.text = y3.ToString();
        fieldYi4.text = y4.ToString();
        fieldYi5.gameObject.SetActive(false);
        fieldYi6.gameObject.SetActive(false);

        fieldGx5.gameObject.SetActive(false);
        fieldGx6.gameObject.SetActive(false);

        float a0 = -0.0054401934f;
        float a1 = 2.0141915770f;
        float a2 = -0.2314786737f;
        float a3 = 0.0109530430f;

        
        float cubo1 = (float)Math.Pow(x1, 3);

        float cubo2 = (float)Math.Pow(x2, 3);

        float cubo3 = (float)Math.Pow(x3, 3);

        float cubo4 = (float)Math.Pow(x4, 3);

        gx1 = a0 + (a1 * x1) + a2 * (x1 * x1) + a3 * (cubo1);
        gx2 = a0 + (a1 * x2) + a2 * (x2 * x2) + a3 * (cubo2);
        gx3 = a0 + (a1 * x3) + a2 * (x3 * x3) + a3 * (cubo3);
        gx4 = a0 + (a1 * x4) + a2 * (x4 * x4) + a3 * (cubo4);


        gx1 = (float)Math.Round(gx1, 8);
        gx2 = (float)Math.Round(gx2, 8);
        gx3 = (float)Math.Round(gx3, 8);
        gx4 = (float)Math.Round(gx4, 8);


        Debug.Log("gx1: " + gx1);
        Debug.Log("gx2: " + gx2);
        Debug.Log("gx3: " + gx3);
        Debug.Log("gx4: " + gx4);

        UIAns.text = "g(x1): " + gx1.ToString() + "g(x2): " + gx2.ToString() + "g(x3): " + gx3.ToString() + "g(x4): " + gx4.ToString();

    }

    private void linealConFuncion() {

        textoNombreMetodo.text = "Lineal con función";
        aplicaMetodo = true;

        FieldEcuacion.text = "Cos X";

        float x1 = 1.1f, x2 = 1.9f, x3 = 2.4f, x4 = 4.8f;
        float y1 = 2.5f, y2 = 2.7f, y3 = 3.7f, y4 = 5.2f;

        fieldXi1.text = x1.ToString();
        fieldXi2.text = x2.ToString();
        fieldXi3.text = x3.ToString();
        fieldXi4.text = x4.ToString();
        fieldXi5.gameObject.SetActive(false);
        fieldXi6.gameObject.SetActive(false);

        fieldYi1.text = y1.ToString();
        fieldYi2.text = y2.ToString();
        fieldYi3.text = y3.ToString();
        fieldYi4.text = y4.ToString();
        fieldYi5.gameObject.SetActive(false);
        fieldYi6.gameObject.SetActive(false);

        fieldGx5.gameObject.SetActive(false);
        fieldGx6.gameObject.SetActive(false);

        float a0 = -115.1389662f;
        float a1 = 0.86683406f;
        float a2 = 116.6026282f;

        gx1 = a0 + (a1 * x1) + a2 * (float)Math.Cos(DegreeToRadian(x1));
        gx2 = a0 + (a1 * x2) + a2 * (float)Math.Cos(DegreeToRadian(x2));
        gx3 = a0 + (a1 * x3) + a2 * (float)Math.Cos(DegreeToRadian(x3));
        gx4 = a0 + (a1 * x4) + a2 * (float)Math.Cos(DegreeToRadian(x4));

        gx1 = (float)Math.Round(gx1, 8);
        gx2 = (float)Math.Round(gx2, 8);
        gx3 = (float)Math.Round(gx3, 8);
        gx4 = (float)Math.Round(gx4, 8);


        Debug.Log("gx1: " + gx1);
        Debug.Log("gx2: " + gx2);
        Debug.Log("gx3: " + gx3);
        Debug.Log("gx4: " + gx4);

        UIAns.text = "g(x1): " + gx1.ToString() + "g(x2): " + gx2.ToString() + "g(x3): " + gx3.ToString() + "g(x4): " + gx4.ToString();
    }

    private void cuadraticaConFuncion() {

        textoNombreMetodo.text = "Cuadrática con función";
        aplicaMetodo = true;


        FieldEcuacion.text = "Cos X";

        float x1 = 1.1f, x2 = 1.9f, x3 = 2.4f, x4 = 4.8f;
        float y1 = 2.5f, y2 = 2.7f, y3 = 3.7f, y4 = 5.2f;

        fieldXi1.text = x1.ToString();
        fieldXi2.text = x2.ToString();
        fieldXi3.text = x3.ToString();
        fieldXi4.text = x4.ToString();
        fieldXi5.gameObject.SetActive(false);
        fieldXi6.gameObject.SetActive(false);

        fieldYi1.text = y1.ToString();
        fieldYi2.text = y2.ToString();
        fieldYi3.text = y3.ToString();
        fieldYi4.text = y4.ToString();
        fieldYi5.gameObject.SetActive(false);
        fieldYi6.gameObject.SetActive(false);

        fieldGx5.gameObject.SetActive(false);
        fieldGx6.gameObject.SetActive(false);

        float a0 = 15.0531325982f;
        float a1 = 0.86776801719f;
        float a2 = -0.019961217291f;
        float ab = -13.59055743025f;

        gx1 = (a0) + (a1 * x1) + a2 * (x1 * x1) + ab * (float)Math.Cos(DegreeToRadian(x1));
        gx2 = (a0) + (a1 * x2) + a2 * (x2 * x2) + ab * (float)Math.Cos(DegreeToRadian(x2));
        gx3 = (a0) + (a1 * x3) + a2 * (x3 * x3) + ab * (float)Math.Cos(DegreeToRadian(x3));
        gx4 = (a0) + (a1 * x4) + a2 * (x4 * x4) + ab * (float)Math.Cos(DegreeToRadian(x4));

        gx1 = (float)Math.Round(gx1, 8);
        gx2 = (float)Math.Round(gx2, 8);
        gx3 = (float)Math.Round(gx3, 8);
        gx4 = (float)Math.Round(gx4, 8);


        Debug.Log("gx1: " + gx1);
        Debug.Log("gx2: " + gx2);
        Debug.Log("gx3: " + gx3);
        Debug.Log("gx4: " + gx4);

        UIAns.text = "g(x1): " + gx1.ToString() + "g(x2): " + gx2.ToString() + "g(x3): " + gx3.ToString() + "g(x4): " + gx4.ToString();
    }


    // REGLA TRAPEZOIDAL
    private void reglaTrapezoidal() {

        textoNombreMetodo.text = "Regla trapezoidal";
        aplicaMetodo = true;

        //int a = UnityEngine.Random.Range(2, 4);
        //int b = UnityEngine.Random.Range(4, 6);
        int n = UnityEngine.Random.Range(4, 10);

        float a = 2.0f, b = 3.0f; //n = 4.0f;

        float h = (b - a) / n;

        string ecuacion = "1/(1+x^2)dx";
        fieldEcuacionP5.text = ecuacion;
        fieldLimites.text = "de " + a.ToString() + " a " + b.ToString();
        fieldN.text = n.ToString();
        
        float A = (1.0f / (1.0f + (2 * 2)));
        float B = 2 * (1.0f / (1.0f + (2.25f * 2.25f)));
        float C = 2 * (1.0f / (1.0f + (2.5f * 2.5f)));
        float D = 2 * (1.0f / (1.0f + (2.75f * 2.75f)));
        float E = 1.0f / (1.0f + (3.0f * 3.0f));

        i = (h / 2) * (A + B + C + D + E);

        i = (float)Math.Round(i, 8);

        Debug.Log("I: " + i);
        UIAns.text = i.ToString();
    }

    // "1/3 DE SIPMPSON"
    private void regla13Simpson() {

        textoNombreMetodo.text = "Regla 1/3 Simpson";
        aplicaMetodo = true;

        float a = 2, b = 3, temp = 0, res = 0;

        int n = UnityEngine.Random.Range(4, 10);

        float h = (b - a) / n;

        string ecuacion = "1/(1+x^2)dx";
        fieldEcuacionP5.text = ecuacion;
        fieldLimites.text = "de " + a.ToString() + " a " + b.ToString();
        fieldN.text = n.ToString();

        float cc = (b - a) / h;

        for (int g = 1; g < cc; g++) {
            int v = g % 2;
            if (v == 0) {
                temp = integral3((a + (h * g)));

                res = res + (temp * 2);
            } else {
                temp = integral3((a + (h * g)));

                res = res + (4 * temp);
            }
        }

        i = (integral3(a) + res + integral3(b));
        i = (h / 3) * (integral3(a) + res + integral3(b));
        i = (float)Math.Round(i, 8);
        Debug.Log("I: " + i);
        UIAns.text = i.ToString();
    }

    // 3/8 DE SIMPSON
    private void regla38Simpson() {

        textoNombreMetodo.text = "Regla 3/8 Simpson";
        aplicaMetodo = true;

        int n = UnityEngine.Random.Range(3, 10);

        float a = 0, b = 1;
        float h = (b - a) / n;
        float cc = (b - a) / h;

        string ecuacion = "1/(1+x^2)dx";
        fieldEcuacionP5.text = ecuacion;
        fieldLimites.text = "de " + a.ToString() + " a " + b.ToString();
        fieldN.text = n.ToString();

        float res = 0.0f;
        for (int g = 1; g < cc; g++) {
            float temp = integral3((a + (h * g)));

            res = res + temp;
        }
        i = (integral3(a) + (3 * res) + integral3(b));
        i = ((3 * h) / 8) * (integral3(a) + (3 * res) + integral3(b));
        i = (float)Math.Round(i, 8);
        UIAns.text = i.ToString();
        Debug.Log("I: " + i);
    }

    // NEWTON COTES CERRADAS
    private void newtonCotesCerradas() {
        textoNombreMetodo.text = "Newton - Cotes (Cerradas)";
        aplicaMetodo = true;

        float a = -2, b = 2, n = 4;

        string ecuacion = "(3+x^3-10)dx";
        fieldEcuacionP5.text = ecuacion;
        fieldLimites.text = "de "+a.ToString()+" a "+b.ToString();
        fieldN.text = n.ToString();
        fieldEcuacionP5.text = ecuacion;

        float h = (b - a) / (n);
        float A = 0.04444444444f; // 2 / 45;Constante de Cotes cerradas cuando n=4

        float q = (7) * (3 * (-2 * -2 * -2) - 10);
        float z = (32) * (3 * (-1 * -1 * -1) - 10);
        float x = (12) * (3 * (0) - 10);
        float y = (32) * (3 * (1 * 1 * 1) - 10);
        float u = (7) * (3 * (2 * 2 * 2) - 10);

        i = (A * h) * (q + z + x + y + u);
        i = (float)Math.Round(i, 8);
        Debug.Log("I: " + i);
        UIAns.text = i.ToString();
    }

    // NEWTON COTES ABIERTAS
    private void newtonCotesAbiertas() {
        textoNombreMetodo.text = "Newton - Cotes (Abiertas)";
        aplicaMetodo = true;

        float a = -2, b = 2, n = 4;
        float h = (b - a) / (n + 2);
        float A = 0.3f; //6 / 20;Constante de Cotes abiertas cuando n=4

        string ecuacion = "(3+x^3-10)dx";
        fieldEcuacionP5.text = ecuacion;
        fieldLimites.text = "de " + a.ToString() + " a " + b.ToString();
        fieldN.text = n.ToString();
        fieldEcuacionP5.text = ecuacion;

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

        i = (A * h) * (q + z + x + y + u + o + p);
        i = (float)Math.Round(i, 8);

        Debug.Log("I: " + i);
        UIAns.text = i.ToString();
    }

    // "EULER HACIA ADELANTE"
    private void EulerHaciaAdelante() {

        textoNombreMetodo.text = "Euler hacia adelante";
        aplicaMetodo = true;

        double y0 = UnityEngine.Random.Range(1, 6);
        double h = 0.2;
        double t0 = 0;


        fieldEcuacionP6.text = "3y' - 5yt + 1 = 0";
        fieldY0P6.text = y0.ToString();
        fieldT0P6.text = t0.ToString();

        fieldT1P6.gameObject.SetActive(false);
        fieldY1P6.gameObject.SetActive(false);
        txtY1.SetActive(false);
        txtT1.SetActive(false);
        fieldHP6.text = h.ToString();

        yf = y0 + (h * eulerEjemp(y0, t0));
        yf = (float)Math.Round(yf, 8);

        Debug.Log("Y1: " + yf);
        UIAns.text = yf.ToString();
    }

    private void EulerModificado() {

        textoNombreMetodo.text = "Euler modificado";
        aplicaMetodo = true;

        double t0 = 0;
        double h = 0.3;
        double y0 = UnityEngine.Random.Range(1, 6);
        //double y0 = 1.2;
        double y1 = 1.2;
        double t1 = (t0 + h);

        fieldEcuacionP6.text = "2y' + 3yt + y = 0";

        fieldY0P6.text = y0.ToString();
        fieldT0P6.text = t0.ToString();

        fieldT1P6.gameObject.SetActive(true);
        fieldY1P6.gameObject.SetActive(true);
        txtY1.SetActive(true);
        txtT1.SetActive(true);
        fieldT1P6.text = t1.ToString();
        fieldY1P6.text = y1.ToString();

        fieldHP6.text = h.ToString();

        yf = y0 + ((h / 2) * (ejemploError(y0, t0) + ejemploError(y1, t1)));
        yf = (float)Math.Round(yf, 8);

        Debug.Log("yf: "+yf);
        UIAns.text = yf.ToString();
    }

    private void RK2Orden() {
        textoNombreMetodo.text = "Runge - Kutta 2° orden";
        aplicaMetodo = true;

        double y0 = UnityEngine.Random.Range(1, 6);
        double h = 0.5;
        double t0 = 0;

        fieldEcuacionP6.text = "y'e^t - 3y";

        fieldY0P6.text = y0.ToString();
        fieldT0P6.text = t0.ToString();
        fieldHP6.text = h.ToString();

        fieldT1P6.gameObject.SetActive(false);
        fieldY1P6.gameObject.SetActive(false);
        txtY1.SetActive(false);
        txtT1.SetActive(false);

        double k1 = h * rungeKutta2daEjem(y0, t0);
        double k2 = h * rungeKutta2daEjem((y0 + k1), (t0 + h));

        yf = y0 + ((k1 + k2) / 2);
        yf = (float)Math.Round(yf, 8);

        Debug.Log("yf: " + yf);
        UIAns.text = yf.ToString();
    }

    private void RK3Orden() {

        textoNombreMetodo.text = "Runge - Kutta 3° orden";
        aplicaMetodo = true;

        double y0 = UnityEngine.Random.Range(1, 6);
        double h = 0.25;
        double t = 0;

        fieldEcuacionP6.text = "(2yt + 1) / y^2";

        fieldY0P6.text = y0.ToString();
        fieldT0P6.text = t.ToString();
        fieldHP6.text = h.ToString();

        fieldT1P6.gameObject.SetActive(false);
        fieldY1P6.gameObject.SetActive(false);
        txtY1.SetActive(false);
        txtT1.SetActive(false);

        double k1 = h * tareamier(y0, t);
        double k2 = h * tareamier((y0 + (k1 / 2)), (t + (h / 2)));
        double k3 = h * tareamier((y0 - k1 + (2 * k2)), (t + h));

        yf = y0 + ((k1 + (4 * k2) + k3) / 6);
        yf = Math.Round(yf, 8);

        Debug.Log("yf: " + yf);
        UIAns.text = yf.ToString();
    }

    private void RK13Simpson() {

        textoNombreMetodo.text = "Runge - Kutta 1/3 Simpson";
        aplicaMetodo = true;

        fieldEcuacionP6.text = "((y + t)^2) / (1 - y)";

        double y0 = UnityEngine.Random.Range(1, 6);
        double h = 0.2;
        double t0 = 0;

        fieldY0P6.text = y0.ToString();
        fieldT0P6.text = t0.ToString();
        fieldHP6.text = h.ToString();

        fieldT1P6.gameObject.SetActive(false);
        fieldY1P6.gameObject.SetActive(false);
        txtY1.SetActive(false);
        txtT1.SetActive(false);

        double k1 = h * rungeKutta4taEjem(y0, t0);
        double k2 = h * rungeKutta4taEjem((y0 + (k1 / 2)), (t0 + (h / 2)));
        double k3 = h * rungeKutta4taEjem((y0 + (k2 / 2)), (t0 + (h / 2)));
        double k4 = h * rungeKutta4taEjem((y0 + k3), (t0 + h));

        yf = y0 + ((k1 + (2 * k2) + (2 * k3) + k4) / 6);
        yf = Math.Round(yf, 8);

        Debug.Log("yf: " + yf);

        if (yf.ToString() == "NaN") {
            aplicaMetodo = false;
        }

        UIAns.text = yf.ToString();
    }

    private void RK38Simpson() {

        textoNombreMetodo.text = "Runge - Kutta 3/8 Simpson";
        aplicaMetodo = true;

        fieldEcuacionP6.text = "-y / (y^2 + t)";

        double y0 = UnityEngine.Random.Range(1, 6);
        //double y0 = 1;
        double h = 0.5;
        double t0 = 0;

        fieldY0P6.text = y0.ToString();
        fieldT0P6.text = t0.ToString();
        fieldHP6.text = h.ToString();

        fieldT1P6.gameObject.SetActive(false);
        fieldY1P6.gameObject.SetActive(false);
        txtY1.SetActive(false);
        txtT1.SetActive(false);

        double k1 = h * rungeKutta4ta38Ejem(y0, t0);
        double k2 = h * rungeKutta4ta38Ejem((y0 + (k1 / 3)), (t0 + (h / 3)));
        double k3 = h * rungeKutta4ta38Ejem((y0 + (k1 / 3) + (k2 / 3)), (t0 + ((2 * h) / 3)));
        double k4 = h * rungeKutta4ta38Ejem((y0 + k1 - k2 + k3), (t0 + h));
        yf = y0 + ((k1 + (3 * k2) + (3 * k3) + k4) / 8);
        yf = Math.Round(yf, 8);

        Debug.Log("yf: " + yf);

        if (yf.ToString() == "NaN") {
            aplicaMetodo = false;
        }
        UIAns.text = yf.ToString();
    }

    private void RKOrdenSuperior() {

        textoNombreMetodo.text = "Runge - Kutta Orden Superior";
        aplicaMetodo = true;

        double y0 = UnityEngine.Random.Range(1, 6);
        //double y0 = 1.1;
        double yPrim0 = 1.2;
        double h = 0.2;
        double t0 = 0;

        fieldEcuacionP6.text = "2y'' -4y't + 2y = 0    y'0 = "+yPrim0;

        fieldY0P6.text = y0.ToString();
        fieldT0P6.text = t0.ToString();
        fieldHP6.text = h.ToString();

        fieldT1P6.gameObject.SetActive(false);
        fieldY1P6.gameObject.SetActive(false);
        txtY1.SetActive(false);
        txtT1.SetActive(false);


        double k1 = (h * yPrim0);
        double m1 = h * rungeKuttaOrdSupEjem(y0, yPrim0, t0);
        double k2 = h * (yPrim0 + m1);
        double m2 = h * rungeKuttaOrdSupEjem((y0 + k1), (yPrim0 + m1), (t0 + h));
        yf = y0 + ((k1 + k2) / 2);
        yfPrim = yPrim0 + ((m1 + m2) / 2);

        Debug.Log("yf: " + yf);

        if (yf.ToString() == "NaN") {
            aplicaMetodo = false;
        }
        UIAns.text = yf.ToString();
    }

    //=================================== FIN DE LOS METODOS ===========================//

    float Truncate(float value, int digits){
        double mult = Math.Pow(10.0, digits);
        double result = Math.Truncate( mult * value ) / mult;
        return (float) result;
    }

    static void ecuacion1() {
        System.Random random = new System.Random();
        int rnum = random.Next(0, 4);
        int vrf = rnum;
        _Ec1 = new List<int>() { rnum };
        rnum = random.Next(3, 6);
        int count = rnum;
        int v = 0;
        //Console.WriteLine($"Largo  de la lista {(count + 1)}");
        for (int i = 0; i < count; i++) {
            //Console.WriteLine($"numero en la lista {(i + 1)}");
            rnum = random.Next(0, 4);
            do {
                if (rnum == vrf) {
                    rnum = random.Next(0, 4);
                } else {
                    v = 1;
                }
            } while (v == 0);
            v = 0;
            _Ec1.Add(rnum);
            vrf = rnum;

            //Console.WriteLine($"{(i+1)} = {_Ec1[(i+1)]}");
        }
    }

    static void ecuacion2() {
        System.Random random = new System.Random();
        int rnum = random.Next(0, 4);
        int vrf = rnum;
        _Ec2 = new List<int>() { rnum };
        rnum = random.Next(1, 3);
        int count = rnum;
        int v = 0;
        //Console.WriteLine($"Largo  de la lista {(count + 1)}");
        for (int i = 0; i < count; i++) {
            //Console.WriteLine($"numero en la lista {(i + 1)}");
            rnum = random.Next(0, 4);
            do {
                if (rnum == vrf) {
                    rnum = random.Next(0, 4);
                } else {
                    v = 1;
                }
            } while (v == 0);
            v = 0;
            _Ec2.Add(rnum);
            vrf = rnum;
            //Console.WriteLine($"{(i+1)} = {_Ec2[(i+1)]}");
        }
    }
    static void ecuacion3() {
        System.Random random = new System.Random();
        int rnum = random.Next(0, 4); //operador inicial
        int vrf = rnum;
        _Ec3 = new List<int>() { rnum };
        rnum = random.Next(3, 6); // Largo de la ecuacion, numero de operadores
        int count = rnum;
        int v = 0;
        for (int i = 0; i < count; i++) {
            rnum = random.Next(0, 5);
            do {
                if (rnum == vrf) {
                    rnum = random.Next(0, 4);
                } else {
                    v = 1;
                }
            } while (v == 0);
            v = 0;
            _Ec3.Add(rnum);
            vrf = rnum;
            //Console.WriteLine($"{(i+1)} = {_Ec1[(i+1)]}");
        }
    }

    void numsRandYT() {
        System.Random random = new System.Random();
        string ecu = "";
        _rnd = new List<int>();
        int rnum = 0;
        int cc = _Ec3.Count;
        for (int i = 0; i < (cc); i++) {
            int op = _Ec3[i];
            switch (op) {
                case 0: //Adicion
                    if (i == 0) {
                        rnum = random.Next(0, 9);
                        _rnd.Add(rnum);
                        ecu = "(" + rnum + " + y)";
                    } else {
                        rnum = random.Next(1, 9);
                        _rnd.Add(rnum);
                        if (i == 1) {
                            ecu = "(" + ecu + " + t)";
                        } else {
                            ecu = "(" + ecu + " + " + rnum + ")";
                        }

                    }

                    break;

                case 1: //sustraccion
                    if (i == 0) {
                        rnum = random.Next(0, 9);
                        _rnd.Add(rnum);
                        ecu = "(" + rnum + " - y)";
                    } else {
                        rnum = random.Next(1, 9);
                        _rnd.Add(rnum);
                        if (i == 1) {
                            ecu = "(" + ecu + " - t)";
                        } else {
                            ecu = "(" + ecu + " - " + rnum + ")";
                        }
                    }

                    break;

                case 2: //Exponencial
                    if (i == 0) {
                        rnum = random.Next(1, 4);
                        _rnd.Add(rnum);
                        ecu = "(y ^ " + rnum + ")";
                    } else {
                        rnum = random.Next(2, 4);
                        _rnd.Add(rnum);
                        if (i == 1) {
                            goto case 1;
                        } else {
                            ecu = "(" + ecu + " ^ " + rnum + ")";
                        }
                    }
                    break;

                case 3: //multiplicasion
                    if (i == 0) {
                        rnum = random.Next(1, 7);
                        _rnd.Add(rnum);
                        ecu = "(" + rnum + " * y)";
                    } else {
                        rnum = random.Next(2, 7);
                        _rnd.Add(rnum);
                        if (i == 1) {
                            ecu = "(" + ecu + " * t)";
                        } else {
                            ecu = "(" + ecu + " * " + rnum + ")";
                        }
                    }
                    break;

                case 4: //division
                    if (i == 0) {
                        goto case 3;
                    } else {
                        rnum = random.Next(2, 7);
                        _rnd.Add(rnum);
                        if (i == 1) {
                            ecu = "(" + ecu + " / t)";
                        } else {
                            ecu = "(" + ecu + " / " + rnum + ")";
                        }
                    }
                    break;
            }
        }
        fieldEcuacionP6.text = ecu;
    }

    void numsRandYYT() {
        System.Random random = new System.Random();
        string ecu = "";
        _rnd = new List<int>();
        int rnum = 0;
        int cc = _Ec1.Count;
        for (int i = 0; i < (cc); i++) {
            int op = _Ec1[i];
            switch (op) {
                case 0: //Adicion
                    if (i == 0) {
                        rnum = random.Next(1, 9);
                        _rnd.Add(rnum);
                        ecu = "(" + rnum + " + y)";
                    } else {
                        rnum = random.Next(1, 9);
                        _rnd.Add(rnum);
                        if (i == 1) {
                            ecu = "(" + ecu + " + t)";
                        } else {
                            ecu = "(" + ecu + " + " + rnum + ")";
                        }

                    }
                    //Console.WriteLine(ecu);
                    break;

                case 1: //sustraccion
                    if (i == 0) {
                        rnum = random.Next(0, 9);
                        _rnd.Add(rnum);
                        ecu = "(" + rnum + " - y)";
                    } else {
                        rnum = random.Next(1, 9);
                        _rnd.Add(rnum);
                        if (i == 1) {
                            ecu = "(" + ecu + " - t)";
                        } else {
                            ecu = "(" + ecu + " - " + rnum + ")";
                        }
                    }
                    break;

                case 2: //Exponencial
                    if (i == 0) {
                        rnum = random.Next(2, 4);
                        _rnd.Add(rnum);
                        ecu = "(y ^ " + rnum + ")";
                    } else {
                        rnum = random.Next(2, 4);
                        _rnd.Add(rnum);
                        if (i == 1) {
                            goto case 3;
                        } else {
                            ecu = "(" + ecu + " ^ " + rnum + ")";
                        }
                    }
                    break;

                case 3: //multiplicasion
                    if (i == 0) {
                        rnum = random.Next(1, 7);
                        _rnd.Add(rnum);
                        ecu = "(" + rnum + " * y)";
                    } else {
                        rnum = random.Next(2, 7);
                        _rnd.Add(rnum);
                        if (i == 1) {
                            ecu = "(" + ecu + " * t)";
                        } else {
                            ecu = "(" + ecu + " * " + rnum + ")";
                        }
                    }
                    break;
            }
        }
        ecu = ecu + "/";

        cc = _Ec2.Count;
        string ecu2 = "";
        for (int i = 0; i < (cc); i++) {
            int op = _Ec2[i];
            switch (op) {
                case 0: //Adicion
                    if (i == 1) {
                        rnum = random.Next(1, 9);
                        _rnd.Add(rnum);
                        ecu2 = "(" + rnum + " + y)";
                    } else {
                        rnum = random.Next(1, 9);
                        _rnd.Add(rnum);
                        ecu2 = "(" + ecu2 + " + " + rnum + ")";
                    }
                    //Console.WriteLine(ecu);
                    break;

                case 1: //sustraccion
                    if (i == 1) {
                        rnum = random.Next(0, 9);
                        _rnd.Add(rnum);
                        ecu2 = "(" + rnum + " - y)";
                    } else {
                        rnum = random.Next(1, 9);
                        _rnd.Add(rnum);
                        ecu2 = "(" + ecu2 + " - " + rnum + ")";
                    }
                    break;

                case 2: //Exponencial
                    if (i == 1) {
                        rnum = random.Next(2, 4);
                        _rnd.Add(rnum);
                        ecu2 = "(y ^ " + rnum + ")";
                    } else {
                        rnum = random.Next(2, 4);
                        _rnd.Add(rnum);
                        ecu2 = "(" + ecu2 + " ^ " + rnum + ")";
                    }
                    break;

                case 3: //multiplicasion
                    if (i == 1) {
                        rnum = random.Next(1, 7);
                        _rnd.Add(rnum);
                        ecu2 = "(" + rnum + " * y)";
                    } else {
                        rnum = random.Next(2, 7);
                        _rnd.Add(rnum);
                        ecu2 = "(" + ecu2 + " * " + rnum + ")";
                    }
                    break;
            }
        }
        ecu = ecu + ecu2;
        fieldEcuacionP6.text = ecu;
    }

    float ecuacionYT(double y, double t) {
        double yx = 0.0;
        int cc = _Ec3.Count;
        for (int i = 0; i < (cc); i++) {
            int op = _Ec3[i];
            switch (op) {
                case 0: //Adicion
                    if (i == 0) {
                        yx = _rnd[i] + y;
                    } else {
                        if (i == 1) {
                            yx = yx + t;
                        } else {
                            yx = yx + _rnd[i];
                        }
                    }
                    break;

                case 1: //sustraccion
                    if (i == 0) {
                        yx = _rnd[i] - y;
                    } else {
                        if (i == 1) {
                            yx = yx - t;
                        } else {
                            yx = yx - _rnd[i];
                        }
                    }
                    break;

                case 2: //Exponencial
                    if (i == 0) {
                        yx = Math.Pow(y, _rnd[i]);
                    } else {
                        if (i == 1) {
                            goto case 1;
                        } else {
                            yx = Math.Pow(yx, _rnd[i]);
                        }
                    }
                    break;

                case 3: //multiplicasion
                    if (i == 0) {
                        yx = _rnd[i] * y;
                    } else {
                        if (i == 1) {
                            yx = _rnd[i] * t;
                        } else {
                            yx = yx * _rnd[i];
                        }
                    }
                    break;

                case 4: //division
                    if (i == 0) {
                        goto case 3;
                    } else {
                        if (i == 1) {
                            yx = yx / t;
                        } else {
                            yx = yx / _rnd[i];
                        }
                    }
                    break;
            }
        }
        return (float)yx;
    }

    float ecuacionYYT(double y, double t) {
        double yx = 0.0;
        int cc = _Ec1.Count;
        for (int i = 0; i < (cc); i++) {
            int op = _Ec1[i];
            switch (op) {
                case 0: //Adicion
                    if (i == 0) {
                        yx = _rnd[i] + y;
                    } else {
                        if (i == 1) {
                            yx = yx + t;
                        } else {
                            yx = yx + _rnd[i];
                        }
                    }
                    break;

                case 1: //sustraccion
                    if (i == 0) {
                        yx = _rnd[i] - y;
                    } else {
                        if (i == 1) {
                            yx = yx - t;
                        } else {
                            yx = yx - _rnd[i];
                        }
                    }

                    break;

                case 2: //Exponencial
                    if (i == 0) {
                        yx = Math.Pow(y, _rnd[i]);
                    } else {
                        if (i == 1) {
                            goto case 3;
                        } else {
                            yx = Math.Pow(yx, _rnd[i]);
                        }
                    }

                    break;

                case 3: //multiplicasion
                    if (i == 0) {
                        yx = _rnd[i] * y;
                    } else {
                        if (i == 1) {
                            yx = yx * t;
                        } else {
                            yx = yx * _rnd[i];
                        }
                    }
                    break;
            }
        }

        int cr = cc; //Largo de _Ec1
        cc = _Ec2.Count;
        double yp = 0.0;
        for (int i = 0; i < (cc); i++) {
            int j = i + cr;
            int op = _Ec2[i];
            switch (op) {
                case 0: //Adicion
                    if (i == 0) {
                        yp = _rnd[j] + y;
                    } else {
                        yp = yp + _rnd[j];
                    }
                    break;

                case 1: //sustraccion
                    if (i == 0) {
                        yp = _rnd[j] - y;
                    } else {
                        yp = yp - _rnd[j];
                    }

                    break;

                case 2: //Exponencial
                    if (i == 0) {
                        yp = Math.Pow(y, _rnd[j]);
                    } else {
                        yp = Math.Pow(yp, _rnd[j]);
                    }
                    break;

                case 3: //multiplicasion
                    if (i == 0) {
                        yp = _rnd[j] * y;
                    } else {
                        yp = yp * _rnd[j];
                    }
                    break;
            }
        }
        yx = yx / yp;
        return (float)yx;
    }


    static float integral4(float x) {
        float y = (float)(Math.Pow(x, 3)) * (float)(Math.Pow((Math.E), x));
        return y;
    }
    static float integral3(float x) {
        float y = 1 / (1 + (float)(Math.Pow(x, 2)));
        return y;
    }

    #region formated output 
    static void ShowMatrix(double[,] a, string Title) {
        Console.WriteLine(Title + '\n');
        for (int i = 0; i <= a.GetUpperBound(0); i++) {
            Console.Write('|');
            for (int j = 0; j <= a.GetUpperBound(1); j++) {
                Console.Write(ToStringSign(a[i, j]));
            }
            Console.Write(" | \n");
        }
        Console.WriteLine('\n');
    }

    void ShowSolution(double[] r) {
        //Console.WriteLine("Solucion por Eliminacion Gaussiana\n");
        for (int i = 0; i <= r.GetUpperBound(0); i++) {
            //Debug.Log(string.Format("X({0}) = {1} \n", i + 1, r[i]));
        }

        rx = (float)r[0];
        ry = (float)r[1];
        rz = (float)r[2];

        rx = (float)Math.Round(rx, 8);
        ry = (float)Math.Round(ry, 8);
        rz = (float)Math.Round(rz, 8);

        Debug.Log("x: "+r[0]+" y: "+r[1]+" z: "+r[2]);
        UIAns.text = "x: " + r[0] + " y: " + r[1] + " z: " + r[2];

        if (rx.ToString().Contains("Infinito") || ry.ToString().Contains("Infinito") || rz.ToString().Contains("Infinito")) {
            aplicaMetodo = false;
        }
    }
    static private string ToStringSign(double v) {
        if (v < 0) return ' ' + v.ToString(); else return "  " + v.ToString();
    }
    #endregion

    private double DegreeToRadian(double angle) {
        return Math.PI * angle / 180.0;
    }

    ///////Ecuaciones
    static double eulerEjemp(double y, double t) {
        double yx = 0.0;
        yx = ((5*y*t)-1)/3;
        //yx = (-y * Math.Cos(t)) / (1 - Math.Sin(t));

        return yx;
    }
    static double eulerModificadoEjem(double y, double t) {
        double yx = 0.0;
        yx = ((-3 * y * t) - y) / 2;
        return yx;
    }
    static double rungeKutta2daEjem(double y, double t) {
        double yx = 0.0;
        yx = Math.Pow(Math.E, (-t))-(3*y);
        //yx = (-y * Math.Cos(t)) / (1 - Math.Sin(t));
        return yx;
    }
    static double rungeKutta3raEjem(double y, double t) {
        double yx = 0.0;
        yx = ((2 * y * t) + 1) / (Math.Pow(y, 2));
        return yx;
    }
    static double rungeKutta4taEjem(double y, double t) {
        double yx = 0.0;
        yx = (Math.Pow((y + t), 2)) / (1 - y);
        return yx;
    }

    static double rungeKutta4ta38Ejem(double y, double t) {
        double yx = (-y) / ((y*y) + t);
        return yx;
    }
    static double rungeKuttaSimpEjem(double y, double t) {
        double yx = 0.0;
        yx = (-y) / ((y * y) + t);
        return yx;
    }
    static double rungeKuttaOrdSupEjem(double y, double yPrim, double t) {
        double yx = 0.0;
        yx = (2 * yPrim * t) - y;
        return yx;
    }
    static double ejemploError(double y, double t) {
        double yx = 0.0;
        yx = (Math.Pow((((((6 - y) * t) + 1) * 5) + 5), 3)) / (Math.Pow(y, 2));
        return yx;

    }
    static double tareamier(double y, double t) {
        double yx = 0.0;
        yx = ((2*y*t) + 1) / (y*y);
        return yx;
    }

    private void GJ(ref double[,] matrix, int filas, int columnas) {
        for (int fpivot = 0; fpivot < filas; fpivot++) {

            double nor = matrix[fpivot, fpivot];

            for (int i = 0; i < columnas; i++) {
                matrix[fpivot, i] = matrix[fpivot, i] / nor;
            }

            int f = fpivot + 1;
            if (f == filas) f = 0;

            for (int fila = 0; fila < filas - 1; fila++) {
                double k = matrix[f, fpivot];

                for (int c = fpivot; c < columnas; c++) {
                    matrix[f, c] = matrix[f, c] - (k * matrix[fpivot, c]);
                }

                if (f == filas - 1) f = 0;
                else f++;
            }
        }
    }

}


    class LinearEquationsSolver {
        /// <summary> 
        /// GaussianElimination() 
        /// Gaussian elimination is a method for solving matrix equations 
        /// By Harvey Triana 
        /// </summary> 
        /// <param name="a"> The matrix</param> 
        /// <param name="r"> The solution array</param> 
        /// <returns>Success function</returns> 
        public static bool GaussianElimination(double[,] a, double[] r) {
            double t, s;
            int i, l, j, k, m, n;

            try {
                n = r.Length - 1;
                m = n + 1;
                for (l = 0; l <= n - 1; l++) {
                    j = l;
                    for (k = l + 1; k <= n; k++) {
                        if (!(Math.Abs(a[j, l]) >= Math.Abs(a[k, l]))) j = k;
                    }
                    if (!(j == l)) {
                        for (i = 0; i <= m; i++) {
                            t = a[l, i];
                            a[l, i] = a[j, i];
                            a[j, i] = t;
                        }
                    }
                    for (j = l + 1; j <= n; j++) {
                        t = (a[j, l] / a[l, l]);
                        for (i = 0; i <= m; i++) a[j, i] -= t * a[l, i];
                    }
                }
                r[n] = a[n, m] / a[n, n];
                for (i = 0; i <= n - 1; i++) {
                    j = n - i - 1;
                    s = 0;
                    for (l = 0; l <= i; l++) {
                        k = j + l + 1;
                        s += a[j, k] * r[k];
                    }
                    r[j] = ((a[j, m] - s) / a[j, j]);
                }
                return true;
            } catch {
                return false;
            }
        }
    }


