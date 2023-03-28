global using AutoMapper;
global using houseofgriffin_api.Data;
global using houseofgriffin_api.Dtos.AddressDtos;
global using houseofgriffin_api.Dtos.AvailableScheduleDtos;
global using houseofgriffin_api.Dtos.EADtos;
global using houseofgriffin_api.Dtos.EPDtos;
global using houseofgriffin_api.Dtos.ExamDateDtos;
global using houseofgriffin_api.Dtos.OADtos;
global using houseofgriffin_api.Dtos.ParentDtos;
global using houseofgriffin_api.Dtos.PaymentDtos;
global using houseofgriffin_api.Dtos.PreferredDayDtos;
global using houseofgriffin_api.Dtos.PrivateClassDtos;
global using houseofgriffin_api.Dtos.PrivateCourseDtos;
global using houseofgriffin_api.Dtos.PrivateRegistrationRequestDtos;
global using houseofgriffin_api.Dtos.PrivateRegReqInformationDtos;
global using houseofgriffin_api.Dtos.PrivateRegReqWithInfoDtos;
global using houseofgriffin_api.Dtos.ScheduleDtos;
global using houseofgriffin_api.Dtos.StaffDtos;
global using houseofgriffin_api.Dtos.StudentDtos;
global using houseofgriffin_api.Dtos.StudentAddtionalFilesDtos;
global using houseofgriffin_api.Dtos.StudentPrivateClassDtos;
global using houseofgriffin_api.Dtos.TeacherDtos;
global using houseofgriffin_api.Dtos.TeacherLeavingRequestDtos;
global using houseofgriffin_api.Dtos.TeacherPrivateClassDtos;
global using houseofgriffin_api.Dtos.UserDtos;
global using houseofgriffin_api.Dtos.WorkTimeDtos;
global using houseofgriffin_api.Models;
global using houseofgriffin_api.Services.AuthenticationService;
global using houseofgriffin_api.Services.CheckAvailableService;
global using houseofgriffin_api.Services.EAService;
global using houseofgriffin_api.Services.EPService;
global using houseofgriffin_api.Services.OAService;
global using houseofgriffin_api.Services.PaymentService;
global using houseofgriffin_api.Services.PrivateRegistrationRequestService;
global using houseofgriffin_api.Services.ScheduleService;
global using houseofgriffin_api.Services.StaffService;
global using houseofgriffin_api.Services.StudentService;
global using houseofgriffin_api.Services.TeacherService;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using System.ComponentModel.DataAnnotations;
global using System.Text;

//Authen
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.AspNetCore.Authorization;
global using System.Security.Claims;
global using Microsoft.AspNetCore.Authentication;
global using Microsoft.Extensions.Options;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using System.IdentityModel.Tokens.Jwt;
global using Google.Cloud.Firestore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using Google.Apis.Auth.OAuth2;
using FirebaseAdmin;
using FirebaseAdminAuthentication.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ICheckAvailableService, CheckAvailableService>();
builder.Services.AddScoped<IEAService, EAService>();
builder.Services.AddScoped<IEPService, EPService>();
builder.Services.AddScoped<IOAService, OAService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IPrivateRegistrationRequestService, PrivateRegistrationRequestService>();
builder.Services.AddScoped<IScheduleService, ScheduleService>();
builder.Services.AddScoped<IStaffService, StaffService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"Bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", AppDomain.CurrentDomain.BaseDirectory + @"firebase-config.json");
builder.Services.AddSingleton(FirebaseApp.Create());
builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
       .AddScheme<AuthenticationSchemeOptions, FirebaseAuthenticationHandler>(JwtBearerDefaults.AuthenticationScheme, (o) => { });

builder.Services.ConfigureSwaggerGen(setup =>
{
    setup.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "House of Griffin",
        Version = "v1.0.2"
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

