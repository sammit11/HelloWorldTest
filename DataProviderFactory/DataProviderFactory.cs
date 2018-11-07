
using Interfaces;
using Microsoft.Practices.Unity.Configuration;
using Unity;
using System.Configuration;

namespace Entities
{

    public class DataProviderFactory

    {

        private IUnityContainer container { get; set; }

        public DataProviderFactory()

        {
            
            container = new UnityContainer();
            
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection(Constants.Unity);

            section.Configure(container, Constants.DataAccessProviderContainer);

        }

        //public IDataProvider CreateDataProvider()

        //{

        //    return container.Resolve();

        //}

        public IDataProvider CreateDataProvider(string dataProviderName)

        {

            //return container.Resolve(dataProviderName);

            return container.Resolve<IDataProvider>(dataProviderName);

        }

        private static class Constants

        {

            public const string DataAccessProviderContainer = "DataAccessProvider";
            public const string Unity = "unity";

        }

    }

}