using SLZ.Bonelab;
using UnityEngine;

namespace SLZ.Interaction
{
	public class CylinderFuseGrip : CylinderGrip
	{
		[HideInInspector]
		public FuseInteractionVolume interactionVolume;

		public override void OnAttachedToHand(Hand hand)
		{
		}
	}
}
