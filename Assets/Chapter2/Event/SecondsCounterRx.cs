using System;
using UniRx;
using UnityEngine;

namespace Chapter2.Event{
	public class SecondsCounterRx : MonoBehaviour{
		[SerializeField] private int countTime;//インスペクタからカウントする秒数を変更できるように
		private int timeCounter;

		private readonly Subject<int> secondsStream = new Subject<int>(); //<T>の値をイベントとして流す

		public IObservable<int> OnCountUp => secondsStream; //プロパティを使ってイベントとして外部に公開

		
		private void Update(){
			timeCounter += 1;
			if (timeCounter % (countTime * 60) == 0){//60fpsなので
				secondsStream.OnNext(timeCounter / 60); //秒数をイベントとして発行
			}
		}
	}
}

