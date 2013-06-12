using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SuecaTournamentManager.Utils
{
    class DatabaseManager
    {
        private static DatabaseManager databaseManager;
        private static ISessionFactory sessionFactory;

        private DatabaseManager()
        {
        }

        public static DatabaseManager Instance
        {
            get
            {
                if (databaseManager == null)
                {
                    databaseManager = new DatabaseManager();
                }
                return databaseManager;
            }
        }

        public ISession OpenSession()
        {
            if (sessionFactory == null)
            {
                Configuration cfg = new Configuration();
                cfg.Configure();
                cfg.AddAssembly(Assembly.GetCallingAssembly());
                sessionFactory = cfg.BuildSessionFactory();
            }

            return sessionFactory.OpenSession();
        }

    }
}

