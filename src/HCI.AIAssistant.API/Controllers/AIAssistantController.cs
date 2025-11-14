using Microsoft.AspNetCore.Mvc;
using HCI.AIAssistant.API.Models.DTOs.AIAssistantController;

namespace HCI.AIAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AIAssistantController : ControllerBase
{
    [HttpPost("/message")]
    public async Task<ActionResult<AIAssistantControllerPostMessageResponseDTO>> PostMessageAsync(AIAssistantControllerPostMessageRequestDTO request)
    {
        AIAssistantControllerPostMessageResponseDTO response = new()
        {
            TextMessage = "Hello " + request.TextMessage
        };

        return Ok(response);
    }
}