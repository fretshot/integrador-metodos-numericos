using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameplay : MonoBehaviour {

   
    private List<int> numeros;

    private int score = 0;
    private int maxScore = 0;
    float time;

    public TextMeshProUGUI txt_score;
    public TextMeshProUGUI txt_yourScore;
    public TextMeshProUGUI txt_maxScore;
    public TextMeshProUGUI txt_newRecord;

    private AudioSource sourceMusic;
    public AudioSource lostSound;
    public AudioSource getPointsSound;
    public AudioSource lostLiveSound;
    public AudioSource newRecordSound;

    private bool playerIsDead = false;

    public GameObject failCamera;
    public Camera mainCamera;
    public GameObject lostLiveCamera;
    public GameObject pauseCamera;
    public GameObject screen_game;
    public GameObject screen_problema;

    void Start(){

        playerIsDead = false;

        sourceMusic = GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("MusicVolume")) {
            sourceMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
        } else {
            sourceMusic.volume = 1f;
        }

        mainCamera.enabled = true;
        lostLiveCamera.SetActive(false);
        failCamera.SetActive(false);
        txt_newRecord.enabled = false;
        pauseCamera.SetActive(false);

        numeros = new List<int>();
        NotificationCenter.DefaultCenter().AddObserver(this, "agregar");
        NotificationCenter.DefaultCenter().AddObserver(this, "playerLost");
        NotificationCenter.DefaultCenter().AddObserver(this, "resumeGameplay");
        NotificationCenter.DefaultCenter().AddObserver(this, "pauseGameplay");
        NotificationCenter.DefaultCenter().AddObserver(this, "borrarPantalla");
        NotificationCenter.DefaultCenter().AddObserver(this, "activarProblema");
        NotificationCenter.DefaultCenter().AddObserver(this, "respuestaCorrecta");
        NotificationCenter.DefaultCenter().AddObserver(this, "respuestaInorrecta");

        if (PlayerPrefs.HasKey("Maxscore")) {
            maxScore = PlayerPrefs.GetInt("Maxscore");
        }
    }

    private void Update() {

        stopWatch();

        if (Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)) {
            if (numeros.Contains(0)) {
                Destroy(GameObject.FindGameObjectWithTag("num0"));
                numeros.Remove(0);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                //playerLost();
                activarProblema();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)) {
            if (numeros.Contains(1)) {
                Destroy(GameObject.FindGameObjectWithTag("num1"));
                numeros.Remove(1);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                //playerLost();
                activarProblema();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)) {
            if (numeros.Contains(2)) {
                Destroy(GameObject.FindGameObjectWithTag("num2"));
                numeros.Remove(2);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                //playerLost();
                activarProblema();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)) {
            if (numeros.Contains(3)) {
                Destroy(GameObject.FindGameObjectWithTag("num3"));
                numeros.Remove(3);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                //playerLost();
                activarProblema();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)) {
            if (numeros.Contains(4)) {
                Destroy(GameObject.FindGameObjectWithTag("num4"));
                numeros.Remove(4);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                //playerLost();
                activarProblema();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)) {
            if (numeros.Contains(5)) {
                Destroy(GameObject.FindGameObjectWithTag("num5"));
                numeros.Remove(5);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                //playerLost();
                activarProblema();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)) {
            if (numeros.Contains(6)) {
                Destroy(GameObject.FindGameObjectWithTag("num6"));
                numeros.Remove(6);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                //playerLost();
                activarProblema();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)) {
            if (numeros.Contains(7)) {
                Destroy(GameObject.FindGameObjectWithTag("num7"));
                numeros.Remove(7);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                //playerLost();
                activarProblema();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)) {
            if (numeros.Contains(8)) {
                Destroy(GameObject.FindGameObjectWithTag("num8"));
                numeros.Remove(8);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                //playerLost();
                activarProblema();
            }
        }

        if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)) {
            if (numeros.Contains(9)) {
                Destroy(GameObject.FindGameObjectWithTag("num9"));
                numeros.Remove(9);
                score += 1;
                txt_score.text = score.ToString();
                getPointsSound.Play();
            } else {
                //playerLost();
                activarProblema();
            }
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)){
            if (playerIsDead == true) {
                SceneManager.LoadScene("01");
            }
        }
        

        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (playerIsDead == true) {
                SceneManager.LoadScene("00");
            } else {
                if (Time.timeScale == 1) {
                    NotificationCenter.DefaultCenter().PostNotification(this, "pauseGameplay");
                } else {
                    NotificationCenter.DefaultCenter().PostNotification(this, "resumeGameplay");
                }
                
            }
        }
    }

    private void stopWatch() {
        time += Time.deltaTime;
        time = time * 0.01f;
        string hours = Mathf.Floor((time % 216000) / 3600).ToString("00");
        string minutes = Mathf.Floor((time % 3600) / 60).ToString("00");
        string seconds = (time % 60).ToString("00");
        string text = hours + ":" + minutes + ":" + seconds;
        if (!numeros.Count.Equals(0)) { //Check if list is empty
            NotificationCenter.DefaultCenter().PostNotification(this, "increaseSpeed", time);
        }
    }



    void agregar(Notification notification) {
        numeros.Add((int)notification.data);
    }

    

    public void borrarPantalla(Notification notification) {

        string[] tags = {
            "num0","num1","num2","num3","num4","num5","num6","num7","num8","num9"
        };

        foreach (string tag in tags) {
            GameObject[] numeros = GameObject.FindGameObjectsWithTag(tag);

            foreach (GameObject numero in numeros) {
                Destroy(numero);
            }
        }
    }

    public void activarProblema() {
        NotificationCenter.DefaultCenter().PostNotification(this, "borrarPantalla");
        NotificationCenter.DefaultCenter().PostNotification(this, "stopGenerator");
        screen_game.SetActive(false);
        screen_problema.SetActive(true);
        lostLiveSound.Play();
        lostLiveCamera.SetActive(true);
        Invoke("disableLostLiveCamera", 0.5f);
    }

    public void playerLost() {
        screen_problema.SetActive(false);
        playerIsDead = true;
        failCamera.SetActive(true);
        mainCamera.enabled = false;
        NotificationCenter.DefaultCenter().PostNotification(this, "borrarPantalla");
        if (score > maxScore) {
            PlayerPrefs.SetInt("Maxscore", score); // Guardamos la puntuacion maxima
            txt_newRecord.enabled = true;
            Invoke("activateSoundMaxScore", 2f);
        } else {
            txt_newRecord.enabled = false;
        }
        NotificationCenter.DefaultCenter().PostNotification(this, "stopGenerator");

        txt_maxScore.text = "Puntuación Máxima: " + maxScore.ToString();
        txt_yourScore.text = "Puntuación Actual: " + score.ToString();
        number_movement.speed = 5f;
        sourceMusic.volume = 0.0f;
        lostLiveSound.Play();
        lostLiveCamera.SetActive(true);
        Invoke("disableLostLiveCamera", 0.5f);        
    }

    public void disableLostLiveCamera() {
        lostLiveCamera.SetActive(false);        
    }

    public void activateSoundMaxScore() {
        newRecordSound.Play();
    }

    void resumeGameplay(Notification notification) {
        pauseCamera.SetActive(false);
        Time.timeScale = 1;
        sourceMusic.volume = PlayerPrefs.GetFloat("MusicVolume");
    }

    void pauseGameplay(Notification notification) {
        pauseCamera.SetActive(true);
        Time.timeScale = 0;
        sourceMusic.volume = 0f; 
    }

    public void continuarJugando(){
        //Validar primero si la respuesta es correcta
        screen_game.SetActive(true);
        screen_problema.SetActive(false);
        NotificationCenter.DefaultCenter().PostNotification(this, "startGenerator");
    }

    void respuestaCorrecta(Notification notification) {
        continuarJugando();
    }

    void respuestaInorrecta(Notification notification) {
        playerLost();
    }

}
