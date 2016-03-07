var Bullet: Transform;
var ShootingForce = 2000.0;


function Update() {
    if (Input.GetButtonDown("fire")) {
        if (Time.timeScale == 0.0) {
            Debug.Log("Fire Disabled");
            GetComponent(shoot).enabled = false;
        } else {

            var fire = Instantiate(Bullet, transform.position, Quaternion.identity);
            fire.GetComponent. < Rigidbody > ().AddForce(transform.forward * ShootingForce);

            var audio: AudioSource = GetComponent. < AudioSource > ();
            audio.Play();
        }
    }

}