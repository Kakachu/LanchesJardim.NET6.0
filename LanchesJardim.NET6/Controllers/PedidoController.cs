using LanchesJardim.NET6.Models;
using LanchesJardim.NET6.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesJardim.NET6.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Pedido pedido)
        {
            int totalItensPedido = 0;
            decimal precoTotalPedido = 0.0m;

            List<CarrinhoCompraItem> items = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItems = items;

            if(_carrinhoCompra.CarrinhoCompraItems.Count == 0)
            {
                ModelState.AddModelError("", "Seu carrinho está vazio, por que não incluir um lanche?");
            }

            //calculando o total de itens pedidos e o preço total
            foreach(var item in items)
            {
                totalItensPedido += item.Quantidade;
                precoTotalPedido += (item.Lanche.Preco * item.Quantidade);
            }

            if (ModelState.IsValid)
            {
                //criar o pedido
                _pedidoRepository.CriarPedido(pedido);

                //define mensagens ao Cliente
                ViewBag.CheckoutCompletoMensagem = "Pedido realizado com êxito 😎👍";
                ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoCompraTotal();

                //limpar o carrinho
                _carrinhoCompra.LimparCarrinho();

                //retorna os dados do Cliente e do pedido
                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
            }
            return View(pedido);
        }
    }
}
