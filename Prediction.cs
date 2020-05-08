using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineLearningForKids
{
    public class Prediction
    {
        public static string _predictSingleImage = "";
        public static string _tahminSonuc = "";
        public static string _BasarimOrani = "";
        public static string _LossDegeri = "";
        public string  ClassifySingleImage(MLContext mlContext, ITransformer model,string img)
        {
            _predictSingleImage = img;
            //Resim yolu seçtirilecek
            var imageData = new ImageData()
            {
                ImagePath = _predictSingleImage
            };

            // Seçilen resime göre tahmin işlemi yapılacak
            var predictor = mlContext.Model.CreatePredictionEngine<ImageData, ImagePrediction>(model);
            var prediction = predictor.Predict(imageData);

            //Sonucu Ekrana Basma
            return _tahminSonuc = prediction.PredictedLabelValue;
        }
    }
}
