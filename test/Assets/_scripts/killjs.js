#pragma strict
//
//public var otherGameObject :  GameObject;
//
//
//private var anotherScript : shoot;
//private var anotherScript : AnotherScript;
//private var yetAnotherScript :  YetAnotherScript;
//private var boxCol : BoxCollider;
//
//
//function Awake ()
//{
//    anotherScript = GetComponent(AnotherScript);
//    yetAnotherScript = otherGameObject.GetComponent(YetAnotherScript);
//    boxCol = otherGameObject.GetComponent(BoxCollider);
//    shoot;
//}
//
//
//function Start ()
//{
//    boxCol.size = new Vector3(3,3,3);
//    Debug.Log("The player's score is " + anotherScript.playerScore);
//    Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
//}
//



//fireScript.enabled = false;
public var child;
public var player;
public var selected;



function Start () {

//Assigns the first child of the first child of the Game Object this script is attached to.
child = this.gameObject.transform.GetChild(1).gameObject;
    player = this.gameObject;
    Debug.Log(child);
//    Debug.Log(player);
//    child = child.GetComponent(shoot);
//    var script : shoot;
//child.gameObject.SetActive (false);
//    Debug.Log(child.SetActive);

};


        function OnTriggerEnter (collision : Collider)//OnCollisionEnter(collision: Collision) 
        {
           if (collision.gameObject.tag == "enemy"){
                Debug.Log("ENemey!!!");
               //list components.
                   
            
               //GetComponent(shoot).enabled = false;
           }
            
        }
//    codde runing every frame
//         if(Input.GetMouseButton(0)){
//         GetComponent(MouseLook).enabled = false;
//         Slice();
//         GetComponent(MouseLook).enabled = true;
//     }
