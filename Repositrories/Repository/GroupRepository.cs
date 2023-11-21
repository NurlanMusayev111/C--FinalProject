using Domain.Models;
using Repository.Data;
using Repository.Enums;
using Repository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    {
        public List<Group> Search(string name)
        {
            return AppDbContext<Group>.Datas.Where(m => m.Name.Contains(name)).ToList();
        }

        public List<Group> Sorting(SortType sort)
        {
            switch (sort)
            {
                case SortType.Ascending:
                    return AppDbContext<Group>.Datas.OrderBy(m => m.Id).ToList();
                case SortType.Descending:
                    return AppDbContext<Group>.Datas.OrderByDescending(m => m.Id).ToList();
            }

            return default;
        }
    }
}
