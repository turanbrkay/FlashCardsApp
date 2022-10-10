using flashCards.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace flashCards
{
    public class SQLiteHelper
    {
        private readonly SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<vocabularyModel>();

        }

        public Task<int> CreateVocabulary (vocabularyModel myVocabulary)
        {
            return db.InsertAsync(myVocabulary);
        }

        public Task<List<vocabularyModel>>ReadVocabulary()
        {
            return db.Table<vocabularyModel>().ToListAsync();
        }

        public Task <int> UpdateVocabulary (vocabularyModel myVocabulary)
        {
            return db.UpdateAsync(myVocabulary);
        }

        public Task<int> DeleteVocabulary (vocabularyModel myVocabulary)
        {
            return db.DeleteAsync(myVocabulary);
        }

    }
}
