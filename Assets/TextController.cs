using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;
	private enum States 
	{cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom, corridor_0,
	corridor_1, corridor_2, corridor_3, floor, closet_door, in_closet, stairs_0, stairs_1, stairs_2, courtyard};
	private States myState; 
	// Use this for initialization
	void Start () {
		myState = States.cell;
	
	}
	
	// Update is called once per frame
	void Update () {
		print(myState);
		 if (myState==States.cell) 				{cell();}
		 else if (myState== States.sheets_0) 	{sheets_0();}
		 else if (myState== States.sheets_1)    {sheets_1();}
		 else if (myState== States.lock_0) 		{lock_0();}
		 else if (myState== States.lock_1) 		{lock_1();}
		 else if (myState== States.mirror)      {mirror();}
		 else if (myState== States.cell_mirror) {cell_mirror();}
		 else if (myState== States.corridor_0) 	{corridor_0();}
		 else if (myState== States.corridor_1) 	{state_corridor_1();}
	   	 else if (myState== States.corridor_2) 	{state_corridor_2();}
		 else if (myState== States.corridor_3) 	{state_corridor_3();}
		 else if (myState== States.stairs_0)  	{state_stairs_0();}
		 else if (myState== States.stairs_1)  	{state_stairs_1();}
		 else if (myState== States.stairs_2)  	{state_stairs_2();}
		 else if (myState== States.closet_door) {state_closet_door();}
		 else if (myState== States.in_closet)  	{state_in_closet();}
		 else if (myState== States.floor) 	    {state_floor();}
		 else if (myState== States.courtyard) 	{state_courtyard();}
	}
	
	void cell(){
		text.text = "After months and months on the run, you've finally been apprehended and tossed "  +
					"in prison for a crime that you did not commit. You need to escape, no matter what. "  +
					"There are some dirty sheets on the bed, a mirror on the wall, and the door is locked " +
					"from the outside. \n\n"+
					"Press S to view Sheets, M to view Mirror and L to view Lock";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState= States.sheets_0;
		}
		else if (Input.GetKeyDown(KeyCode.M)) {
			myState= States.mirror;
		}
		else if (Input.GetKeyDown(KeyCode.L)) {
			myState= States.lock_0;
		}
	}
	void mirror(){
		text.text = "This dirty mirror on the wall seems a bit loose\n\n" +
					"Press T to Take the mirror, or R to Return to cell" ;
		if (Input.GetKeyDown(KeyCode.T)){
		myState = States.cell_mirror;
		}
		else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	void cell_mirror(){
			text.text = "Still trying to GTFO here you hear me dawg lol. The sheets are still cold and dirty, " +
						"there's now a mark where the mirror was, "+
						"and that damn door is still in the way of my freedom.\n\n" +
						"Press S to view Sheets, or L to view Lock" ;
			if (Input.GetKeyDown(KeyCode.S)){
				myState = States.sheets_1;
			}
			else if (Input.GetKeyDown(KeyCode.L)) {
				myState = States.lock_1;
		}
	}
	void sheets_0 (){
		text.text = "Rags. They've give me nothing but a pile of rags to sleep on. "  +
					"I'm gonna freeze if I don't get something better. "  +
					"Wonder if I can get some better ones if I trade in a pack of cigs...\n\n" +
					"Press R to Return to roaming your cell";
	
		if (Input.GetKeyDown(KeyCode.R)) {
			myState= States.cell;
		}
	}
	void sheets_1 (){
		text.text = "The reflection of the sun doesn't make the sheets warmer, "  +
					"unfortunately.\n\n "  +
					"Press R to Return to roaming your cell";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState= States.cell_mirror;
		}
	}
	void lock_0(){
		text.text = "Look at this high tech lock. Its not a key lock, but it looks like a numeric touchpad. "  +
					"They definitely don't want me sneaking off anywhere and telling the truth. "  +
					"Hmm. If only I could somehow see where the dirty fingerprints were, " +
					"that would help me figure out the code. \n\n"+
					"Press R to Return to roaming your cell" ;
		if (Input.GetKeyDown(KeyCode.R)) {
			myState= States.cell;
		}
	}
	void lock_1(){
		text.text = "I put the mirror through the bars and turn it around so I can see the reflection. "  +
					"I can make out the fingerprints through the reflection. I press the dirty buttons "  +
					"and hear a click.\n\n " +
					"Press O to Open, or R to Return to the cell" ;
		if (Input.GetKeyDown(KeyCode.O)) {
			myState= States.corridor_0;
		}
		else if (Input.GetKeyDown (KeyCode.R))  {
			myState= States.cell_mirror;
	}
}
	void corridor_0(){
			text.text = "I'm free...wait...now I gotta figure out how to sneak out. Shit. I'm in a corridor now. " +
						"To my left, I can see a set of stairs, I think I hear the sound of the wind coming from there. " + 
						"To the right I see some sort of closet with a standard key lock. Up ahead on the floor there are some items " +
						"scattered across the floor. Maybe I can find something to help me out. \n\n" +
						"Press L to go to the Left Stairway, or R to go Right into the  closet "+
						", or press H to go into the Hall";
			if (Input.GetKeyDown (KeyCode.L)) {
			myState= States.stairs_0;
		}
			else if (Input.GetKeyDown (KeyCode.H)) {
			myState = States.floor;
	    }
			else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.closet_door;
	}
}
	void state_floor(){
			text.text = "When was the last time anyone cleaned up over here? Any of these people ever hear of prisoners rights?. " +
					 	"Its just like the cell they put me in. Hmm. I ssee a paperclip on the ground. Should I pick it up? \n\n" +
					 	"Press T to Take the Paperclip, or C to return to the Corridor";
					 	
			if (Input.GetKeyDown (KeyCode.T)) {
			myState= States.corridor_1;
		}
			else if (Input.GetKeyDown (KeyCode.C)) {
			myState= States.corridor_0;
		}
				
}
	void state_closet_door (){
			text.text = "Janitors closet? Maybe something in there can help me sneak out of here. Hope there's a bulletproof vest in there. " +
						"Ah.....its locked. Go figure. I'm pretty good at standard lockpicks but I need something to fit in there...\n\n" +
						"Press C to return to the Corridor";
						
		 	if (Input.GetKeyDown (KeyCode.C)) {
			myState= States.corridor_0;
			}
		}		
	void state_stairs_0(){
			text.text = "My heart dropped as soon as I reached the top of the stairs. Guards. Armed to the teeth " +
						"They didn't spot me, but its a no go in this direction for now.\n\n" +
						"Press C to return to the Corridor";
			if (Input.GetKeyDown (KeyCode.C)) {
			myState= States.corridor_0; 
		}
	}
	void state_stairs_1(){
			text.text = "Something tells me this little paperclip isn't gonna deflect 50 caliber bullets. " +
						"Unless this is a magic paperclip and no one had told me, then I have to go back.\n\n" +
						"Press C to return to the Corridor";
			if (Input.GetKeyDown (KeyCode.C)) {
			myState= States.corridor_1; 
			
		}
		
	}
	void state_stairs_2(){
			text.text = "Looks like the guards are still on high alert....and still armed. Duh. Don't think " +
						"bending the paperclip turned it magical. \n\n" +
						"Press C to return to the Corridor";
			if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.corridor_2; 
			
		}
		
	}
	void state_corridor_1(){
			text.text = "Back in the corridor with my friend lil Clip. I can back up the stairs or pick the closet lock.\n\n"+
						"Press S to go up the Stairs or press C to go to open the Closet";
			if (Input.GetKeyDown (KeyCode.S)){
			myState = States.stairs_1;
		}	
			else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.in_closet;
}
}
	void state_in_closet() {
			text.text = "I guess I could hide in here a case a guard passes by, but I don't have any time to waste. On a shelf " +
						"I can see a janitors uniform and an ID.\n\n" +
						"Press P to Put on the Uniform or or C to go back to the Corridor";
			if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.corridor_3;
		}
			else if (Input.GetKeyDown (KeyCode.C)) {
			myState= States.corridor_2;
		}			
}		
	void state_corridor_2 (){
		text.text = "Umm....I guess I could go back up the stairs and look for an opening? Or I can go back to the closet and " +
					"figure something out.\n\n" +
					"Press S to go up the Stairs or C to go to the Closet";
					
			if(Input.GetKeyDown (KeyCode.S)) {
			myState= States.stairs_2;
		}
			else if (Input.GetKeyDown (KeyCode.C)) {
			myState= States.in_closet;
		}
	}
	void state_corridor_3 (){
			text.text = "Okay I've got these clothes on. Time to see if I can sneak past these guards. Or I can chicken out " + 
						" and take them off in the closet. \n\n" +
						"Press S to go up the Stairs or U to Undress in the closet";
				if (Input.GetKeyDown (KeyCode.S)) {
				myState= States.courtyard;
			}
				else if (Input.GetKeyDown (KeyCode.U)) {
				myState= States.in_closet;
			}
		}
	void state_courtyard () {
			text.text = "Walking past the guards with my head low. Just waved to one of them. C'mon just 10 more feet and I'm out of-\n\n" +
						"WARNING. AN INMATE HAS VACATED HIS CELL. ALL SECURITY ON HIGH ALERT. SUSPECT MAY BE ARMED AND DANGEROUS.\n\n" +
						"C'mon......its a paperclip.....\n\n" +
						"Press P to Play again";
				if (Input.GetKeyDown (KeyCode.P)) {
				myState= States.cell;
				}
}
}
		