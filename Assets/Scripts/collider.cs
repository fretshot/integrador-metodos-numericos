using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour{

    void OnTriggerEnter2D(Collider2D other){
        Destroy(other.gameObject);
        //NotificationCenter.DefaultCenter().PostNotification(this, "playerLost");
        NotificationCenter.DefaultCenter().PostNotification(this, "activarProblema");
    }

}
