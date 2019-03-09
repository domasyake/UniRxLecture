using Chapter2.Event;
using UniRx;
using UnityEngine;

namespace Chapter4.OperatorExample{
	public class FirstExample : MonoBehaviour{
		private void Start (){
			this.GetComponent<SecondsCounterRx>().OnCountUp
				.First()//1回だけ実行
				.Subscribe(n => Debug.Log("Hi,im FirstEx.count is "+n));
		}
	}
}
