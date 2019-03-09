using UnityEngine;

namespace Chapter2.Event{
	public class DisplayNormal : MonoBehaviour{
		[SerializeField]private SecondsCounterNormal secondsCounterNormal;

		private void Awake(){
			secondsCounterNormal.OnCountUp += count => Debug.Log("normal count is " + count);
		}
	}
}

