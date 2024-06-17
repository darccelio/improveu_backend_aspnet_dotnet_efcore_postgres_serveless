﻿using ImproveU_backend.Models.Dtos.UsuarioDto;

namespace ImproveU_backend.Services.Interfaces.IUsuarioServices;

public interface IUsuarioServices
{
    public Task<UsuarioResponseDto> CriarAsync(UsuarioCreateRequestDto usuarioRequest);
    public Task<UsuarioResponseDto> BuscarPorIdAsync(int id);
    public Task<IEnumerable<UsuarioResponseDto>> BuscarAsync(int skip, int take);
    public Task<UsuarioResponseDto> BuscarPorEmailAsync(string email);

    public Task<bool> AtualizarAsync(int id, UsuarioUpdateRequestDto usuarioRequest);
    public Task InativarPorIdAsync(int id);
}