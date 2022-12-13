

using Microsoft.Data.SqlClient;

using System.Text;

using System.Diagnostics;



try

{

    // �ڑ����̍쐬 

    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

    builder.DataSource = "schoolnetdb.database.windows.net"; // �ڑ�DB�T�[�o�[ 

    builder.UserID = "schoolnetadmin"; // �Ǘ���ID 

    builder.Password = "schoolnetpass000!"; // �Ǘ��҃p�X���[�h 

    builder.InitialCatalog = "DB"; // DB�� 



    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))

    {

        Debug.WriteLine("\nQuery data example:");

        Debug.WriteLine("=========================================\n");



        // SQL���̍쐬 

        StringBuilder sb = new StringBuilder();

        sb.Append("SELECT * ");

        sb.Append("FROM Student");



        String sql = sb.ToString();



        using (SqlCommand command = new SqlCommand(sql, connection))

        {

            // �ڑ����� 

            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())

            {

                while (reader.Read())

                {

                    // �f�[�^�\�� 

                    Debug.WriteLine("{0}", reader["StudentName"]); // �\���񖼂̎w����� 

                }

            }

        }

    }

}

catch (SqlException e)

{

    Debug.WriteLine(e.ToString());

}
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
