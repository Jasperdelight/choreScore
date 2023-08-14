using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScore.Repositories;

    public class ChoresRepository
    {
        private List<Chore> dbChores;

        public ChoresRepository()
        {
            dbChores = new List<Chore>();
            dbChores.Add(new Chore("Take out the trash", false, "Kitchen"));
            dbChores.Add(new Chore("Do the dishes", false, "Kitchen"));
            dbChores.Add(new Chore("Make the bed", false, "Bedroom"));
        }

    internal Chore createChore(Chore choreData)
    {
        dbChores.Add(choreData);
        return choreData;
    }

    internal Chore EditChore(Chore choreData)
    {
        Chore foundChore = GetChoreByName(choreData.Name);
        dbChores.Add(foundChore);
        return foundChore;
    }

    internal Chore GetChoreByName(string choreName)
    {
        Chore foundChore = dbChores.Find(c => c.Name.ToLower() == choreName.ToLower());
        return foundChore;
    }

    internal List<Chore> GetChoreByType(string choreType)
    {
        List<Chore> choresByType = dbChores.FindAll(c => c.Type.ToLower() == choreType.ToLower());
        return choresByType;
    }

    internal List<Chore> GetChores()
        {
            return dbChores;
        }

    internal Chore RemoveChore(string choreName)
    {
        Chore foundChore = GetChoreByName(choreName);
        dbChores.Remove(foundChore);
        return foundChore;
    }
}
