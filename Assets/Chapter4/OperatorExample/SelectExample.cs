using Chapter2.Event;
using UniRx;
using UnityEngine;

namespace Chapter4.OperatorExample{
	public class SelectExample : MonoBehaviour{
		private void Start (){
			this.GetComponent<SecondsCounterRx>().OnCountUp
				.Select(n=>(float)n)//float型に変換
				.Subscribe(n => Debug.Log("Hi,im selectEx.count is"+n+
				                          " type is "+n.GetType().Name));
		}
	}
}

