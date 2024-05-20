using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using task.Todos.Dto;
using task.Todos;

namespace task.Web.Host.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : AbpController
    {
        private readonly ITodoAppService _todoAppService;

        public TodoController(ITodoAppService todoAppService)
        {
            _todoAppService = todoAppService;
        }

        [HttpGet]
        public async Task<List<TodoDto>> GetAll()
        {
            return await _todoAppService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<TodoDto> Get(Guid id)
        {
            return await _todoAppService.Get(id);
        }

        [HttpPost]
        public async Task Create([FromBody] TodoDto input)
        {
            await _todoAppService.Create(input);
        }

        [HttpPut("{id}")]
        public async Task Update(Guid id)
        {
            await _todoAppService.Update(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _todoAppService.Delete(id);
        }
    }
}
