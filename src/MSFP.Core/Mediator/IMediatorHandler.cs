﻿using MSFP.Core.Messages;
using System.ComponentModel.DataAnnotations;

namespace MSFP.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<ValidationResult> EnviarComando<T>(T comando) where T : Command;
    }
}
