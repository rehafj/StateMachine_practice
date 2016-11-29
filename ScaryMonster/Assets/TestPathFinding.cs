using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TestPathFinding : MonoBehaviour {

/*
	Grid grid ;
	public Transform monster, target;


	public void Awake(){
		grid = GetComponent<Grid>();

	}

	void Update(){
	if(Input.GetKeyDown(KeyCode.Space)){
		FindPath(monster.position, target.position);}
	}

	void FindPath(Vector3 startpos, Vector3 targetPos){

		Node startNode = grid.GetNodeFromWolrdPoint(startpos);
		Node targetNode = grid.GetNodeFromWolrdPoint(targetPos);
		Debug.Log(startNode.ToString() + " is start node");
		Debug.Log(targetNode.ToString() + " is end node");

		List<Node> openSet = new List<Node>();
		HashSet<Node> closedSet = new HashSet<Node>();

		openSet.Add(startNode);


		while(openSet.Count > 0){
			Debug.Log("open set has"+openSet[0].nodePostionToworld.ToString());
			Node currentNode = openSet[0];
			for( int i = 1; i < openSet.Count ; i++){

				if( openSet[i].fCost < currentNode.fCost || openSet[i].fCost == currentNode.fCost && openSet[i].Hcost < currentNode.Hcost){

					currentNode = openSet[i];
				}

			}

			openSet.Remove(currentNode);
			closedSet.Add(currentNode);

			if(currentNode == targetNode){
				retracePath(startNode, targetNode);
				Debug.Log("goal node fouund!");
				return;

			}

			foreach( Node neighboor in grid.GetNeighboors(currentNode)){

				if(! neighboor.walkable || closedSet.Contains(neighboor)){

					continue;
				}

				int newMoveCost = currentNode.gCost + GetDistance(currentNode, neighboor);
				if(newMoveCost < neighboor.gCost || !openSet.Contains(neighboor)){


				neighboor.gCost = newMoveCost;
				neighboor.Hcost = GetDistance(neighboor, targetNode);

				neighboor.parent = currentNode;


				if(!openSet.Contains(neighboor))
					openSet.Add(neighboor);


				}

			}

		}


	}

	void retracePath (Node startNode, Node endNode){
	Debug.Log("PATHFOUND RECREATING PATH");
	List<Node> path = new List<Node>();
	Node currentnode = endNode;

	while(currentnode != startNode){
		path.Add(currentnode);
		currentnode = currentnode.parent;

	}

	path.Reverse();

	grid.Mypath = path;

		for(int i = 0; i< path.Count; i++){
			
			grid.pathIMov[i] = path[i].nodePostionToworld;
		}




	}


	int GetDistance( Node a, Node b){

		int disX = Mathf.Abs(a.gridX - b.gridX);
		int disY = Mathf.Abs(a.gridY - b.gridY);

		if( disX > disY){

			return 14 * disY + 10 * (disX - disY);
		}

		return 14 * disX + 10 * (disY - disX);



	}
	*/
}
