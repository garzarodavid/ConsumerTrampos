using ConsumerTrampos.Application.Common.Interfaces;
using ConsumerTrampos.Application.Consumers;
using ConsumerTrampos.Application.Consumers.Commands;
using ConsumerTrampos.Domain.Consumers;
using Microsoft.AspNetCore.Mvc;

namespace ConsumerTrampos.Api.ConsumerWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsumersController : ControllerBase
    {
        private readonly IConsumerService _consumerService;

        public ConsumersController(IConsumerService consumerService)
        {
            _consumerService = consumerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetConsumers()
        {
            var consumers = await _consumerService.GetConsumersAsync();
            return Ok(consumers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsumer(Guid id)
        {
            var consumer = await _consumerService.GetConsumerAsync(id);
            return Ok(consumer);

        }

        [HttpPost]
        public async Task<IActionResult> CreateConsumer(CreateConsumerCommand command)
        {
            var result = await _consumerService.CreateConsumerAsync(command);

            if (result.IsSuccess)
            {
                return CreatedAtAction(nameof(GetConsumers), new { id = result.Value }, result.Value);
            }
            else
            {
                return BadRequest(result.Error);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateConsumer(Guid id, UpdateConsumerCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            var result = await _consumerService.UpdateConsumerAsync(command);

            if (result.IsSuccess)
            {
                return await GetConsumer(id);
            }
            else
            {
                return BadRequest(result.Error);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsumer(Guid id)
        {
            var result = await _consumerService.DeleteConsumerAsync(id);

            if (result.IsSuccess)
            {
                return NoContent();
            }
            else
            {
                return BadRequest(result.Error);
            }
        }
    }
}