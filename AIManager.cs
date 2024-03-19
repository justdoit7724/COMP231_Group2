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
            List<InputModel> data = new List<InputModel>
            {
                new InputModel { CLanguage=0, YearsOfExperience = 1, Salary= 39000 },
                new InputModel { CLanguage=0, YearsOfExperience = 1.3F, Salary= 46200 },
                new InputModel { CLanguage=0, YearsOfExperience = 1.5F, Salary= 37700 },
                new InputModel { CLanguage=0, YearsOfExperience = 2, Salary= 43500 },
                new InputModel { CLanguage=0, YearsOfExperience = 2.2F, Salary= 40000 },
                new InputModel { CLanguage=0, YearsOfExperience = 2.9F, Salary= 56000 },
                new InputModel { CLanguage=0, YearsOfExperience = 3, Salary= 60000 },
                new InputModel { CLanguage=0, YearsOfExperience = 3.2F, Salary= 54000 },
                new InputModel { CLanguage=0, YearsOfExperience = 3.3F, Salary= 64000 },
                new InputModel { CLanguage=0, YearsOfExperience = 3.7F, Salary= 57000 },
                new InputModel { CLanguage=0, YearsOfExperience = 3.9F, Salary= 63000 },
                new InputModel { CLanguage=0, YearsOfExperience = 4, Salary= 55000 },
                new InputModel { CLanguage=1, YearsOfExperience = 4, Salary= 58000 },
                new InputModel { CLanguage=1, YearsOfExperience = 4.1F, Salary= 157000 },
                new InputModel { CLanguage=1, YearsOfExperience = 4.5F, Salary= 161000 },
                new InputModel { CLanguage=1, YearsOfExperience = 4.9F, Salary= 168000 },
                new InputModel { CLanguage=1, YearsOfExperience = 5.3F, Salary= 183000 },
                new InputModel { CLanguage=1, YearsOfExperience = 5.9F, Salary= 182000 },
                new InputModel { CLanguage=1, YearsOfExperience = 6, Salary= 194000 },
                new InputModel { CLanguage=1, YearsOfExperience = 6.8F, Salary= 191000 },
                new InputModel { CLanguage=1, YearsOfExperience = 7.1F, Salary= 198000 },
                new InputModel { CLanguage=1, YearsOfExperience = 7.9F, Salary= 201000 },
                new InputModel { CLanguage=1, YearsOfExperience = 8.2F, Salary= 214000 },
                new InputModel { CLanguage=1, YearsOfExperience = 8.9F, Salary= 209000 },
            };

            // 2] Training Data
            IDataView trainingData = context.Data.LoadFromEnumerable(data);

            // 3] Prepare data 
            var estimator = context.Transforms.Concatenate("Features", new[] { "CLanguage", "YearsOfExperience" });

            // 4] Create pipeline
            var pipeline = estimator.Append(context.Regression.Trainers.Sdca(labelColumnName: "Salary", maximumNumberOfIterations: 100));

            // 5] Train Model
            var model = pipeline.Fit(trainingData);

            // 6] Create Predaction Engine
            var predictionEngine = context.Model.CreatePredictionEngine<InputModel, ResultModel>(model);

            // 7] Predict data
            //var experience = new InputModel { YearsOfExperience = 5 };
            var experience = new InputModel { CLanguage = 0, YearsOfExperience = 5 };

            var result = predictionEngine.Predict(experience);
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

        public List<Object> GetDatabase()
        {
            return null;
        }
        public float GetPredict(Object input)
        {
            return 0;
        }
    }
}
