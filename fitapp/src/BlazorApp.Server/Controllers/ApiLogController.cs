﻿using BlazorApp.Server.Middleware.Wrappers;
using BlazorApp.Server.Services;
using BlazorApp.Shared.AuthorizationDefinitions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ApiLogController : ControllerBase
    {
        private readonly IApiLogService _apiLogService;

        public ApiLogController(IApiLogService apiLogService)
        {
            _apiLogService = apiLogService;
        }

        // GET: api/ApiLog
        [HttpGet]
        public async Task<ApiResponse> Get()
        {
            return await _apiLogService.Get();
        }

        // GET: api/ApiLog/ApplicationUserId
        [HttpGet("[action]")]
        [Authorize(Policy = Policies.IsAdmin)]
        public async Task<ApiResponse> GetByApplicationUserId(string userId)
        {
            return await _apiLogService.GetByApplictionUserId(new Guid(userId));
        }
    }
}