using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.SalerDb;
using WebApi.EF.SalerDb;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalerInfoesController : ControllerBase
    {
        private readonly SalerDbContext _context;

        public SalerInfoesController(SalerDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 获取所有销售员信息
        /// </summary>
        /// <returns>所有销售员信息</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalerInfo>>> GetSalerInfo()
        {
            return await _context.SalerInfo.ToListAsync();
        }

        /// <summary>
        /// 根据Id获取销售员信息
        /// </summary>
        /// <param name="id">销售员Id</param>
        /// <returns>销售员信息</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<SalerInfo>> GetSalerInfo(int id)
        {
            var salerInfo = await _context.SalerInfo.FindAsync(id);

            if (salerInfo == null)
            {
                return NotFound();
            }

            return salerInfo;
        }

        /// <summary>
        /// 修改SalerInfo
        /// </summary>
        /// <param name="id"></param>
        /// <param name="salerInfo"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalerInfo(int id, SalerInfo salerInfo)
        {
            if (id != salerInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(salerInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalerInfoExists(id))
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

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="salerInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<SalerInfo>> PostSalerInfo(SalerInfo salerInfo)
        {
            _context.SalerInfo.Add(salerInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalerInfo", new { id = salerInfo.Id }, salerInfo);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalerInfo(int id)
        {
            var salerInfo = await _context.SalerInfo.FindAsync(id);
            if (salerInfo == null)
            {
                return NotFound();
            }

            _context.SalerInfo.Remove(salerInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalerInfoExists(int id)
        {
            return _context.SalerInfo.Any(e => e.Id == id);
        }
    }
}
