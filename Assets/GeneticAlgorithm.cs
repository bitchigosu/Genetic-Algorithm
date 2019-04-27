using System;
using System.Collections.Generic;

public class GeneticAlgorithm<T>
{
    public List<DNA<T>> Population { get; private set; }
    public int Generation { get; private set; }
    public float MutationRate;
    private Random random;

	public GeneticAlgorithm(int populationSize,int dnaSize, Random random, Func<T> getRandomGene, Func<float, int> fitnessFunction
        , float mutationRate = 0.01f)
	{
        Generation = 1;
        MutationRate = mutationRate;
        Population = new List<DNA<T>>();
        this.random = random;

        for (int i = 0; i < populationSize; i++)
        {
            Population.Add(new DNA<T>(dnaSize, random, getRandomGene, fitnessFunction, true));
        }
	}

    public void NewGeneration()
    {
        if (Population.Count <= 0)
        {
            return;
        }
        CalculateFitness();
        List<DNA<T>> newPopulation = new List<DNA<T>>();

    }

    private void CalculateFitness()
    {
        throw new NotImplementedException();
    }
}
