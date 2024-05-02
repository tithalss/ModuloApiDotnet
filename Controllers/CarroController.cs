using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Modulo_API.Context;
using Modulo_API.Models;

namespace Modulo_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ContextOrganizer _context;

        public CarroController(ContextOrganizer context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Carro carro)
        {
            _context.Add(carro);
            _context.SaveChanges();
            return Ok(carro);
        }
        [HttpGet("id")]
        public IActionResult ObterPorId(int id)
        {
            var carro = _context.Carros.Find(id);
            if (carro == null)
            {
                return NotFound();
            }
            return Ok(carro);
        }
        [HttpGet("ObterPorMarca")]
        public IActionResult ObterPorMarca(string marca)
        {
            var carros = _context.Carros.Where(x => x.Marca.Contains(marca)).ToList();
            if (carros == null)
            {
                return NotFound();
            }
            return Ok(carros);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, Carro carro)
        {
            var carroBd = _context.Carros.Find(id);

            if (carroBd == null)
            {
                return NotFound();
            }
            carroBd.Marca = carro.Marca;
            carroBd.Modelo = carro.Modelo;
            carroBd.Tipo = carro.Tipo;
            carroBd.Ano = carro.Ano;
            carroBd.Cor = carro.Cor;
            carroBd.Available = carro.Available;
            carroBd.Valor = carro.Valor;

            _context.Carros.Update(carroBd);
            _context.SaveChanges();

            return Ok(carroBd);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var carroBd = _context.Carros.Find(id);
            if (carroBd == null)
            {
                return NotFound();
            }
            _context.Carros.Remove(carroBd);
            _context.SaveChanges();

            return NoContent();
        }
    }
}