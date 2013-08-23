using UnityEngine;
using System.Collections;


public class UserInterface : MonoBehaviour {


	public float width;
	public float height;
	public int lessonnum;
	
	public string gamemode;
	
	
	
	
	void Start()
	{
		gamemode="Main";//Starts the game at the start screen
		DontDestroyOnLoad(this.gameObject);
		
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log(Screen.currentResolution);
		Screen.SetResolution(800,600,false);//Foce the screen to where we want it
		
	
	}
	void settingsscreen()
	{
		GUI.Box(new Rect(200,100,300,300),"Box");
		
		
	}
	void OnGUI()
	{
		if(gamemode=="Main")
		{
		if(GUI.Button(new Rect(400,100,width,height),"Start!"))
			{
			gamemode="select";
			}
		if(GUI.Button(new Rect(400,200,width,height),"Options"))
			{
				gamemode="options";
				
			}

		if(GUI.Button(new Rect(400,300,width,height),"Customize"))
			{
				//gamemode=customize
			}
		if(GUI.Button(new Rect(400,400,width,height),"Exit"))
			{
				Application.Quit();
			}
		}
		if(gamemode=="select")
		{
			GUI.Box( new Rect(50,50,600,500),"Box");
			
		}
		
		if (gamemode=="options")
		{
			settingsscreen();
		}
		
		if (gamemode=="customize")
		{
			
		}

		if (gamemode!="Main")
		{
			if(GUI.Button(new Rect(700,450,width,height),"Return"))
			{
				gamemode="Main";
			}
			
		}
		
		
	}
}
