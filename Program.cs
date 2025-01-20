var builder = WebApplication.CreateBuilder(args);

// ������ ������ ��� ����������
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ������ middleware ��� ��������� �������
app.UseMiddleware<ErrorLoggingMiddleware>();

app.MapDefaultControllerRoute(); // �� ����������� ������������� ����������

app.Run();
