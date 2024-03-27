using Microsoft.ML.Data;

namespace COMP231_Group2
{
    internal class ResultModel
    {
        [ColumnName("Score")]
        public float Price { get; set; }
    }
}