using PersonRepository.Interface;
using PersonRepository.CSV;
using PersonRepository.Service;
using System;

namespace PersonRepository.Factory
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository(RepositoryType repositoryType)
        {
            IPersonRepository repository;

            switch (repositoryType)
            {
                case RepositoryType.CSVRepository:
                    repository = new CSVRepository();
                    break;
                case RepositoryType.ServiceRepository:
                    repository = new ServiceRepository();
                    break;
                default:
                    throw new ArgumentException("Invalid repository type");
            }

            return repository;
        }
    }

    public enum RepositoryType
    {
        CSVRepository,
        ServiceRepository
    }
}
