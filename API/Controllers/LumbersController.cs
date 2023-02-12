using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class LumbersController : ControllerBase
    {
        private readonly LumberContext _context;
        public LumbersController(LumberContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Lumber>> GetLumbers()
        {
            return await _context.Lumbers.ToListAsync();
        }

        [HttpGet("Date")]
        public async Task<List<DateTime>> GetDateLumbers()
        {
            return await _context.Lumbers.Select(l => l.Date).OrderBy(l => l.Date).ToListAsync();
        }

        [HttpGet("Open")]
        public async Task<List<double>> GetOpenLumbers()
        {
            return await _context.Lumbers.Select(l => l.Open).ToListAsync();
        }

        [HttpGet("Close")]
        public async Task<List<double>> GetCloseLumbers()
        {
            return await _context.Lumbers.Select(l => l.Close).ToListAsync();
        }

        [HttpGet("AdjClose")]
        public async Task<List<double>> GetAdjCloseLumbers()
        {
            return await _context.Lumbers.Select(l => l.AdjClose).ToListAsync();
        }

        [HttpGet("High")]
        public async Task<List<double>> GetHighLumbers()
        {
            return await _context.Lumbers.Select(l => l.High).ToListAsync();
        }

        [HttpGet("Low")]
        public async Task<List<double>> GetLowLumbers()
        {
            return await _context.Lumbers.Select(l => l.Low).ToListAsync();
        }

        [HttpGet("Volume")]
        public async Task<List<double>> GetVolumeLumbers()
        {
            return await _context.Lumbers.Select(l => l.Volume).ToListAsync();
        }
    }
}