using Microsoft.AspNetCore.Mvc;
using senai.ifood.domain.Contracts;
using senai.ifood.domain.Entities;

namespace senai.ifood.webapi.Controllers
{


    [Route("api/[controller]")]
    public class RestauranteController : Controller
    {
        private IBaseRepository<RestauranteDomain> _restauranteRepository;

        public RestauranteController(IBaseRepository<RestauranteDomain> restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        [HttpGet]
        public IActionResult GetAction(){
            return Ok(_restauranteRepository.Listar(new string[]{"ProdutosRestaurante"}));
        }


        [HttpGet("{id}")]
        public IActionResult GetAction(int id){
            var restaurante = _restauranteRepository.BuscarPorId(id);
            if(restaurante != null)
                return Ok(restaurante);
            else
                return NotFound();
        }
    }
}