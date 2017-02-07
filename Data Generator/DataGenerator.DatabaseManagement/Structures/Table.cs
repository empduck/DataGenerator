using System.Collections.Generic;

namespace DataGenerator.DatabaseManagement.Structures
{
    public class Table
    {
        public List<Row> Rows { get; set; } = new List<Row>();
    }
}
