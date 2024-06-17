﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ImproveU_backend.Models.Dtos.UsuarioDto;

public record UsuarioCreateRequestDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [EmailAddress]
    public string Email { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public int Papel { get; set; }

    [PasswordPropertyText(true)]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [StringLength(15, MinimumLength = 6, ErrorMessage = "O campo {0} deve ter {1} caracteres")]
    public string Senha { get; set; }

    [Compare("Senha", ErrorMessage = "As senhas não conferem")]
    public string ConfirmacaoSenha { get; set; }

}


