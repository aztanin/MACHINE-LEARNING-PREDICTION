using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipeline = new LearningPipeline
            {
                new TextLoader("Sale.csv").CreateFrom<SaleModel>(useHeader: true, separator: ','),
                new ColumnConcatenator("Features", "Month","Year"),
                new GeneralizedAdditiveModelRegressor()
            };

            var model = pipeline.Train<SaleModel, SalePrediction>();


            var predicted_month = 4;
            var predicted_year = 2019;

            var prediction = model.Predict(new SaleModel
            {
                Month = predicted_month,
                Year = predicted_year
            });

            Console.WriteLine();
            Console.WriteLine($"Predicted sale for {predicted_month}-{predicted_year} is {prediction.PredictedSale}");

            Console.ReadLine();
        }
    }
}
