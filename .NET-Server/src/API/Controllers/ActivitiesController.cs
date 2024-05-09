using API.Controllers;
using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controller;

public class ActivitiesController(IMediator mediator) : BaseApiController
{
    private readonly IMediator _mediator = mediator;

    [HttpGet] // ~/api/activities
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        Task.Delay(1000).Wait();
        return await _mediator.Send(new Listie.Query());
    }

    [HttpGet("{id}")] // ~/api/activities/GUID
    public ActionResult<Activity> GetActivity(Guid id) // must match Root Parameter
    {
        Task.Delay(1000).Wait();
        return Ok();
    }
}