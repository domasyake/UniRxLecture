using UnityEngine;

namespace Chapter2.Event.Normal{
	public class SecondsCounterNormal : MonoBehaviour{
		[SerializeField] private int countTime;//インスペクタからカウントする秒数を変更できるように
		private int timeCounter;
		
		public delegate void SecondsEventHandler(int current_seconds);//イベント用delegate定義

		public event SecondsEventHandler OnCountUp;//イベントハンドラ定義
		
		private void Update(){
			timeCounter += 1;
			if (timeCounter% (countTime*60)==0){//60fpsなので
				OnCountUp?.Invoke(timeCounter/60);//秒数を引数にイベントを起こす
			}
		}
	}
}

