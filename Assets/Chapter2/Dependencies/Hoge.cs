using UnityEngine;
using UnityEngine.UI;

namespace Chapter2.Dependencies{
	public class Hoge : MonoBehaviour {
		private void Awake(){
			//ボタンをGetComponentし、OnClickイベントにFoo()をAddListenerメソッドを使い登録
			//イベントを監視する＝イベント発行者へ（自分を）登録する
			this.GetComponent<Button>().onClick.AddListener(Foo);
		}
		public void Foo(){
			Debug.Log("Fooooooo");
		}
	}
}
