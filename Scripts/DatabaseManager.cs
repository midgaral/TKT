using UnityEngine;
using System.Collections;
using Finisar.SQLite;


public class DatabaseManager : MonoBehaviour {
	
	public SQLiteConnection connect;
	public SQLiteCommand command;
	public SQLiteDataReader reader;

	//public string dbName= "Game";//MUST NOT BE NULL!
	
	public string test;
	int mynum;
	string mystring;
	// Use this for initialization
	void Start () {
	//connect = new SQLiteConnection("Data Source= E:/Educational Game Projects/Assets/Database/Game;Version=3;New=False;Compress=True;");
		
	Connect();	
		
	
	}
	
	public void Connect()
	{
		//connect = new SQLiteConnection("Data Source ="+dblocation+";Version=3;New=False;Compress=True");
			connect = new SQLiteConnection("Data Source= E:/Educational Game Projects/Assets/Database/Game ; Version=3;New=False;Compress=True;");
	
		
	}
	

	public void Search(string searchParams)
	{
			//connect = new SQLiteConnection("Data Source = E:/Educational Game Projects/Assets/Database/Game;Version=3;New=False;Compress=True;");
	
		connect.Open();
		command = connect.CreateCommand();
		command.CommandText = searchParams;
		///command.CommandText = "SELECT COUNT(*) FROM Foods";
	}
	
	public void Execute()
	{
		
		
		reader=command.ExecuteReader();

				  while(reader.Read())
		{
			Debug.Log(reader[0]);
			//mystring = reader[0].ToString();
			mynum= int.Parse(reader[0].ToString());
			Debug.Log(mynum + "edit");
			
				/*
		 for(int counter=0; counter<4; counter++)
			{
			Debug.Log(reader[counter]);	
			}
			*/
	}
		
		
	reader.Close();
	
	
		
	}
	
	
	
		public void arrayExecute(GameObject[] spawnArray, string type)
		{
		reader=command.ExecuteReader();
		int sentinal=0;

				while(reader.Read())
				{

					Debug.Log(reader[0]);
					
					spawnArray[sentinal] = new GameObject(reader[0].ToString());
					spawnArray[sentinal].AddComponent<FoodStats>();
					Debug.Log(spawnArray[sentinal].name.ToString() + " spawned");
					spawnArray[sentinal].GetComponent<FoodStats>().calories = int.Parse(reader[1].ToString());		//int.Parse(reader[4].ToString());
			if (spawnArray[sentinal].GetComponent<FoodStats>().calories !=  null)
			{
					Debug.Log(spawnArray[sentinal].name.ToString() + " calories calculated" + " " + spawnArray[sentinal].GetComponent<FoodStats>().calories.ToString());
			}
			else
			{
			Debug.Log("Skipped");	
			}
					spawnArray[sentinal].GetComponent<FoodStats>().setFoodType(type);
					Debug.Log(spawnArray[sentinal].name.ToString() + " type set");
					
					
						
		
					sentinal++;
					
				}
		
		
			reader.Close();
		
	
	
		
		}
	
	void SpawnObjects()
	{
		
	//Instantiate	
		
		
		
		
	}
	// Update is called once per frame
	void Update () 
	{

	}
	void OnGUI()
	{
		

		
	if(GUI.Button(new Rect (10,40,100,20),"Close"))
		{
			
			
		}
		
		
	}
}


