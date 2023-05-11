using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
    public class TeachersController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Teacher> _service;

        public TeachersController(IMapper mapper, IService<Teacher> service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var teachers = await _service.GetAllAsync();
            var teachersDto = _mapper.Map<List<TeacherDto>>(teachers.ToList());
            return CreateActionResult(CustomResponseDto<List<TeacherDto>>.Succes(200, teachersDto));
        }

    [ServiceFilter(typeof(NotFoundFilter<Teacher>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var teacher = await _service.GetByIdAsync(id);
            var teacherDto = _mapper.Map<TeacherDto>(teacher);
            return CreateActionResult(CustomResponseDto<TeacherDto>.Succes(200, teacherDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(TeacherDto teacherDto)
        {
            var teacher = await _service.AddAsync(_mapper.Map<Teacher>(teacherDto));
            var teachersDto = _mapper.Map<TeacherDto>(teacher);
            return CreateActionResult(CustomResponseDto<TeacherDto>.Succes(201,teacherDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(TeacherDto teacherDto)
        {
            await _service.UpdateAsync(_mapper.Map<Teacher>(teacherDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }

    [ServiceFilter(typeof(NotFoundFilter<Teacher>))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var teacher = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(teacher);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }
    }
}
