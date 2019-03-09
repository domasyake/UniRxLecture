using UnityEngine;

namespace Chapter2.Dependencies{
	public class ButtonEx:MonoBehaviour{
		[SerializeField] private Hoge hoge;
		
		private void Clicked(){
			hoge.Foo();
		}
	}
}

