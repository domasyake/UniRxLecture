using System;
using System.Linq;
using Chapter2.Event.Rx;
using UniRx;
using UnityEngine;

namespace Chapter4.OperatorExample{
	public class BufferExample : MonoBehaviour{
		private void Start (){
			this.GetComponent<SecondsCounterRx>().OnCountUp
				.Buffer(3)//3個ごとに纏めて流す（Collectionに変換される
				.Subscribe(n => //貯めた値の最後を表示
					Debug.Log("Hi,im bufferEx.The end of the event value is "+n.Last()));
		}
	}
}