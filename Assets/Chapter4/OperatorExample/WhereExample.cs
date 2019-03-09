using Chapter2.Event;
using UniRx;
using UnityEngine;

namespace Chapter4.OperatorExample{
	public class WhereExample : MonoBehaviour{
		private void Start (){
			this.GetComponent<SecondsCounterRx>().OnCountUp
				.Where(n=>n%2==0)//流れてきたイベントの値が偶数の時のみ通す
				.Subscribe(n => Debug.Log("Hi,im whereEx.count is "+n));
		}
	}
}
