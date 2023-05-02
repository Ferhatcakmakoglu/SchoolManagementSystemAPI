﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{

    public class StudentsController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Student> _service;
        private readonly IStudentsWithSchoolService _studentsWithSchoolService;
        public StudentsController(IMapper mapper, IService<Student> service, IStudentsWithSchoolService studentsWithSchoolService)
        {
            _mapper = mapper;
            _service = service;
            _studentsWithSchoolService = studentsWithSchoolService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetStudentsWithSchool()
        {
            return CreateActionResult(await _studentsWithSchoolService.GetStudentsWithSchool());
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var students = await _service.GetAllAsync();
            var studentsDto = _mapper.Map<List<StudentDto>>(students.ToList());
            return CreateActionResult(CustomResponseDto<List<StudentDto>>.Succes(200, studentsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _service.GetByIdAsync(id);
            var studentDto = _mapper.Map<StudentDto>(student);
            return CreateActionResult(CustomResponseDto<StudentDto>.Succes(200, studentDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(StudentDto studentDto)
        {
            var student = await _service.AddAsync(_mapper.Map<Student>(studentDto));
            var studentsDto = _mapper.Map<StudentDto>(student);
            return CreateActionResult(CustomResponseDto<StudentDto>.Succes(201, studentDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(StudentDto studentDto)
        {
            await _service.UpdateAsync(_mapper.Map<Student>(studentDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var student = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(student);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Succes(204));
        }
    }
}
