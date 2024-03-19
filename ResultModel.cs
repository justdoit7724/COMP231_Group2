using Microsoft.ML.Data;

namespace COMP231_Group2
{
    internal class ResultModel
    {
        [ColumnName("Score")]
        public float Salary { get; set; }
    }
}