using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace hmmassoterapia.DAO.DataAcess
{
    public class ProviderFactory
    {

        # region Properties

        public string ConnectionString { get; set; }
        private DbProviderFactory provider;

        public DbProviderFactory Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        # endregion

        # region Constructor

        public ProviderFactory(DbProviderFactory provider)
        {
            this.provider = provider;
        }

        # endregion

        # region Methods

        # endregion 

    }
}
