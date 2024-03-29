using UnityEngine;

namespace SLZ.Props
{
	[CreateAssetMenu(fileName = "Station", menuName = "StressLevelZero/Radio/Station")]
	public class RadioStation : ScriptableObject
	{
		public string stationName;

		public RadioSong[] trackList;

		public bool randomized;
	}
}
