using iTelluro.Explorer.YatMing.Domain.Context;
using iTelluro.Explorer.Infrastruct.CodeFirst.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.Infrastructure.Context.Repository
{
    public class TDataInfoRepository : Repository<T_DataInfo>, ITDataInfoRepository
    {
        public TDataInfoRepository(IQueryableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

    }
}
