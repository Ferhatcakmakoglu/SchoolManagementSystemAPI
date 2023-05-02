using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class SchoolController : BaseController
    {
        private readonly IMapper _mapper;
        public readonly IService<School> _service;

        public SchoolController(IMapper mapper, IService<School> service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> All() 
        {
            var schools = await _service.GetAllAsync();
            var schoolsDto = _mapper.Map<List<SchoolDto>>(schools.ToList());
            return CreateActionResult(CustomResponseDto<List<SchoolDto>>.Succes(200,schoolsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var school = await _service.GetByIdAsync(id);
            var schoolDto = _mapper.Map<SchoolDto>(school);
            return CreateActionResult(CustomResponseDto<SchoolDto>.Succes(200,schoolDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(SchoolDto schoolDto)
        {
            var school = await _service.AddAsync(_mapper.Map<School>(schoolDto));
            var schoolsDto = _mapper.Map<SchoolDto>(school);
            return CreateActionResult(CustomResponseDto<SchoolDto>.Succes(201, schoolDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(SchoolDto schoolDto)
        {
            await _service.UpdateAsync(_mapper.Map<School>(schoolDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var school = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(school);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }
    }
}
