using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{

	public float x { get; set; }
	public float y { get; set; }

	public Node(float XCoordinate, float YCoordinate)
	{
		x = XCoordinate;
		y = YCoordinate;
	}

	public float DistanceToNode(Node node)
	{
		float distance = Mathf.Sqrt(
			Mathf.Pow(x - node.x, 2)
			+ Mathf.Pow(y - node.y, 2)
			);

		return distance;
	}

	public static float DistanceBetweenNodes(Node node1, Node node2)
	{
		return node1.DistanceToNode(node2);
	}

}
