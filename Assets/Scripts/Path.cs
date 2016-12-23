using System;
using System.Collections.Generic;
using UnityEngine;

public class Path
{

	private List<Node> points;

	public Path()
	{

	}

	public Path(List<Node> nodes)
	{
		points = nodes;
	}

	public void AppendPoint(Node point)
	{
		points.Add(point);
	}

	public void InsertPoint(Node point, int index)
	{
		points.Insert(index, point);
	}

	public float PathLength() // possible optimization to only recalculate when nodes are added or modified
	{
		if (points.Count == 1)
		{
			Debug.LogWarning("Cannot determine length of a Path with 1 Node");
			throw new Exception();
		}

		float length = 0.0f;
		for (int i = 0; i < points.Count; i++)
		{
			length += Node.DistanceBetweenNodes(points[i], points[i + 1]);
		}

		return length;
	}

	public Node LinearPointOnPath(float percentage)
	{
		//math
		// TODO
		return new Node(0, 0);
	}

}
