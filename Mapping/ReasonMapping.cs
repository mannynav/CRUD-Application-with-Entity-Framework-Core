using GymProject.Contracts;
using GymProject.DataModelEntities;

namespace GymProject.Mapping;


public static class ReasonMapping
{
    public static ReasonContract ToContract(this Reason reason)
    {
        return new ReasonContract(reason.Id, reason.NameOfReason);
    }
}
