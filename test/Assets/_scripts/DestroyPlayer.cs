using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class DestroyPlayer : MonoBehaviour {
        //Game Over Text
    public Text gameOver;

    
    
//    public GameObject myObject;
    //Variable to get scripts
    public PlayerMovement playermovement;
  
    //accessing game objects
    public Transform meeple;
	public GameObject grandChild;
    
    void Awake(){
        gameOver.text = "";
 

         Debug.Log(playermovement);
        playermovement = GetComponent <PlayerMovement> ();
        //gets the gameobect children
             //meeple = this.gameObject.transform.GetChild(0);
        //attempt to get Javavscript component but failed becaus its not recognized by C#
//            grandChild = this.gameObject.transform.GetChild(1).GetComponent <Shoot>();
        //Debug.Log(meeple);
//        Debug.Log(grandChild);

        
    }
    
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "enemy"){
//        gameObject.SetActive(false);
//        Debug.Log("Active Self: " + myObject.activeSelf);
//        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
//        playermovement.enabled = false;
//        Debug.Log(playermovement.enabled);
            Debug.Log(other.gameObject.tag);
            Time.timeScale = 0;
        }
        
    }
    
    void Update (){
        GameOver();
    }
    
    void GameOver(){
        if(Time.timeScale == 0){
            gameOver.text = "Game Over";
        }
    }
}
