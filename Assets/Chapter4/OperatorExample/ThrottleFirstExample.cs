using System;
using Chapter2.Event;
using Chapter2.Event.Rx;
using UniRx;
using UnityEngine;

namespace Chapter4.OperatorExample{
	public class ThrottleFirstExample : MonoBehaviour{
		private void Start (){
			this.GetComponent<SecondsCounterRx>().OnCountUp
				.ThrottleFirst(TimeSpan.FromSeconds(3f))//イベントが流れてきたらその後3秒間イベントを通さなくする
				.Subscribe(n => Debug.Log("Hi,im throttleFirstEx.count is "+n));
		}
	}
}