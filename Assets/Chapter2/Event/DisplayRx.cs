using UnityEngine;
using UniRx;

namespace Chapter2.Event{
	public class DisplayRx : MonoBehaviour{
		[SerializeField]private FiveSecondsCounterRx fiveSecondsCounterRx;

		private void Awake(){
			fiveSecondsCounterRx.OnCountUp
				.Subscribe(count => Debug.Log("rx count is " + count));
			//countはイベントで通知された値を格納する一次変数。ちゃんとした名前じゃなくてnで済ませることが多い。
			//ラムダ式で処理を登録しているがこの式は
			//void Hoge(int count){
			//	Debug.Log("rx count is " + count);
			//}
			//と同義
		}
	}
}

