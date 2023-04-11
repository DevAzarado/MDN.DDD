using MDN.DDD.Domain.Contracts.Responses;
using MDN.DDD.Domain.Enums;
using MDN.DDD.Domain.Exceptions;
using MDN.DDD.Domain.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MDN.DDD.API.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override Task OnExceptionAsync(ExceptionContext context)
        {
            var response = new InformacaoResponse();

            if (context.Exception is InformacaoException)
            {
                var informacaoException = (InformacaoException)context.Exception;

                response.Codigo = informacaoException.Codigo;
                response.Mensagens = informacaoException.Mensagens;
                response.Detalhe = context.Exception?.InnerException?.Message;
            }
            else
            {
                response.Codigo = StatusException.Erro;
                response.Mensagens.Add("Erro inesperdado");
                response.Detalhe = context.Exception?.InnerException?.Message;
            }

            context.Result = new ObjectResult(response)
            {
                StatusCode = response.Codigo.GetStatusCode()
            };

            OnException(context);
            return Task.CompletedTask;
        }
    }
}
