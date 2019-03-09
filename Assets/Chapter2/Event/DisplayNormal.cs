using UnityEngine;

namespace Chapter2.Event{
	public class DisplayNormal : MonoBehaviour{
		[SerializeField]private FiveSecondsCounterNormal fiveSecondsCounterNormal;

		private void Awake(){
			fiveSecondsCounterNormal.OnCountUp += count => Debug.Log("normal count is " + count);
		}
	}
}

