using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class ButtonsToHubAndReset : MonoBehaviour
	{
		[Header("Level Loader")]
		public LevelCrateReference nextLevel;

		public LevelCrateReference hubCrate;

		public LevelCrateReference loadScreenLevel;

		public Spawnable vfxFadeOutSpawnable;

		public void ResetLevel()
		{
		}

		public void ReturnToHub()
		{
		}

		public void NextLevel()
		{
		}

		private void LoadFXAndLevel(LevelCrateReference level)
		{
		}
	}
}
