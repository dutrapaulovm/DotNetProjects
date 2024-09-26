var builder = WebApplication.CreateBuilder(args);

//Registra os serviços para geração de documentação das APIs e expor esses endpoints
builder.Services.AddEndpointsApiExplorer();

//Adiciona os serviços necessários para arquitetura MVC
builder.Services.AddControllers();

//Registra o serviços de roteamento, que é responsável como definir
//as solicitações HTTP
builder.Services.AddRouting();

var app = builder.Build();

//Habilita o redirecionamento automático de solicitações HTTP para HTTPs
//mesmo que não utilize. Isso garante sempre uma conexão segura
app.UseHttpsRedirection();

//Mapeia os controladores para rotas e endpoints
app.MapControllers();

//Inicia a execução do aplicativo ASP.NET Core
app.Run();