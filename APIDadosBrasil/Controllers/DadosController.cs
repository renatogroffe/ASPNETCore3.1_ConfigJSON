using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APIDadosBrasil.Models;

namespace APIDadosBrasil.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DadosController : ControllerBase
    {
        [HttpGet]
        public DadosPais Get([FromServices]DadosPais dados)
        {
            return dados;
        }
    }
}