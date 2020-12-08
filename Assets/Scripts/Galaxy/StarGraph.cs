﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PcgUniverse2
{
	/// <summary>
	/// Graph node for StarGraph
	/// </summary>
	public class StarNode
	{
		public GalaxyStar m_star;
		public List<StarNode> m_linkedNodes;

		public StarNode(GalaxyStar star)
		{
			m_star = star;
			m_linkedNodes = new List<StarNode>();
		}

	}

	public class StarGraph : MonoBehaviour
	{

		private StarNode m_rootNode;
		public StarNode rootNode { get => m_rootNode; set => m_rootNode = value; }

		private List<StarNode> m_nodes;
		public List<StarNode> nodes { get => m_nodes; }

		public StarGraph()
		{
			m_nodes = new List<StarNode>();
		}
		public StarNode AddNode(GalaxyStar star)
		{
			StarNode node = new StarNode(star);
			m_nodes.Add(node);

			return node;
		}

		public void LinkNodes(StarNode from, StarNode to)
		{
			from.m_linkedNodes.Add(to);
			to.m_linkedNodes.Add(from);
		}


	

	}

}

