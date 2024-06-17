﻿using ImproveU_backend.Models;

namespace ImproveU_backend.Services.Interfaces.Notificacoes;

public interface INotificadorService
{
    bool TemNotificacao();
    List<Notificacao> ObterNotificacoes();
    void Handle(Notificacao notificacao);
}