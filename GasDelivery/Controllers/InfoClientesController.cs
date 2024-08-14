using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GasDelivery.Models;

namespace GasDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoClientesController : ControllerBase
    {
        private readonly Contexto _context;

        public InfoClientesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/InfoClientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InfoCliente>>> GetInfoClientes()
        {
            return await _context.InfoClientes.ToListAsync();
        }

        // GET: api/InfoClientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InfoCliente>> GetInfoCliente(int id)
        {
            var infoCliente = await _context.InfoClientes.FindAsync(id);

            if (infoCliente == null)
            {
                return NotFound();
            }

            return infoCliente;
        }

        // PUT: api/InfoClientes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInfoCliente(int id, InfoCliente infoCliente)
        {
            if (id != infoCliente.Id)
            {
                return BadRequest();
            }

            _context.Entry(infoCliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InfoClienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/InfoClientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InfoCliente>> PostInfoCliente(InfoCliente infoCliente)
        {
            _context.InfoClientes.Add(infoCliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInfoCliente", new { id = infoCliente.Id }, infoCliente);
        }

        // DELETE: api/InfoClientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInfoCliente(int id)
        {
            var infoCliente = await _context.InfoClientes.FindAsync(id);
            if (infoCliente == null)
            {
                return NotFound();
            }

            _context.InfoClientes.Remove(infoCliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InfoClienteExists(int id)
        {
            return _context.InfoClientes.Any(e => e.Id == id);
        }
    }
}
