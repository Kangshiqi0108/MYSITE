using mysiteapi.Models;
using mysiteapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace mysiteapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DiaryController : ControllerBase
{
    private readonly DiaryService _diaryService;

    public DiaryController(DiaryService diaryService) =>
        _diaryService = diaryService;

    [HttpGet]
    public async Task<List<Diary>> Get() =>
        await _diaryService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Diary>> Get(string id)
    {
        var diary = await _diaryService.GetAsync(id);

        if (diary is null)
        {
            return NotFound();
        }

        return diary;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Diary newDiary)
    {
        await _diaryService.CreateAsync(newDiary);

        return CreatedAtAction(nameof(Get), new { id = newDiary.Id }, newDiary);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, Diary updatedDiary)
    {
        var diary = await _diaryService.GetAsync(id);

        if (diary is null)
        {
            return NotFound();
        }

        updatedDiary.Id = diary.Id;

        await _diaryService.UpdateAsync(id, updatedDiary);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var diary = await _diaryService.GetAsync(id);

        if (diary is null)
        {
            return NotFound();
        }

        await _diaryService.RemoveAsync(id);

        return NoContent();
    }
}