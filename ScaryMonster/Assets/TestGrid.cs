using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TestGrid : MonoBehaviour {

	public LayerMask UnwalkbleMask;
	public Vector2 gridWorldSize;
	public float nodeRad;

	float nodeDaiamter;
	int gridSizex;
	int gridSizey;

	 Node [,] grid;
	public Vector3[] pathIMov ;



	//public Transform PLayer;				//for debug onlu 
	//public Transform Mosn;
	// Use this for initialization


	public List<Node> Mypath;
	void Start () {

	nodeDaiamter = nodeRad * 2 ;
	gridSizex = Mathf.RoundToInt(gridWorldSize.x/nodeDaiamter);
	gridSizey = Mathf.RoundToInt(gridWorldSize.y/nodeDaiamter);
	CreateGrid();

		
	}


	void Update(){
		if(Input.GetKeyDown(KeyCode.C)){
			foreach(Node n in Mypath){
			//	Debug.Log(n.nodePostionToworld);

			}
	
		}
	}


	void CreateGrid(){

		grid = new Node[gridSizex,gridSizey];
		Vector3 worldsButtomLeft = transform.position - Vector3.right * gridWorldSize.x/ 2 - Vector3.forward * gridWorldSize.y /2 ;
	


		for( int x = 0; x < gridSizex ; x++){
			for( int y = 0; y< gridSizey ; y++){

			Vector3 worldPoint = worldsButtomLeft + Vector3.right * ( x * nodeDaiamter 	+ nodeRad) + Vector3.forward * ( y * nodeDaiamter + nodeRad);

			bool walkable = !(Physics.CheckSphere(worldPoint, nodeRad, UnwalkbleMask));

			grid[x,y] =  new Node ( walkable, worldPoint, x, y);
		}
			
		}
	}


	public Node GetNodeFromWolrdPoint(Vector3 _worldpostion){

		float precX = (_worldpostion.x + gridWorldSize.x/2) / gridWorldSize.x;
		float precY = (_worldpostion.z + gridWorldSize.y/2) / gridWorldSize.y;

			precX = Mathf.Clamp01( precX);
			precY = Mathf.Clamp01( precY);

		int x = Mathf.RoundToInt((gridSizex - 1)* precX);
		int y = Mathf.RoundToInt(( gridSizey -1 ) * precY);

		return grid[x,y];
		
	}

	void OnDrawGizmos(){


		Gizmos.DrawWireCube(transform.position, new Vector3( gridWorldSize.x, 1, gridWorldSize.y));
		if( grid!=null){

		//Node playerNode = GetNodeFromWolrdPoint( PLayer.position);
		//Node Enemy = GetNodeFromWolrdPoint( Mosn.position);

			foreach( Node n in grid){


//				if(playerNode == n){
//					Gizmos.color = Color.cyan;
//					Debug.Log("playernode found at " + playerNode.nodePostionToworld.ToString());
//				}
//				if(Enemy == n){
//					Gizmos.color = Color.red;
//					Debug.Log("enemy found at " + Enemy.nodePostionToworld.ToString());
//				}
				if(Mypath == null){Debug.Log("no path!");
					break;}

				if(Mypath!=null)
				if(Mypath.Contains(n))
						Debug.Log("thre is a path");				
					

			Gizmos.color = (n.walkable)? Color.white : Color.red;
		//	Gizmos.DrawCube(n./nodePostionToworld, Vector3.one * (nodeDaiamter - .1f));
				
			}

		}

	}}
	/*

	public List<Node> GetNeighboors (Node node){

		List<Node> neighbors = new List<Node>();

		for( int x = -1; x <= -1; x++){
			for( int y = -1; y <= -1; y++){

				if(x==0 && y == 0){
					continue;
				}
				}}}}

//int checkX = node.gridX + x ;
			//	int checkY = node.gridY + y ;
			/*
				if(checkX >=0 && checkX < gridSizex  && checkY >= 0 && checkY < gridSizey){

					neighbors.Add(grid[checkX, checkY]);
															}

														}
										}//end of forloop
		return neighbors;


						}	

}*/
/*float percentX = (worldPosition.x - transform.position.x) / gridWorldSize.x + 0.5f - (nodeRadius / gridWorldSize.x);
float percentY = (worldPosition.z - transform.position.z) / gridWorldSize.y + 0.5f - (nodeRadius / gridWorldSize.y);﻿*/
