using Exo.WebAPi.Contexts;
using Exo.WebAPi.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo.WebAPi.Repositories
{

  public class ProjetoRepository
  {
    private readonly ExoContext _context;
    public ProjetoRepository(ExoContext context)
    {
      _context = context;
    }

    public List<Projeto> Listar()
    {
      return _context.Projetos.ToList();
    }
  }

}