using System.Collections.Generic;
using SLZ.Interaction;
using TMPro;
using UnityEngine;

namespace SLZ.Utilities
{
	public class ShowNameOfInteractable : MonoBehaviour, IInteractionReceivable
	{
		public TextMeshPro tmp;

		private Dictionary<InteractableHost, string> log;

		private List<InteractableHost> enterNames;

		private List<string> history;

		private void Awake()
		{
		}

		public void OnInteractableHostDrop(InteractableHost host)
		{
		}

		public void OnInteractableHostEnter(InteractableHost host)
		{
		}

		public void OnInteractableHostExit(InteractableHost host)
		{
		}

		public void OnInteractableHostStay(InteractableHost host)
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
