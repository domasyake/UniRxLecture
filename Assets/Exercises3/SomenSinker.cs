using System;
using UniRx;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Exercises3{
	public class SomenSinker : MonoBehaviour{
		private Subject<Somen> somenStream=new Subject<Somen>();
		public IObservable<Somen> SomenLane => somenStream;

		private void Start(){
			Observable.Interval(TimeSpan.FromSeconds(1))
				.Subscribe(n => {
					var somen = new Somen(Random.Range(1, 10), Random.Range(5, 15));
					Debug.Log("Release somen[length "+somen.Length+",weight "+somen.Weight+"]");
					somenStream.OnNext(somen);
				});
		}
	}
}