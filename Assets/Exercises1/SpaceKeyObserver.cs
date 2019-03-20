using System;
using UniRx;
using UnityEngine;

namespace Exercises1{
	public class SpaceKeyObserver : MonoBehaviour {
		
		private readonly Subject<Unit> spaceKeyStream=new Subject<Unit>();//イベント発行用のSubjectを用意
		public IObservable<Unit> OnSpaceKey => spaceKeyStream;
		
		private void Update () {
			if (Input.GetKeyDown(KeyCode.Space)){
				Debug.Log("SpaceKey down!");
				spaceKeyStream.OnNext(Unit.Default);//イベントを発行
			}
		}
	}
}
