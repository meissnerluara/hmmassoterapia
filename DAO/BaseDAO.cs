using System;
using System.Collections.Generic;
using System.Text;

namespace hmmassoterapia.DAO
{
    public class BaseDAO
    {
        public DataAcess.DataAccessLayer db { get; }

        public BaseDAO()
        {
            db = new DataAcess.DataAccessLayer();
        }

    }
}
