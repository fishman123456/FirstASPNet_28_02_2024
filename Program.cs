internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();

        app.MapGet("/", () => $"сервер запущен: {DateTime.UtcNow}");

        app.MapGet("/ping", () => "pong");

        app.MapGet("/info", () =>
        {
            string str = Convert.ToString( Environment.OSVersion) + "\n";
            str+=("Операционная система (номер версии):  ", Environment.OSVersion) + "\n";
            str += ("Разрядность процессора:  ", Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")) + "\n";
            str += ("Модель процессора:  ", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")) + "\n";
            str += ("Путь к системному каталогу:  ", Environment.SystemDirectory) + "\n";
            str += ("Число процессоров:  ", Environment.ProcessorCount) + "\n";
            str += ("Имя пользователя: ", Environment.UserName) + "\n";
            return str;
        });

        app.Run();
    }
}