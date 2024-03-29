﻿
// This file was auto-generated by ML.NET Model Builder. 

using MovieRecommenderMLModel_ConsoleApp;

// Create single instance of sample data from first line of dataset for model input
MovieRecommenderMLModel.ModelInput sampleData = new MovieRecommenderMLModel.ModelInput()
{
    UserId = 1F,
    MovieId = 3F,
};



Console.WriteLine("Using model to make single prediction -- Comparing actual Rating with predicted Rating from sample data...\n\n");


Console.WriteLine($"UserId: {1F}");
Console.WriteLine($"MovieId: {1F}");
Console.WriteLine($"Rating: {4F}");


var predictionResult = MovieRecommenderMLModel.Predict(sampleData);
Console.WriteLine($"\n\nPredicted Rating: {predictionResult.Score}\n\n");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

