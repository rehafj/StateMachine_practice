using UnityEngine;
using System.Collections;

public class TestNode  {


public bool walkable;
public Vector3 nodePostionToworld;

public int gridX;
public int gridY;

public int gCost;
public int Hcost;

public int fCost {
	get {
		return gCost + Hcost;
	}
}

public Node parent;

public TestNode ( bool _walkble, Vector3 _worldPos, int _x, int _y){

	walkable = _walkble;
	nodePostionToworld = _worldPos;
	gridX = _x;
	gridY = _y;

}



}
