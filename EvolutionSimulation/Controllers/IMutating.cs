
using EvolutionSimulation.Models;
using System;

interface IMutating
{
	void Move(Tuple<float, float> centerFood, Tuple<float, float> red,
            Tuple<float, float> green, Tuple<float, float> blue, float time);

	void Eat<T>(T obj) where T : class;
	void Init(Genome g);
	Tuple<float, float> getCoordinates();
	void SetCoordinates(Tuple<int, int> coord);
	public Color getColor();
	void SetColor(Color c);
	public float GetDamage(IMutating source);
}
