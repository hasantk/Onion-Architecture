using ETicaretApi.Application.Abstractions;
using ETicaretApi.Application.Repositories;
using ETicaretApi.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;

        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IOrderWriteRepository orderWriteRepository,ICustomerWriteRepository customerWriteRepository,IOrderReadRepository orderReadRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //  new() { Id=Guid.NewGuid(),Name="Urun 1",Price=100,CreatedDate=DateTime.UtcNow,Stock=36},
            //  new() { Id=Guid.NewGuid(),Name="Urun 2",Price=190,CreatedDate=DateTime.UtcNow,Stock=55},
            //  new() { Id=Guid.NewGuid(),Name="Urun 3",Price=180,CreatedDate=DateTime.UtcNow,Stock=25}
            //});
            //var count = await _productWriteRepository.SaveAsync();

            ////var list = _productReadRepository.GetAll();

            //return Ok(count);

            //_productReadRepository getirip _productWriteRepository üzerinden yapilan degisikligi kaydetmemizi saglayan ServiceRegistration'da ki AddScoplardir
            //Product p = await _productReadRepository.GetByIdAsync("9E895BCF-5572-45B1-8D08-55EBC0D10A51",false);
            //p.Name = "Mehmet";
            //var y =await _productWriteRepository.SaveAsync();
            //return Ok(y);
            //var p= await _productWriteRepository.AddAsync(new() { Name = "H Urun", Price = 1.32F, Stock = 45, CreatedDate = DateTime.UtcNow });
            //await _productWriteRepository.SaveAsync();
            //return Ok(p);
            //var customerId = Guid.NewGuid();
            //_customerWriteRepository.AddAsync(new() { Name = "Hasan", Id = customerId });
            //var a = await _orderWriteRepository.AddRangeAsync(new() {
            //       new () {Description="Bla bla bla",Address="Bursa, İznik",CustemorId=customerId},
            //       new() { Description="Come come come",Address="Düzce, Gölyaka",CustemorId=customerId}
            //});
            //await _orderWriteRepository.SaveAsync();
            //return Ok(a);
            Order o = await _orderReadRepository.GetByIdAsync("490B979F-176C-4297-5FC6-08DAC94922DC");
            o.Description = "Değişiklik Yapıldı";
            await _orderWriteRepository.SaveAsync();
            return Ok(o);
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
