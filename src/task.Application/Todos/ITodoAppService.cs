using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task.Todos.Dto;

namespace task.Todos
{
    public interface ITodoAppService : IApplicationService
    {
        Task<List<TodoDto>> GetAll();
        Task<TodoDto> Get(Guid id);
        Task Create(TodoDto input);
        Task Update(Guid id);
        Task Delete(Guid id);
    }
}
