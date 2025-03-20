//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

using register.CRUD;
using register.DataBaseRegister;

DbRegister Conn = new DbRegister();
Conn.OpenConn();
Conn.CloseConn();
CRUD insert = new CRUD();
insert.insert("Marcelo", 45454, "Marcelo@gmail.com", "d65sa656", "");
insert.Delete(3);
insert.update(7, "joao");
insert.Select();

