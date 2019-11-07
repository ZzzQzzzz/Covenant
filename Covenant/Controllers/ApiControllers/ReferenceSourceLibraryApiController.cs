﻿// Author: Ryan Cobb (@cobbr_io)
// Project: Covenant (https://github.com/cobbr/Covenant)
// License: GNU GPLv3

using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using Covenant.Core;
using Covenant.Models;
using Covenant.Models.Grunts;

namespace Covenant.Controllers.ApiControllers
{
    [Authorize(Policy = "RequireJwtBearer")]
    [ApiController]
    [Route("api/referencesourcelibraries")]
    public class ReferenceSourceLibraryApiController : Controller
    {
        private readonly CovenantContext _context;

        public ReferenceSourceLibraryApiController(CovenantContext context)
        {
            _context = context;
        }

        // GET: api/referencesourcelibraries
        [HttpGet(Name = "GetReferenceSourceLibraries")]
        public async Task<ActionResult<IEnumerable<ReferenceSourceLibrary>>> GetReferenceSourceLibraries()
        {
            return Ok(await _context.GetReferenceSourceLibraries());
        }

        // GET api/referencesourcelibraries/{id}
        [HttpGet("{id}", Name = "GetReferenceSourceLibrary")]
        public async Task<ActionResult<ReferenceSourceLibrary>> GetReferenceSourceLibrary(int id)
        {
            try
            {
                return await _context.GetReferenceSourceLibrary(id);
            }
            catch (ControllerNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ControllerBadRequestException e)
            {
                return BadRequest(e.Message);
            }
            catch (ControllerUnauthorizedException)
            {
                return new UnauthorizedResult();
            }
        }

        // POST api/referencesourcelibraries
        [HttpPost(Name = "CreateReferenceSourceLibrary")]
        public async Task<ActionResult<ReferenceSourceLibrary>> CreateReferenceSourceLibrary([FromBody]ReferenceSourceLibrary library)
        {
            try
            {
                ReferenceSourceLibrary createdLibrary = await _context.CreateReferenceSourceLibrary(library);
                return CreatedAtRoute(nameof(GetReferenceSourceLibrary), new { id = createdLibrary.Id }, createdLibrary);
            }
            catch (ControllerNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ControllerBadRequestException e)
            {
                return BadRequest(e.Message);
            }
            catch (ControllerUnauthorizedException)
            {
                return new UnauthorizedResult();
            }
        }

        // PUT api/referencesourcelibraries
        [HttpPut(Name = "EditReferenceSourceLibrary")]
        public async Task<ActionResult<ReferenceSourceLibrary>> EditReferenceSourceLibrary([FromBody]ReferenceSourceLibrary library)
        {
            try
            {
                return await _context.EditReferenceSourceLibrary(library);
            }
            catch (ControllerNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ControllerBadRequestException e)
            {
                return BadRequest(e.Message);
            }
            catch (ControllerUnauthorizedException)
            {
                return new UnauthorizedResult();
            }
        }

        // DELETE api/referencesourcelibraries/{id}
        [HttpDelete("{id}", Name = "DeleteReferenceSourceLibrary")]
        public async Task<ActionResult> DeleteReferenceSourceLibrary(int id)
        {
            try
            {
                await _context.DeleteReferenceSourceLibrary(id);
                return new NoContentResult();
            }
            catch (ControllerNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (ControllerBadRequestException e)
            {
                return BadRequest(e.Message);
            }
            catch (ControllerUnauthorizedException)
            {
                return new UnauthorizedResult();
            }
        }
    }
}
