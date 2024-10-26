using AutoMapper;

namespace CivicSystem.Services.Mapping.Contracts
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IProfileExpression configuration);
    }
}
