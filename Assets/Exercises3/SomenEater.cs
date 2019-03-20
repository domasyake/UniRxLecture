using System;
using System.Linq;
using UniRx;
using UnityEngine;

namespace Exercises3{
	public class SomenEater : MonoBehaviour{
		[SerializeField] private SomenSinker somenSinker;

		private void Start(){
			somenSinker.SomenLane
				.Where(n=>n.Length>=3)
				.Buffer(TimeSpan.FromSeconds(2.5f))
				.Where(n=>n.Sum(m=>m.Weight)>10)
				.Subscribe(n => 
					Debug.Log("I eat somen.av="+n.Average(m=>m.Length)+" sum="+n.Sum(m => m.Weight) )
					);
		}
	}
}