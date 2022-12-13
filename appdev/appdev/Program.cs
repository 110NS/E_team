

using Microsoft.Data.SqlClient;

using System.Text;

using System.Diagnostics;



try

{

    // 接続情報の作成 

    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

    builder.DataSource = "schoolnetdb.database.windows.net"; // 接続DBサーバー 

    builder.UserID = "schoolnetadmin"; // 管理者ID 

    builder.Password = "schoolnetpass000!"; // 管理者パスワード 

    builder.InitialCatalog = "DB"; // DB名 



    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))

    {

        Debug.WriteLine("\nQuery data example:");

        Debug.WriteLine("=========================================\n");



        // SQL文の作成 

        StringBuilder sb = new StringBuilder();

        sb.Append("SELECT * ");

        sb.Append("FROM Student");



        String sql = sb.ToString();



        using (SqlCommand command = new SqlCommand(sql, connection))

        {

            // 接続処理 

            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())

            {

                while (reader.Read())

                {

                    // データ表示 

                    Debug.WriteLine("{0}", reader["StudentName"]); // 表示列名の指定やり方 

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
