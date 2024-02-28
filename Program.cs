internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var app = builder.Build();

        app.MapGet("/", () => $"������ �������: {DateTime.UtcNow}");

        app.MapGet("/ping", () => "pong");

        app.MapGet("/info", () =>
        {
            string str = Convert.ToString( Environment.OSVersion) + "\n";
            str+=("������������ ������� (����� ������):  ", Environment.OSVersion) + "\n";
            str += ("����������� ����������:  ", Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")) + "\n";
            str += ("������ ����������:  ", Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")) + "\n";
            str += ("���� � ���������� ��������:  ", Environment.SystemDirectory) + "\n";
            str += ("����� �����������:  ", Environment.ProcessorCount) + "\n";
            str += ("��� ������������: ", Environment.UserName) + "\n";
            return str;
        });

        app.Run();
    }
}