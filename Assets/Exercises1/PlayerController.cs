using UnityEngine;

namespace Exercises1{
	public class PlayerController : MonoBehaviour{
		[SerializeField] private UnityChan2DController unityChan2DController;

		private void Start(){
			//paceKeyObserverのイベントを監視してJump()を実行
		}

		//このメソッドを実行すればユニティちゃんがジャンプする
		private void Jump(){
			unityChan2DController.Move(0,true);
		}
	}
}