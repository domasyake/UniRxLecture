using UnityEngine;
using UnityEngine.UI;

namespace Chapter2.Dependencies{
	public class Fuga : MonoBehaviour{
		private void Awake(){
			this.GetComponent<Button>().onClick.AddListener(Bar);//イベント監視するヨ
		}
		public void Bar(){
			Debug.Log("Barrrrrrrrrrrrr");
		}
	}
}