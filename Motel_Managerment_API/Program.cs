using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Motel_Managerment_API.Mapping;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            //======================================
            builder.Services.AddDbContext<DBNhaTroContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStrings"));
            });
            //======================================
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ChuNhaMapping());
                mc.AddProfile(new PhongTroMapping());
                mc.AddProfile(new TinhTrangMapping());
                mc.AddProfile(new KhachThueMapping());
                mc.AddProfile(new HopDongMapping());
                mc.AddProfile(new HopDongMapping());
                mc.AddProfile(new ChuNhaxHopDongMapping());
                mc.AddProfile(new KhachThuexHopDongMapping());
                mc.AddProfile(new PhongTroxHopDongMapping());
                mc.AddProfile(new DichVuMapping());
                mc.AddProfile(new ThanhToanMapping());
                mc.AddProfile(new HoaDonMapping());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            builder.Services.AddSingleton(mapper);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}