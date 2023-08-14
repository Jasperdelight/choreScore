using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScore.Services;

    public class ChoresService
    {
        private readonly ChoresRepository _choresRepository;
        public ChoresService(ChoresRepository choresRepository)
        {
            _choresRepository = choresRepository;
        }

    internal Chore createChore(Chore choreData)
    {
        Chore chore = _choresRepository.createChore(choreData);
        return chore;
    }

    internal Chore EditChore(Chore choreData)
    {
        Chore chore = _choresRepository.EditChore(choreData);
        return chore;
    }

    internal Chore GetChoreByName(string choreName)
    {
        Chore chore = _choresRepository.GetChoreByName(choreName);
        if (chore == null)
        {
        throw new Exception($"No chore with {choreName}");
        }
        return chore;
    }

    internal List<Chore> GetChoreByType(string choreType)
    {
        List<Chore> chore = _choresRepository.GetChoreByType(choreType);
        if (chore == null)
        {
            throw new Exception($"no chores with {choreType} exist");
        }
        return chore;
    }

    internal List<Chore> GetChores()
        {
            List<Chore> chores = _choresRepository.GetChores();
            return chores;
        }

    internal Chore RemoveChore(string choreName)
    {
        Chore chore = _choresRepository.RemoveChore(choreName);
        return chore;
    }
}
