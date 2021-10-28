using System.Collections.Generic;
using System.Threading.Tasks;
using DotNetCoreMaterialsAndComponents.Application.DTOs;
using DotNetCoreMaterialsAndComponents.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DotNetCoreMaterialsAndComponents.API.Controllers
{
    [Route("/api/v1/[Controller]")]
    [ApiController]
    public class MaterialController : Controller
    {
        private readonly IMaterialService _service;

        public MaterialController(IMaterialService service){
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Material>>> Get(){
            var materials = await _service.GetMaterials();
            return Ok((from m in materials select *));
        }
        
        [HttpGet("{materialRef}")]
        public async Task<ActionResult<Material>> GetByMaterialRef([FromRoute] string materialRef) => Ok(await _service.GetByMaterialRef(materialRef));

        [HttpPost]
        public async Task<ActionResult<Material>> Create([FromBody] Material material) => Ok(await _service.Create(material));

        [HttpPut]
        public async Task<ActionResult<Material>> Update([FromBody] Material material) => Ok(await _service.Update(material));

        [HttpDelete("{materialRef}")]
        public async Task<ActionResult> Delete([FromRoute] string materialRef) {
            await _service.Remove(await _service.GetByMaterialRef(materialRef));
            return Ok();
        }
    }
}