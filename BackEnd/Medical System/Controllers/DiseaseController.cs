﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS.Application.DTOs.Hospital;
using MS.Application.DTOs.Disease;
using MS.Application.Helpers.Response;
using MS.Application.Interfaces;

namespace Medical_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiseaseController : ControllerBase
    {
        #region Constructor/props
        private readonly IDiseaseService _service;
        public DiseaseController(IDiseaseService service)
        {
            _service = service;
        }
        #endregion

        #region Methods
        [HttpGet("{ID:int}")]
        public async Task<IActionResult> GetSingleAsync([FromRoute] int ID)
        {
            var response = await _service.GetDiseaseAsync(ID);
            
            return this.CreateResponse(response);
        }
        
        [HttpDelete("{ID:int}")]
        public async Task<IActionResult> DeleteSingleAsync(int ID)
        {
            var response = await _service.DeleteDiseaseAsync(ID);
            
            return this.CreateResponse(response);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateDiseaseDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.CreateDiseaseAsync(model);
            
            return this.CreateResponse(response);
        }
        [HttpPut]
        public async Task<IActionResult> PutSingleAsync([FromBody] UpdateDiseaseDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var response = await _service.UpdateDiseaseAsync(model);
            
            return this.CreateResponse(response);
        }
        #endregion
    }
}