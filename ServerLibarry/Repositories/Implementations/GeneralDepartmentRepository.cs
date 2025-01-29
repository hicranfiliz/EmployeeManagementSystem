
using BaseLibrary.Responses;
using ServerLibarry.Repositories.Contracts;

namespace ServerLibarry.Repositories.Implementations;

public class GeneralDepartmentRepository : IGenericRepositoryInterface<GeneralResponse>
{
    public Task<GeneralResponse> DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<GeneralResponse>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<GeneralResponse> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<GeneralResponse> Insert(GeneralResponse item)
    {
        throw new NotImplementedException();
    }

    public Task<GeneralResponse> Update(GeneralResponse item)
    {
        throw new NotImplementedException();
    }
}
