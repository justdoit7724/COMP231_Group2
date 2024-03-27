using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;

namespace COMP231_Group2
{
    internal class AIManager
    {
        private AIManager() {

            MLContext context = new MLContext();

            // 1] Import data 
            List<InputModel> data = new List<InputModel>();
            List<House> houseData = HouseDatabase.GenerateSampleData().ToList();
            for(int i=0; i< houseData.Count; i++)
            {
                InputModel elem = new InputModel();
                elem.RoomCount = houseData[i].RoomCount;
                elem.BathCount = houseData[i].BathCount;
                elem.Size = houseData[i].Size;
                switch(houseData[i].Region)
                {
                    case "Downtown Toronto":
                        elem.Region = 0;
                        break;
                    case "East York":
                        elem.Region = 1;
                        break;
                    case "York":
                        elem.Region = 2;
                        break;
                    case "Junction":
                        elem.Region = 3;
                        break;
                }
                elem.Furnished = Convert.ToInt32(houseData[i].Furnished);
                elem.ParkingAvailable = Convert.ToInt32(houseData[i].ParkingAvailable);
                elem.Price = elem.RoomCount * 10 + elem.BathCount * 20 + elem.Size + (4 - elem.Region) * 100 + elem.Furnished * 200 + elem.ParkingAvailable * 300;

                data.Add(elem);
            }

            // 2] Training Data
            IDataView trainingData = context.Data.LoadFromEnumerable(data);

            // 3] Prepare data 
            var estimator = context.Transforms.Concatenate("Features", new[] { "RoomCount", "BathCount", "Size","Region","Furnished", "ParkingAvailable" });

            // 4] Create pipeline
            var pipeline = estimator.Append(context.Regression.Trainers.Sdca(labelColumnName: "Price", maximumNumberOfIterations: 1000));

            // 5] Train Model
            var model = pipeline.Fit(trainingData);

            // 6] Create Predaction Engine
            m_predictionEngine = context.Model.CreatePredictionEngine<InputModel, ResultModel>(model);

            // 7] Predict data
            //var experience = new InputModel { YearsOfExperience = 5 };
            var experience = new InputModel { RoomCount = 2, BathCount = 1, Size=400,Region=0,Furnished=1,ParkingAvailable=1 };

            var result = m_predictionEngine.Predict(experience);
        }
        private static AIManager instance = null;
        public static AIManager Instance
        {
            get
            {
                if(instance == null)
                    instance = new AIManager();
                return instance;
            }
        }

        private PredictionEngine<InputModel, ResultModel> m_predictionEngine;

        private InputModel Data2Input(House data)
        {
            InputModel elem = new InputModel();
            elem.RoomCount = data.RoomCount;
            elem.BathCount = data.BathCount;
            elem.Size = data.Size;
            switch (data.Region)
            {
                case "Downtown Toronto":
                    elem.Region = 0;
                    break;
                case "East York":
                    elem.Region = 1;
                    break;
                case "York":
                    elem.Region = 2;
                    break;
                case "Junction":
                    elem.Region = 3;
                    break;
            }
            elem.Furnished = Convert.ToInt32(data.Furnished);
            elem.ParkingAvailable = Convert.ToInt32(data.ParkingAvailable);
            elem.Price = data.Price;
            return elem;
        }

        public float GetPredict(House input)
        {
            return m_predictionEngine.Predict(Data2Input(input)).Price;
        }
    }
}
