using Exo.WebAPi.Models;
using Exo.WebAPi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Exo.WebAPi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class ProjetosController : ControllerBase
  {
    private readonly ProjetoRepository _projetoRepository;
    
    public ProjetosController(ProjetoRepository projetoRepository)
    {
      _projetoRepository = projetoRepository;
    }

    [HttpGet]
    public IActionResult Listar()
    {
      return Ok(_projetoRepository.Listar());
    }

    [HttpPost]
    public IActionResult Cadastrar(Projeto projeto)
    {
      _projetoRepository.Cadastrar(projeto);
      return StatusCode(201);
    }

    [HttpGet("{id}")]
    public IActionResult BuscarPorId(int id)
    {
      Projeto projeto = _projetoRepository.BuscarPorId(id);
      if(projeto == null)
      {
        return NotFound();
      }
      return Ok(projeto);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarProjeto(int id, Projeto projeto)
    {
      _projetoRepository.Atualizar(id, projeto);
      return StatusCode(204);
    }

    [HttpDelete("{id}")]
    public IActionResult DeletarProjeto(int id)
    {
      try{
        _projetoRepository.Deletar(id);
        return StatusCode(204);
      }catch(Exception e)
      {
        return BadRequest();
      }
    }
  }
}