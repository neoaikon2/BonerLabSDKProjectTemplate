using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlayerRelativeGunSpawns : MonoBehaviour
	{
		public Transform playerDropGunCenterSpawn;

		public GameObject gunDropCanvas;

		private float maxDistFromCenter;

		public Rigidbody playerPelvisRB;

		public void CheckDropLocation()
		{
		}

		public void ToggleSprite(bool active)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
