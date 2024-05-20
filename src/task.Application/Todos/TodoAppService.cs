using Abp.Application.Services;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task.Entities;
using task.Todos.Dto;

namespace task.Todos
{
    public class TodoAppService : ApplicationService, ITodoAppService
    {
        private readonly IRepository<Todo, Guid> _todoRepository;
        private readonly IMapper _mapper;

        public TodoAppService(IRepository<Todo, Guid> todoRepository, IMapper mapper)
        {
            _todoRepository = todoRepository;
            _mapper = mapper;
        }

        public async Task<List<TodoDto>> GetAll()
        {
            var todos = await _todoRepository.GetAllListAsync();
            return _mapper.Map<List<TodoDto>>(todos);
        }

        public async Task<TodoDto> Get(Guid id)
        {
            var todo = await _todoRepository.GetAsync(id);
            return _mapper.Map<TodoDto>(todo);
        }

        public async Task Create(TodoDto input)
        {
            var todo = _mapper.Map<Todo>(input);
            todo.Id = Guid.NewGuid();
            todo.CreatedDate = DateTime.Now;
            await _todoRepository.InsertAsync(todo);
        }

        public async Task Update(Guid id)
        {
            var todo = await _todoRepository.GetAsync(id);
            if (todo == null)
            {
                throw new EntityNotFoundException(typeof(Todo), id);
            }

            // Toggle the IsCompleted property
            todo.IsCompleted = !todo.IsCompleted;

            await _todoRepository.UpdateAsync(todo);
        }

        public async Task Delete(Guid id)
        {
            await _todoRepository.DeleteAsync(id);
        }
    }
}
