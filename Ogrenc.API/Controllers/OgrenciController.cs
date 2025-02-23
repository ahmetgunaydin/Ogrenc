﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ogrenc.API.Concrete;
using Ogrenc.Business.Abstract;
using Ogrenc.Entities;

namespace Ogrenc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class OgrenciController : ControllerBaseGeneric<OgrenciDTO>
    {
        IGenericService<OgrenciDTO> service;
        public OgrenciController(IGenericService<OgrenciDTO> _service) : base(_service)
        {
            service = _service;
        }
    }
}
