﻿using ASP_CORE_BASIC_NET_6_API.Data;
using ASP_CORE_BASIC_NET_6_API.Models.Domain;
using ASP_CORE_BASIC_NET_6_API.Repositories.Interfaces;

namespace ASP_CORE_BASIC_NET_6_API.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly DBContextBase _dbContext;

        public WalletRepository(DBContextBase dBContext)
        {
            this._dbContext = dBContext;
        }

        public IEnumerable<Wallet> GetAll()
        {
            return _dbContext.Wallets.ToList();
        }
    }
}
