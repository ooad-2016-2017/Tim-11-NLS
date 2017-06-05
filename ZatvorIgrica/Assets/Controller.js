#pragma strict

var hazard : GameObject;
var spawnValues : Vector3;
var hazardCount : int;
var spawnWait : float;
var startWait : float;
var waveWait : float;

var scoreText : GUIText;
private  var score : int;

function Start () {
    score = 0;
    UpdateScore ();
    StartCoroutine (SpawnWaves ());
}

function SpawnWaves () {
    yield WaitForSeconds (startWait);
    while (true)
    {
        for ( var i : int= 0; i < hazardCount; i++)
        {
             var spawnPosition : Vector3= new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
             var spawnRotation : Quaternion= Quaternion.identity;
            Instantiate (hazard, spawnPosition, spawnRotation);
            yield WaitForSeconds (spawnWait);
        }
        yield WaitForSeconds (waveWait);
    }
}

function AddScore (newScoreValue : int) {
    score += newScoreValue;
    UpdateScore ();
}

function UpdateScore () {
    scoreText.text = "Score: " + score;
}