﻿using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
	//Префаб врага
	public Object EnemyPrefab;
	//Расстояние до игрока
	public float Distance = 2;
	//Угол занимаемый врагами (360 - вся окружность)
	public float Angle = 360;
	//Количество врагов
	public int count = 1000;

	// Use this for initialization
	void Start ()
	{
		//Определяем начальную точку
		Vector3 point = transform.position;
		//Переводим <a href="https://poqxert.ru/page/matematika-unity3d-urok-15-vector-otrazhenie-rasstojanie-proekcija-i-ugol" class="perelink">угол</a> в радианы
		Angle = Angle * Mathf.Deg2Rad;                                     

		for (int i = 1; i <= count; i++)
		{
			//Рассчитываем координату Z для врага
			float _z = transform.position.z + Mathf.Cos (Angle / count * i) * Distance;
			//Рассчитываем координату X для врага
			float _x = transform.position.x + Mathf.Sin (Angle / count * i) * Distance;
			point.x = _x;
			point.z = _z;
			//Создаём врага
			Instantiate (EnemyPrefab, point, Quaternion.identity);                          
		}
	}

	 

 
}
