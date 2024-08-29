using GymProject.Data;
using GymProject.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GymProject.EndPoints;

public static class ReasonEndPoints
{
    public static RouteGroupBuilder MapReasonEndPoints(this WebApplication app)
    {
        var group = app.MapGroup("reasons");

        group.MapGet("/", async (GymContext dbContext) =>
        {
            await dbContext.Reasons
            .Include(reason => reason.NameOfReason)
            .Select(reason => reason.ToContract())
            .AsNoTracking()
            .ToListAsync();
        });
        return group;
    }
}
