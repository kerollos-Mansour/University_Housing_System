﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UniversityHousingSystem.API.APIBases;
using UniversityHousingSystem.Core.Features.College.Queries.Models;
using UniversityHousingSystem.Core.Features.Events.Commands.Models;
using UniversityHousingSystem.Core.Features.Events.Queries.Models;
using UniversityHousingSystem.Core.Features.Events.Queries.Results;
using UniversityHousingSystem.Data.AppMetaData;

namespace UniversityHousingSystem.API.Controllers
{
    [ApiController]
    [Route(Router.CollegeRouting.Prefix)]
    public class CollegeController : AppController
    {
        public CollegeController(IMediator mediator) : base(mediator) { }

        #region Queries

        [HttpGet("list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCollegesAsync()
        {
            var result = await _mediator.Send(new GetAllCollegesQuery());
            return NewResult(result);
        }
        [HttpGet("departments/{collegeId}")]
        [ProducesResponseType(typeof(GetAllCollegeDepartmentResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCollegeDepartmentsByCollegeIdAsync(int collegeId)
        {
            var result = await _mediator.Send(new GetCollegeDepartmentsByCollegeIdQuery() { CollegeId = collegeId });
            return NewResult(result);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetCollegeByIdAsync(int id)
        {
            var result = await _mediator.Send(new GetCollegeByIdQuery(id));
            return NewResult(result);
        }
        #endregion

        #region Commands
        [Authorize(Roles = "Admin,Employee")]
        [HttpPost("create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateCollege([FromForm] CreateCollegeCommand model)
        {
            var result = await _mediator.Send(model);
            return NewResult(result);
        }
        [Authorize(Roles = "Admin,Employee")]
        [HttpPut("update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> EditCollege([FromForm] UpdateCollegeCommand model)
        {
            var result = await _mediator.Send(model);
            return NewResult(result);
        }
        [Authorize(Roles = "Admin,Employee")]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteCollege([FromRoute] int id)
        {
            var result = await _mediator.Send(new DeleteCollegeCommand { CollegeId = id });
            return NewResult(result);
        }

        #endregion
    }
}

