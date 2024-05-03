﻿namespace ImproveU_backend.Models.Dtos;

public record UsuarioResponseDto
{

    public UsuarioResponseDto(Usuario usuario)
    {
        Id = usuario?.Id.ToString();
        Email = usuario?.Email;
        Papel = usuario?.Papel;
        Ativo = usuario?.Ativo;
        DataCriacao = usuario?.DataCriacao.ToShortDateString();
        UltimaAlteracao = usuario?.UltimaAlteracao != null ? usuario.UltimaAlteracao.Value.ToShortDateString() : null;
    }

    public string? Id { get; set; }

    public string? Email { get; set; }

    public int? Papel { get; set; }

    public int? Ativo { get; set; }

    public string? DataCriacao { get; set; }

    public string? UltimaAlteracao { get; set; }

}
