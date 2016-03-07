
var lifeTime = 4.0;
var rb : Rigidbody;

function Start () {
    Destroy(gameObject, lifeTime);
    rb.GetComponent.<Rigidbody> ();
}


function OnCollisionEnter(collision : Collision){ 
        //print(collision.gameObject.name);
        if (collision.gameObject.tag == "enemy") { 
        Destroy(collision.gameObject);
            Destroy(gameObject); 
        }
        else if (collision.gameObject.tag != "enemy"){
            Destroy(gameObject);
        }
    }
