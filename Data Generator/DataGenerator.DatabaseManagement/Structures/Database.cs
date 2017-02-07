using System.Collections.Generic;

namespace DataGenerator.DatabaseManagement.Structures
{
    public class Database
    {
        public List<Table> Tables { get; set; } = new List<Table>();
    }
}
