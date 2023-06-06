using mysiteapi.Models;
using mysiteapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace mysiteapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly StudentService _studentService;

    public StudentController(StudentService studentService) =>
        _studentService = studentService;

    [HttpGet]
    public async Task<List<Student>> Get() =>
        await _studentService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Student>> Get(string id)
    {
        var student = await _studentService.GetAsync(id);

        if (student is null)
        {
            return NotFound();
        }

        return student;
    }

    [HttpPost]
    public async Task<IActionResult> Post(Student newStudent)
    {
        await _studentService.CreateAsync(newStudent);

        return CreatedAtAction(nameof(Get), new { id = newStudent.Id }, newStudent);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, Student updatedStudent)
    {
        var student = await _studentService.GetAsync(id);

        if (student is null)
        {
            return NotFound();
        }

        updatedStudent.Id = student.Id;

        await _studentService.UpdateAsync(id, updatedStudent);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var student = await _studentService.GetAsync(id);

        if (student is null)
        {
            return NotFound();
        }

        await _studentService.RemoveAsync(id);

        return NoContent();
    }
}