using UnityEngine;

namespace Exercises1{
	public class SpaceKeyObserver : MonoBehaviour {
		
		//イベント発行用のSubjectを用意
		
		private void Update () {
			if (Input.GetKeyDown(KeyCode.Space)){
				Debug.Log("SpaceKey down!");
				//イベントを発行
			}
		}
	}
}
