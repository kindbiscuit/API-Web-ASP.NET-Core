﻿using LivrariaDoPepeu.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaDoPepeu.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ApiBaseController
    {
        IAuthService _service;
        public AuthController(IAuthService service)
        {
            _service = service;
        }
        /// <summary>
        /// Cria um novo usuário para autenticação.
        /// </summary>
        /// <param name="identityUser"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Register")]
        [AllowAnonymous]
       
        public IActionResult Register([FromBody] IdentityUser identityUser)
        {
            IdentityResult result = _service.Create(identityUser).Result;
            identityUser.PasswordHash = null;
            return result.Succeeded ?
                ApiOk(identityUser) :
                ApiBadRequest(result.Errors, "Erro ao criar usuário");
        }
        /// <summary>
        /// Cria um token de um usuário existente para autenticação.
        /// </summary>
        /// <param name="identityUser"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Token")]
        [AllowAnonymous]
        public IActionResult Token([FromBody] IdentityUser identityUser)
        {
            try
            {
                return ApiOk(_service.GenerateToken(identityUser));
            }
            catch (Exception e)
            {
                return ApiBadRequest(e, e.Message);
            }
        }
    }
}
