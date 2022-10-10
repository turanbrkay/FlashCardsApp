using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace flashCards.Model
{
    public class vocabularyModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
    }
}
