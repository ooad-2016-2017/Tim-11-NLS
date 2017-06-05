#pragma strict


	 var moveUp : KeyCode;
	 var moveDown : KeyCode;
	 var moveRight : KeyCode;
	 var moveLeft : KeyCode;

	 var tekst:UnityEngine.UI.Text;
	 var brojac=0;
	 var gameOver:UnityEngine.UI.Text;
	 var ispocetka:UnityEngine.UI.Text;
	 var kraj : boolean;
	 var gameObjects : GameObject[];
	 var slika:GameObject;
	 var spriteImage : Sprite;
	 var speed : float=0.00000000000000000000000000001;
	 var easyhard:UnityEngine.UI.Image;

	 var theObject:GameObject;
	 var theObject1:GameObject;
	 var theNewPos;
	 var lagano : boolean;
	 var easybutton : UnityEngine.UI.Button;
	 var hardbutton : UnityEngine.UI.Button;
	 var brzinaStrazara:float=0;


function Start () {
	  
		StartCoroutine(spawn());
	    brojac=1;
	    gameOver.text="";
	    ispocetka.text="";
	    kraj=true;
		
	easybutton.onClick.AddListener(f);
	hardbutton.onClick.AddListener(f2);
	}

	function Update () {

		if(Input.GetKey(moveUp) && kraj==true){

		
			GetComponent(Rigidbody2D).velocity = new Vector2(0,speed); 
		}

		else if(Input.GetKey(moveDown)&& kraj==true){

			GetComponent(Rigidbody2D).velocity = new Vector2(0,speed*-1);
		}

		else if(Input.GetKey(moveRight)&& kraj==true){

			GetComponent(Rigidbody2D).velocity = new Vector2(speed,0);
		}

		else if(Input.GetKey(moveLeft)&& kraj==true){

			GetComponent(Rigidbody2D).velocity = new Vector2(speed*-1,0);
		}

		else if(Input.GetKey(KeyCode.R)){
			Application.LoadLevel(Application.loadedLevel);
		}
	}







 function spawn() : IEnumerator {
         while (true) {
             yield WaitForSeconds(3.0);
             theNewPos= new Vector3 (Random.Range(-10,10),Random.Range(-5,5),0);
			 theObject.transform.position = theNewPos;
			 theObject.SetActive(true);
			 if(kraj==false) break;
         }
     }

	 function OnCollisionEnter2D(batt : Collision2D)
	{
		if(batt.collider.name == "keys")
		{
		
		theObject.SetActive(false);
		var go : GameObject = Instantiate(theObject1);
		theNewPos= new Vector3 (Random.Range(-10,10),Random.Range(-5,5),0);
        go.transform.position = theNewPos;
		go.AddComponent(Rigidbody2D);
		go.AddComponent(CircleCollider2D);
		Destroy(go,brzinaStrazara);
		Debug.Log("Hit");
		tekst.text="Score: "+brojac;
		brojac=brojac+1;
		}
		else if(batt.collider.name=="strazar(Clone)" || batt.collider.name=="strazar"  ){
		Debug.Log("strazar");
			kraj=false;
			 
			 gameObjects =  GameObject.FindGameObjectsWithTag ("Player");
 
			 for(var i = 0 ; i < gameObjects.length ; i ++){
			   Destroy(gameObjects[i]);
			 }
				transform.position = new Vector3(0, 0, 0);
				GetComponent(Rigidbody2D).velocity = new Vector2(0,0); 
				gameOver.text="GAME OVER";
				ispocetka.text="PRESS R FOR RESTART";

		 slika.GetComponent(SpriteRenderer).sprite = spriteImage;
		 slika.transform.localScale.x=14.0;
		  slika.transform.localScale.y=7.0;
		  transform.localScale.y=3.0;
		  transform.localScale.x=2.0;
		}

	}

	function f(){
		
		easybutton.gameObject.SetActive(false);
		hardbutton.gameObject.SetActive(false);
		Destroy(easybutton);
		Destroy(hardbutton);
		Destroy(easyhard);
		lagano = true;
		brzinaStrazara=5.0;
		Debug.Log("LAGANO");
	}

	function f2(){
		
		easybutton.gameObject.SetActive(false);
		hardbutton.gameObject.SetActive(false);
		Destroy(easybutton);
		Destroy(hardbutton);
		Destroy(easyhard);
		lagano = false;
		brzinaStrazara=20;
		Debug.Log("NIJE LAGANO DABOME" );
	}