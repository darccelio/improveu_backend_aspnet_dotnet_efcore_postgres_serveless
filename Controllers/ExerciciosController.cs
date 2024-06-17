﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ImproveU_backend.DatabaseConfiguration.Configuration;
using ImproveU_backend.Models;
using ImproveU_backend.Services.Interfaces.ITreinoServices;
using ImproveU_backend.Models.Dtos.TreinoDto;
using ImproveU_backend.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace ImproveU_backend.Controllers;

[Authorize]
[ApiController]
[Route("api/exercicios")]
public class ExerciciosController : ControllerBase
{
    private readonly IExercicioService _exercicioService;

    public ExerciciosController(IExercicioService exercicio)
    {
        _exercicioService = exercicio;
    }

    [ClaimsAuthorize("educador", "criar")]
    [HttpPost]
    [ProducesResponseType(typeof(ExercicioResponseDto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Criar([FromBody] ExercicioCreateRequestDto exercicioDto)
    {
        try
        {
            ExercicioResponseDto exercicio = await _exercicioService.CriarAsync(exercicioDto);
            return CreatedAtAction(nameof(ExerciciosController.BuscarExecicioPorId), new { id = exercicio.Id }, exercicio);
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException?.Message);
        }
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ExercicioResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> BuscarExecicioPorId(int id)
    {
        try
        {
            var exercicio = await _exercicioService.BuscarPorIdAsync(id);
            if (exercicio == null)
            {
                return NotFound();
            }
            return Ok(exercicio);
        }
        catch (Exception e)
        {
            return BadRequest($"Erro ao encontar o exercício pelo motivo: {e.Message}");
        }
    }

    [ClaimsAuthorize("educador", "ler")]
    [HttpGet]
    [ProducesResponseType(typeof(ExercicioResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Buscar([FromQuery] int skip = 0,
                                            [FromQuery] int take = 10,
                                            [FromQuery] string? nome = "")
    {
        try
        {
            IEnumerable<ExercicioResponseDto> exercicios;
            if (!string.IsNullOrWhiteSpace(nome))
            {
                exercicios = await _exercicioService.BuscarPorNomeAsync(nome, skip, take);
                if (exercicios == null)
                {
                    return NotFound("Exercicio não localizado");
                }
                return Ok(exercicios);
            }

            exercicios = await _exercicioService.BuscarAsync(skip, take);
            return Ok(exercicios);
        }
        catch (Exception e)
        {
            return BadRequest($"Erro ao encontar o(s) exercício(s) pelo motivo: {e.Message}");
        }
    }

    [ClaimsAuthorize("educador", "editar")]
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Atualizar(int id, [FromBody] ExercicioUpdateRequestDto exercicioDto)
    {
        try
        {
            await _exercicioService.Atualizar(id, exercicioDto);
            return NoContent();
        }
        catch (Exception e)
        {
            return BadRequest($"Erro ao atualizar o exercício pelo motivo: {e.Message}");
        }
    }

}
