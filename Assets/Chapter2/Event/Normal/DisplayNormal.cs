using UnityEngine;

namespace Chapter2.Event.Normal{
	public class DisplayNormal : MonoBehaviour{
		[SerializeField]private SecondsCounterNormal secondsCounterNormal;

		private void Awake(){
			secondsCounterNormal.OnCountUp += count => Debug.Log("normal count is " + count);
		}
	}
}

