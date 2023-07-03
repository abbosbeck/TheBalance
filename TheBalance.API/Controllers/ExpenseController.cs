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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/ExpenseController/
        [HttpPost]
        public async Task<IActionResult> PostExpense(ExpenseForCreateDTO dto)
        {
            return Ok(await expenseService.CreateAsync(dto));    
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpense(
            [FromRoute]int id, 
            [FromQuery] ExpenseForCreateDTO expenseForCreateDTO)
        {
            return Ok(await expenseService.UpdateAsync(id, expenseForCreateDTO));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
