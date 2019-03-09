using System;
using UniRx;
using UnityEngine;

namespace Chapter2.Event{
	public class FiveSecondsCounterRx : MonoBehaviour{

		private readonly Subject<int> fiveSecondsStream = new Subject<int>(); //Subjectのインスタンスを用意

		public IObservable<int> OnCountUp => fiveSecondsStream; //プロパティを使ってイベントとして外部に公開

		private int timeCounter;

		private void Update(){
			timeCounter += 1;
			if (timeCounter % (5 * 60) == 0){//60fpsだから300nで5n秒
				fiveSecondsStream.OnNext(timeCounter / 60); //秒数を引数にイベントを起こす
			}
		}
	}
}

