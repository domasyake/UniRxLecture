using UnityEngine;
using UniRx;

namespace Exercises1{
	public class PlayerController : MonoBehaviour{
		[SerializeField] private UnityChan2DController unityChan2DController;

		private void Start(){
			this.GetComponent<SpaceKeyObserver>().OnSpaceKey //paceKeyObserverのイベントを監視してJump()を実行
				.Subscribe(n => Jump());
		}

		//このメソッドを実行すればユニティちゃんがジャンプする
		private void Jump(){
			unityChan2DController.Move(0,true);
		}
	}
}