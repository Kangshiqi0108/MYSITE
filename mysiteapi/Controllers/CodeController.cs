using mysiteapi.Models;
using mysiteapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace mysiteapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CodeController : ControllerBase
{
    private readonly CodeService _codeService;

    public CodeController(CodeService codeService) =>
        _codeService = codeService;

    [HttpGet]
    public async Task<List<Code>> Get() =>
        await _codeService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Code>> Get(string id)
    {
        var code = await _codeService.GetAsync(id);

        if (code is null)
        {
            return NotFound();
        }

        return code;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Code newCode)
    {
        await _codeService.CreateAsync(newCode);

        return CreatedAtAction(nameof(Get), new { id = newCode.Id }, newCode);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, Code updatedCode)
    {
        var code = await _codeService.GetAsync(id);

        if (code is null)
        {
            return NotFound();
        }

        updatedCode.Id = code.Id;

        await _codeService.UpdateAsync(id, updatedCode);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var code = await _codeService.GetAsync(id);

        if (code is null)
        {
            return NotFound();
        }

        await _codeService.RemoveAsync(id);

        return NoContent();
    }
}