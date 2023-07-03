using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheBalance.Service.DTOs.Expenses;
using TheBalance.Service.Interfaces.Expenses;


namespace TheBalance.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService expenseService;
        public ExpenseController(IExpenseService expenseService)
        {
            this.expenseService = expenseService;
        }

        // GET: api/ExpenseController
        [HttpGet]
        public async Task<IActionResult> GetAllExpense()
        {
            return Ok(await expenseService.GetAllAsync());
        }

        // GET api/ExpenseController
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await expenseService.GetByIdAsync(id));
        }

        // POST api/ExpenseController/
        [HttpPost]
        public async Task<IActionResult> PostExpense(ExpenseForCreateDTO dto)
        {
            return Ok(await expenseService.CreateAsync(dto));    
        }

        // PUT api/ExpenseController/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpense(
            [FromRoute]int id, 
            [FromQuery] ExpenseForCreateDTO expenseForCreateDTO)
        {
            return Ok(await expenseService.UpdateAsync(id, expenseForCreateDTO));
        }

        // DELETE api/ExpenseController/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await expenseService.DeleteAsync(id));
        }
    }
}
