using Store.Domain.Commands.Interfaces;

namespace Store.Domain.Commands
{
  // Padronização do resultado da API para realizar uma facildade para o consumo do Front-end

  public class GenericCommandResult : ICommandResult
  {
    public GenericCommandResult(bool success, string message, object data)
    {
      Success = success;
      Message = message;
      Data = data;
    }

    public bool Success { get; set; }
    public string Message { get; set; }
    public object Data { get; set; }
  }
}