using SLZ.Combat;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLZ.Props
{
	[RequireComponent(typeof(CollisionEnterSensor))]
	public class Prop_DamageReceiver : MonoBehaviour, ICollisonReceiver, IEventSystemHandler, IAttackReceiver
	{
		[HideInInspector]
		public Prop_Health p_health;

		public void ReceiveAttack(Attack attack)
		{
		}

		public void ReceiveCollison(Collision collision, float relVelocitySqr, bool isStay = false)
		{
		}
	}
}
