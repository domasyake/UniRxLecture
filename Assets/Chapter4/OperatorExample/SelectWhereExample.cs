using Chapter2.Event;
using UniRx;
using UnityEngine;

namespace Chapter4.OperatorExample{
	public class SelectWhereExample : MonoBehaviour{
		private void Start (){
			this.GetComponent<SecondsCounterRx>().OnCountUp
				.Select(n=>n.ToString())//stringに変換して
				.Where(n=>n.Length==2)//2桁なら通す
				.Subscribe(n => Debug.Log("Hi,im selectWhereEx.count is "+n));
		}
	}
}